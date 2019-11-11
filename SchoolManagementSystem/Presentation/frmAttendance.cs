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
using SchoolManagementSystem.Class;
using SchoolManagementSystem.ClassManager;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmAttendance : Form
    {
        private bool m_useAnsiTemplate = false; // true;  
        public SGFingerPrintManager m_FPM;
        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
        private Int32 m_Dpi;
        private SGFPMSecurityLevel m_SecurityLevel;

        private Byte[] m_RegMin1;
        private Byte[] m_RegMin2;
        private Byte[] m_VrfMin;
        public Byte[] m_StoredTemplate;
        private bool m_DeviceOpened;
        FingerRegisterManager aFingerRegisterManager = new FingerRegisterManager();
        public frmAttendance()
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
            lblDeviceStatus.Text = "Device is not Connected";
            btnConnect.Text = "Connect";
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
            }
            else
            {
                StatusBar.Text = "Init() Error " + error;
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
                    DeviceConnected();
                }
                else
                {
                    StatusBar.Text = "OpenDevice() Error : " + error;
                    DeviceDisconnected();
                }
            }
        }


        private void checkFinger()
        {
            string[] fingerpos_str = new string[]
                                      {
                              "Unknown finger",
                              "Right thumb",
                              "Right index finger",
                              "Right middle finger",
                              "Right ring finger",
                              "Right little finger",
                              "Left thumb",
                              "Left index finger",
                              "Left middle finger",
                              "Left ring finger",
                              "Left little finger"};
            Int32 err;
            SGFPMFingerPosition finger_pos = SGFPMFingerPosition.FINGPOS_UK;
            SGFPMISOTemplateInfo sample_info = new SGFPMISOTemplateInfo();
            bool finger_found = false;
            FingerRegister aFingerRegister = new FingerRegister();
            DataTable finger = aFingerRegisterManager.GetAllFingerData(aFingerRegister);

            foreach (DataRow dr in finger.Rows)
            {
                Console.WriteLine("FINGERSAMPLE1" + dr["FINGERSAMPLE1"].ToString());
                foreach (DataColumn dc in finger.Columns)
                {
                    m_StoredTemplate = (Byte[])dr[dc];
                    if (m_StoredTemplate == null)
                    {
                        StatusBar.Text = "No data to verify";
                        return;
                    }
                    
                    err = m_FPM.GetIsoTemplateInfo(m_StoredTemplate, sample_info);

                    for (int i = 0; i < sample_info.TotalSamples; i++)
                    {
                        bool matched = false;
                        err = m_FPM.MatchIsoTemplate(m_StoredTemplate, i, m_VrfMin, 0, m_SecurityLevel, ref matched);
                        if (matched)
                        {
                            finger_found = true;
                            //finger_pos = (SGFPMFingerPosition)sample_info.SampleInfo[i].FingerNumber;
                            break;
                        }
                    }
                   
                    if (err == (Int32)SGFPMError.ERROR_NONE)
                    {
                        if (finger_found)
                        {
                            Attendance attendance = new Attendance();
                            attendance.StudentId = 1;
                            attendance.TodayDate = DateTime.Now;
                            if (attendance.Insert())
                            {
                                StatusBar.Text = "Welcome";
                            }
                            else
                            {
                                StatusBar.Text = "Error";
                            }
                            
                            
                            return;
                        }
                    }
                    else
                    {
                        if (m_useAnsiTemplate)
                        {
                            StatusBar.Text = "MatchAnsiTemplate() Error : " + err;
                        }
                        else
                        {
                            StatusBar.Text = "MatchIsoTemplate() Error : " + err;
                        }
                    }
                }   
            }
            if (!finger_found)
            {
                StatusBar.Text = "Cannot find a matched data";
            }
        }


        private void DrawImage(Byte[] imgData, PictureBox picBox)
        {
            int colorval;
            Bitmap bmp = new Bitmap(m_ImageWidth, m_ImageHeight);
            picBox.Image = (Image)bmp;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    colorval = (int)imgData[(j * m_ImageWidth) + i];
                    bmp.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval));
                }
            }
            picBox.Refresh();
        }



        private bool captureFinger()
        {
            Byte[] fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            Int32 error = (Int32)SGFPMError.ERROR_NONE;
            Int32 img_qlty = 0;

            if (m_DeviceOpened)
                error = m_FPM.GetImage(fp_image);
            else
            {
                DeviceDisconnected();
                return false;
            }
                

            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            progressBar_V1.Value = img_qlty;

            if (error == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image, pictureBoxV1);

                SGFPMFingerInfo finger_info = new SGFPMFingerInfo();
                finger_info.FingerNumber = (SGFPMFingerPosition) 1;//(SGFPMFingerPosition)comboBoxSelFinger.SelectedIndex;
                finger_info.ImageQuality = (Int16)img_qlty;
                finger_info.ImpressionType = (Int16)SGFPMImpressionType.IMPTYPE_LP;
                finger_info.ViewNumber = 1;

                // Create template
                error = m_FPM.CreateTemplate(finger_info, fp_image, m_VrfMin);

                if (error == (Int32)SGFPMError.ERROR_NONE)
                {
                    //StatusBar.Text = "Verification image is captured";
                    return true;
                }

                else
                {
                    //StatusBar.Text = "GetMinutiae() Error : " + error;
                    return false;
                }
                    
            }
            else
            {
                //StatusBar.Text = "GetImage() Error : " + error;
                return false;
            }
                
        }


        protected override void WndProc(ref Message message)
        {
            if (message.Msg == (int)SGFPMMessages.DEV_AUTOONEVENT)
            {
             //   StatusBar.Text = "Please place your finger on the device";
                if (message.WParam.ToInt32() == (Int32)SGFPMAutoOnEvent.FINGER_ON)
                {
                    StatusBar.Text = "";
                    pictureBoxV1.Image = null;
                    progressBar_V1.Value = 0;
                    if (captureFinger())
                    {
                        checkFinger();
                    }                    
                }
                //else if (message.WParam.ToInt32() == (Int32)SGFPMAutoOnEvent.FINGER_OFF)
                //    StatusBar.Text = "Please place your finger on the device";
            }
            base.WndProc(ref message);
        }
    }
}
