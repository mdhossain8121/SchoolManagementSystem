using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecuGen.FDxSDKPro.Windows;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmAttedndance : Form
    {
        private bool m_useAnsiTemplate = false; // true;  
        private SGFingerPrintManager m_FPM;
        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
        private Int32 m_Dpi;
        private SGFPMSecurityLevel m_SecurityLevel;

        private Byte[] m_RegMin1;
        private Byte[] m_RegMin2;
        private Byte[] m_VrfMin;
        private Byte[] m_StoredTemplate;
        private bool m_DeviceOpened;
        public frmAttedndance()
        {
            InitializeComponent();
            timer1.Start();

            //Device information
            m_SecurityLevel = SGFPMSecurityLevel.NORMAL;
            m_StoredTemplate = null;
            m_ImageWidth = 260;
            m_ImageHeight = 300;
            m_Dpi = 500;
            m_FPM = new SGFingerPrintManager();

            StatusBar.Text = "Click Connect Button";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void DeviceConnected()
        {
            lblDeviceStatus.Text = "Device is Connected Succesfully";
            btnConnect.Text = "Connected";
            m_FPM.EnableAutoOnEvent(true, (int)this.Handle);
        }

        private void DeviceDisconnected()
        {
            lblDeviceStatus.Text = "Device is Connected Succesfully";
            btnConnect.Text = "Connected";
            m_FPM.EnableAutoOnEvent(false, 0);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Int32 error;
            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU05; 
            Int32 device_id = (Int32)SGFPMPortAddr.USB_AUTO_DETECT;

            m_DeviceOpened = false;

            if (device_name != SGFPMDeviceName.DEV_UNKNOWN)
            {
                error = m_FPM.Init(device_name);

                if (error == (Int32)SGFPMError.ERROR_NONE)
                {
                    m_FPM.CloseDevice();
                    error = m_FPM.OpenDevice(device_id);
                }

                if (error == (Int32)SGFPMError.ERROR_NONE)
                {
                    SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
                    m_FPM.GetDeviceInfo(pInfo);
                    m_ImageWidth = pInfo.ImageWidth;
                    m_ImageHeight = pInfo.ImageHeight;
                }
            }
            else
                error = m_FPM.InitEx(m_ImageWidth, m_ImageHeight, m_Dpi);

            if (error == (Int32)SGFPMError.ERROR_NONE)
            {
                StatusBar.Text = "Initialization Success";
                DeviceConnected();
            }
            else
            {
                StatusBar.Text = "Init() Error " + error;
                DeviceDisconnected();
                return;
            }

            if (m_useAnsiTemplate)
            {
                // Set template format to ANSI 378
                error = m_FPM.SetTemplateFormat(SGFPMTemplateFormat.ANSI378);
            }
            else
            {
                // Set template format to ISO 19794-2
                error = m_FPM.SetTemplateFormat(SGFPMTemplateFormat.ISO19794);
            }

            // Get Max template size
            Int32 max_template_size = 0;
            error = m_FPM.GetMaxTemplateSize(ref max_template_size);

            m_RegMin1 = new Byte[max_template_size];
            m_RegMin2 = new Byte[max_template_size];
            m_VrfMin = new Byte[max_template_size];

            // OpenDevice if device is selected
            if (device_name != SGFPMDeviceName.DEV_UNKNOWN)
            {
                error = m_FPM.OpenDevice(device_id);
                if (error == (Int32)SGFPMError.ERROR_NONE)
                {
                    m_DeviceOpened = true;
                }
                else
                {
                    StatusBar.Text = "OpenDevice() Error : " + error;
                    DeviceDisconnected();
                }
            }
        }
    }
}
