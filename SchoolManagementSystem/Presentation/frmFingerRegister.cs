using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;//.StreamReader;
using SchoolManagementSystem.ClassManager;
using SchoolManagementSystem.Class;
using SecuGen.FDxSDKPro.Windows;

namespace MatchingAnsi
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class frmFingerRegister : System.Windows.Forms.Form
   {
      // true if ANSI template is used, otherwise ISO template is used.     
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
      private bool   m_DeviceOpened;
        //FingerRegisterManager aFingerRegisterManager = new FingerRegisterManager();
        StudentManager aStudentManager = new StudentManager();

      private System.Windows.Forms.RadioButton[] m_RadioButton;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox comboBoxDeviceName;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.PictureBox pictureBoxR2;
      private System.Windows.Forms.PictureBox pictureBoxR1;
      private System.Windows.Forms.Button BtnCapture1;
      private System.Windows.Forms.Button BtnCapture2;
      private System.Windows.Forms.Button OpenDeviceBtn;
      private System.Windows.Forms.Label StatusBar;
      private System.Windows.Forms.ProgressBar progressBar_R1;
      private System.Windows.Forms.ProgressBar progressBar_R2;
      private System.Windows.Forms.Button BtnRegister;
      private System.Windows.Forms.ProgressBar progressBar_V1;
      private System.Windows.Forms.PictureBox pictureBoxV1;
      private System.Windows.Forms.Button BtnCapture3;
      private System.Windows.Forms.Label label2;
        private ComboBox cmbStudent;
        private Button BtnVerify;
        private IContainer components;

        public frmFingerRegister()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            Student aStudet = new Student();
            aStudet.ActiveStatus = 1;
            DataSet dsStudent = aStudet.Select();
            if (dsStudent == null)
            {
                MessageBox.Show(aStudet.Error);
                return;
            }
            cmbStudent.DataSource = dsStudent.Tables[0];
            cmbStudent.DisplayMember = "STUDENT_NAME";
            cmbStudent.ValueMember = "ID";
            cmbStudent.SelectedIndex = -1;
        }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpenDeviceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDeviceName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnVerify = new System.Windows.Forms.Button();
            this.progressBar_V1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxV1 = new System.Windows.Forms.PictureBox();
            this.BtnCapture3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.progressBar_R2 = new System.Windows.Forms.ProgressBar();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.progressBar_R1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxR2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR1 = new System.Windows.Forms.PictureBox();
            this.BtnCapture1 = new System.Windows.Forms.Button();
            this.BtnCapture2 = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxV1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenDeviceBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxDeviceName);
            this.groupBox2.Location = new System.Drawing.Point(1, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 56);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initialization";
            // 
            // OpenDeviceBtn
            // 
            this.OpenDeviceBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OpenDeviceBtn.Location = new System.Drawing.Point(287, 18);
            this.OpenDeviceBtn.Name = "OpenDeviceBtn";
            this.OpenDeviceBtn.Size = new System.Drawing.Size(104, 24);
            this.OpenDeviceBtn.TabIndex = 8;
            this.OpenDeviceBtn.Text = "Connect";
            this.OpenDeviceBtn.UseVisualStyleBackColor = false;
            this.OpenDeviceBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Device Name";
            // 
            // comboBoxDeviceName
            // 
            this.comboBoxDeviceName.Items.AddRange(new object[] {
            "USB FDU05"});
            this.comboBoxDeviceName.Location = new System.Drawing.Point(114, 18);
            this.comboBoxDeviceName.Name = "comboBoxDeviceName";
            this.comboBoxDeviceName.Size = new System.Drawing.Size(152, 21);
            this.comboBoxDeviceName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnVerify);
            this.groupBox1.Controls.Add(this.progressBar_V1);
            this.groupBox1.Controls.Add(this.pictureBoxV1);
            this.groupBox1.Controls.Add(this.BtnCapture3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(288, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 270);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verification";
            // 
            // BtnVerify
            // 
            this.BtnVerify.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnVerify.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerify.Location = new System.Drawing.Point(16, 231);
            this.BtnVerify.Name = "BtnVerify";
            this.BtnVerify.Size = new System.Drawing.Size(104, 23);
            this.BtnVerify.TabIndex = 58;
            this.BtnVerify.Text = "Verify";
            this.BtnVerify.UseVisualStyleBackColor = false;
            this.BtnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // progressBar_V1
            // 
            this.progressBar_V1.Location = new System.Drawing.Point(16, 176);
            this.progressBar_V1.Name = "progressBar_V1";
            this.progressBar_V1.Size = new System.Drawing.Size(104, 12);
            this.progressBar_V1.TabIndex = 55;
            // 
            // pictureBoxV1
            // 
            this.pictureBoxV1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxV1.Location = new System.Drawing.Point(16, 56);
            this.pictureBoxV1.Name = "pictureBoxV1";
            this.pictureBoxV1.Size = new System.Drawing.Size(104, 120);
            this.pictureBoxV1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxV1.TabIndex = 54;
            this.pictureBoxV1.TabStop = false;
            // 
            // BtnCapture3
            // 
            this.BtnCapture3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCapture3.Location = new System.Drawing.Point(16, 192);
            this.BtnCapture3.Name = "BtnCapture3";
            this.BtnCapture3.Size = new System.Drawing.Size(104, 23);
            this.BtnCapture3.TabIndex = 53;
            this.BtnCapture3.Text = "Capture 3";
            this.BtnCapture3.UseVisualStyleBackColor = false;
            this.BtnCapture3.Click += new System.EventHandler(this.BtnCapture3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "LOWEST",
            "LOWER",
            "LOW",
            "BELOW_NORMAL",
            "NORMAL",
            "ABOVE_NORMAL",
            "HIGH",
            "HIGHER",
            "HIGHEST"});
            this.comboBox1.Location = new System.Drawing.Point(48, -40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "NORMAL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BtnRegister);
            this.groupBox3.Controls.Add(this.progressBar_R2);
            this.groupBox3.Controls.Add(this.cmbStudent);
            this.groupBox3.Controls.Add(this.progressBar_R1);
            this.groupBox3.Controls.Add(this.pictureBoxR2);
            this.groupBox3.Controls.Add(this.pictureBoxR1);
            this.groupBox3.Controls.Add(this.BtnCapture1);
            this.groupBox3.Controls.Add(this.BtnCapture2);
            this.groupBox3.Location = new System.Drawing.Point(0, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 270);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registration";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Name";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnRegister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnRegister.Location = new System.Drawing.Point(67, 231);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(152, 23);
            this.BtnRegister.TabIndex = 48;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // progressBar_R2
            // 
            this.progressBar_R2.Location = new System.Drawing.Point(163, 176);
            this.progressBar_R2.Name = "progressBar_R2";
            this.progressBar_R2.Size = new System.Drawing.Size(104, 12);
            this.progressBar_R2.TabIndex = 44;
            // 
            // cmbStudent
            // 
            this.cmbStudent.Items.AddRange(new object[] {
            "Auto Selection",
            "USB FDU08P(U20AP)",
            "USB FDU08(U20A)",
            "USB FDU07A(U10A)",
            "USB FDU07(U10)",
            "USB FDU05",
            "USB FDU04",
            "USB FDU03",
            "USB FDU02",
            "No device"});
            this.cmbStudent.Location = new System.Drawing.Point(67, 21);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(200, 21);
            this.cmbStudent.TabIndex = 6;
            // 
            // progressBar_R1
            // 
            this.progressBar_R1.Location = new System.Drawing.Point(15, 176);
            this.progressBar_R1.Name = "progressBar_R1";
            this.progressBar_R1.Size = new System.Drawing.Size(104, 12);
            this.progressBar_R1.TabIndex = 43;
            // 
            // pictureBoxR2
            // 
            this.pictureBoxR2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxR2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxR2.Location = new System.Drawing.Point(163, 56);
            this.pictureBoxR2.Name = "pictureBoxR2";
            this.pictureBoxR2.Size = new System.Drawing.Size(104, 120);
            this.pictureBoxR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxR2.TabIndex = 27;
            this.pictureBoxR2.TabStop = false;
            // 
            // pictureBoxR1
            // 
            this.pictureBoxR1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxR1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxR1.Location = new System.Drawing.Point(15, 56);
            this.pictureBoxR1.Name = "pictureBoxR1";
            this.pictureBoxR1.Size = new System.Drawing.Size(104, 120);
            this.pictureBoxR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxR1.TabIndex = 26;
            this.pictureBoxR1.TabStop = false;
            // 
            // BtnCapture1
            // 
            this.BtnCapture1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCapture1.Location = new System.Drawing.Point(15, 192);
            this.BtnCapture1.Name = "BtnCapture1";
            this.BtnCapture1.Size = new System.Drawing.Size(104, 23);
            this.BtnCapture1.TabIndex = 23;
            this.BtnCapture1.Text = "Capture 1";
            this.BtnCapture1.UseVisualStyleBackColor = false;
            this.BtnCapture1.Click += new System.EventHandler(this.BtnCapture1_Click);
            // 
            // BtnCapture2
            // 
            this.BtnCapture2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCapture2.Location = new System.Drawing.Point(163, 192);
            this.BtnCapture2.Name = "BtnCapture2";
            this.BtnCapture2.Size = new System.Drawing.Size(104, 23);
            this.BtnCapture2.TabIndex = 24;
            this.BtnCapture2.Text = "Capture 2";
            this.BtnCapture2.UseVisualStyleBackColor = false;
            this.BtnCapture2.Click += new System.EventHandler(this.BtnCapture2_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.StatusBar.Location = new System.Drawing.Point(0, 339);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(425, 24);
            this.StatusBar.TabIndex = 38;
            // 
            // frmFingerRegister
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(425, 363);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFingerRegister";
            this.Text = "Finger Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxV1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1)).EndInit();
            this.ResumeLayout(false);

	  }
      #endregion

      ///// <summary>
      ///// The main entry point for the application.
      ///// </summary>
      //[STAThread]
      //static void Main() 
      //{
      //   Application.Run(new Form1());
      //}

      /////////////////////////////////////
      private void Form1_Load(object sender, System.EventArgs e)
      {
         EnableButtons(false);
            // Init Button
            //m_RadioButton = new RadioButton[11];
            //m_RadioButton[0] = FPPosUnknown;
            //m_RadioButton[1] = FPPosRightThumb;
            //m_RadioButton[2] = FPPosRightIndex;
            //m_RadioButton[3] = FPPosRightMiddle;
            //m_RadioButton[4] = FPPosRightRing;
            //m_RadioButton[5] = FPPosRightLittle;
            //m_RadioButton[6] = FPPosLeftThumb;
            //m_RadioButton[7] = FPPosLeftIndex;
            //m_RadioButton[8] = FPPosLeftMiddle;
            //m_RadioButton[9] = FPPosLeftRing;
            //m_RadioButton[10] = FPPosLeftLittle;

            comboBoxDeviceName.SelectedIndex = 0;
            //comboBoxSelFinger.SelectedIndex = 0;
 

         m_SecurityLevel = SGFPMSecurityLevel.NORMAL;
         m_StoredTemplate = null;
         m_ImageWidth = 260;
         m_ImageHeight = 300;
         m_Dpi = 500;
         m_FPM = new SGFingerPrintManager();

         StatusBar.Text = "Click Init Button";

         if (m_useAnsiTemplate)
         {
             this.Text = "Matching Test: ANSI 378 Format";
         }
         else
         {
             this.Text = "Matching Test: ISO 19794-2 Format";
         }
      }

      /////////////////////////////////////
      private void InitBtn_Click(object sender, System.EventArgs e)
      {
         Int32 error;
         SGFPMDeviceName device_name = SGFPMDeviceName.DEV_UNKNOWN;
         Int32 device_id = (Int32)SGFPMPortAddr.USB_AUTO_DETECT;

         m_DeviceOpened = false;

         // Get device name
         if (comboBoxDeviceName.Text == "USB FDU05")
             device_name = SGFPMDeviceName.DEV_FDU05;
         else if (comboBoxDeviceName.Text == "Auto Selection")
             device_name = SGFPMDeviceName.DEV_AUTO;

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
			EnableButtons(true);
            StatusBar.Text = "Initialization Success";
         }
         else
         {
            EnableButtons(false);
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
         m_VrfMin  = new Byte[max_template_size];

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
               EnableButtons(false);
            }
         }
      }


      /////////////////////////////////////
      private void BtnCapture1_Click(object sender, System.EventArgs e)
      {
         Byte[] fp_image = new Byte[m_ImageWidth*m_ImageHeight];
         Int32 error = (Int32)SGFPMError.ERROR_NONE;
         Int32 img_qlty = 0;
         
         if (m_DeviceOpened) error = m_FPM.GetImage(fp_image);

         if (error == (Int32)SGFPMError.ERROR_NONE)
         {
            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            progressBar_R1.Value = img_qlty;

            DrawImage(fp_image, pictureBoxR1);

            SGFPMFingerInfo finger_info = new SGFPMFingerInfo();
            finger_info.FingerNumber = SGFPMFingerPosition.FINGPOS_UK;
            finger_info.ImageQuality = (Int16)img_qlty;
            finger_info.ImpressionType = (Int16)SGFPMImpressionType.IMPTYPE_LP;
            finger_info.ViewNumber = 1;

            // CreateTemplate
            error = m_FPM.CreateTemplate(finger_info, fp_image, m_RegMin1);
			 
            if (error == (Int32)SGFPMError.ERROR_NONE)
               StatusBar.Text = "First image is captured";
            else
               StatusBar.Text = "GetMinutiae() Error : " + error;
         }
         else
            StatusBar.Text = "GetImage() Error : " + error;
      }

      /////////////////////////////////////
      private void BtnCapture2_Click(object sender, System.EventArgs e)
      {
         Byte[] fp_image = new Byte[m_ImageWidth*m_ImageHeight];
         Int32 error = (Int32)SGFPMError.ERROR_NONE;
         Int32 img_qlty = 0;

         if (m_DeviceOpened) error = m_FPM.GetImage(fp_image);
         
         m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
         progressBar_R2.Value = img_qlty;

         if (error == (Int32)SGFPMError.ERROR_NONE)
         {
            DrawImage(fp_image, pictureBoxR2);

            SGFPMFingerInfo finger_info = new SGFPMFingerInfo();
            finger_info.FingerNumber = SGFPMFingerPosition.FINGPOS_UK;
            finger_info.ImageQuality = (Int16)img_qlty;
            finger_info.ImpressionType = (Int16)SGFPMImpressionType.IMPTYPE_LP;
            finger_info.ViewNumber = 1;

            error = m_FPM.CreateTemplate(finger_info, fp_image, m_RegMin2);
			 
            if (error == (Int32)SGFPMError.ERROR_NONE)
               StatusBar.Text = "Second image is captured";
            else
               StatusBar.Text = "GetMinutiae() Error : " + error;
         }
         else
            StatusBar.Text = "GetImage() Error : " + error;
      
      }

      /////////////////////////////////////
      private void BtnCapture3_Click(object sender, System.EventArgs e)
      {
         Byte[] fp_image = new Byte[m_ImageWidth*m_ImageHeight];
         Int32 error = (Int32)SGFPMError.ERROR_NONE;
         Int32 img_qlty = 0;

         if (m_DeviceOpened) error = m_FPM.GetImage(fp_image);

         m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
         progressBar_V1.Value = img_qlty;

         if (error == (Int32)SGFPMError.ERROR_NONE)
         {
            DrawImage(fp_image, pictureBoxV1);

            SGFPMFingerInfo finger_info = new SGFPMFingerInfo();
            finger_info.FingerNumber = SGFPMFingerPosition.FINGPOS_UK; 
            finger_info.ImageQuality = (Int16)img_qlty;
            finger_info.ImpressionType = (Int16)SGFPMImpressionType.IMPTYPE_LP;
            finger_info.ViewNumber = 1;

            // Create template
            error = m_FPM.CreateTemplate(finger_info, fp_image, m_VrfMin);
			 
            if (error == (Int32)SGFPMError.ERROR_NONE)
               StatusBar.Text = "Verification image is captured";
            else
               StatusBar.Text = "GetMinutiae() Error : " + error;
         }
         else
            StatusBar.Text = "GetImage() Error : " + error;
      }

      /////////////////////////////////////
      private void BtnRegister_Click(object sender, System.EventArgs e)
      {
         if (cmbStudent.SelectedIndex < 0)
         {
            StatusBar.Text = "Please Select a student";
            return;
         }
         bool matched = false;   
         Int32 err = 0;
         err = m_FPM.MatchTemplate(m_RegMin1, m_RegMin2, m_SecurityLevel, ref matched);

         if ((err == (Int32)SGFPMError.ERROR_NONE))
         {
            if (matched)
            {
               // Save template after merging two template - m_FetBuf1, m_FetBuf2
               Byte[]  merged_template; 
               Int32  buf_size = 0;

               if (m_useAnsiTemplate)
               {
                   m_FPM.GetTemplateSizeAfterMerge(m_RegMin1, m_RegMin2, ref buf_size);
                   merged_template = new Byte[buf_size];
                   m_FPM.MergeAnsiTemplate(m_RegMin1, m_RegMin2, merged_template);
               }
               else
               {
                   m_FPM.GetIsoTemplateSizeAfterMerge(m_RegMin1, m_RegMin2, ref buf_size);
                   merged_template = new Byte[buf_size];
                   m_FPM.MergeIsoTemplate(m_RegMin1, m_RegMin2, merged_template);
               }

               if (m_StoredTemplate == null)
               {
                  m_StoredTemplate = new Byte[buf_size];
                  merged_template.CopyTo(m_StoredTemplate, 0);
               }
               else        
               {
                  Int32 new_size = 0;

                  if (m_useAnsiTemplate)
                  {
                      err = m_FPM.GetTemplateSizeAfterMerge(m_StoredTemplate, merged_template, ref new_size);
                  }
                  else
                  {
                      err = m_FPM.GetIsoTemplateSizeAfterMerge(m_StoredTemplate, merged_template, ref new_size);
                  }

                  Byte[]  new_enroll_template = new Byte[new_size];

                  if (m_useAnsiTemplate)
                  {
                      err = m_FPM.MergeAnsiTemplate(merged_template, m_StoredTemplate, new_enroll_template);
                  }
                  else
                  {
                      err = m_FPM.MergeIsoTemplate(merged_template, m_StoredTemplate, new_enroll_template);
                  }

                  m_StoredTemplate = new Byte[new_size];

                  new_enroll_template.CopyTo(m_StoredTemplate, 0);
               }

               // Let's display ANSI/ISO template Info
              // for (int i = 0; i < m_RadioButton.Length; i++)
              //    m_RadioButton[i].Checked = false;

              // if (m_useAnsiTemplate)
              // {
              //    SGFPMANSITemplateInfo sample_info = new SGFPMANSITemplateInfo();
              //    err = m_FPM.GetAnsiTemplateInfo(m_StoredTemplate, sample_info);
              //    for (int i = 0; i < sample_info.TotalSamples; i++)
              //        m_RadioButton[(Int32)sample_info.SampleInfo[i].FingerNumber].Checked = true;
              //}
              // else
              // {
              //     SGFPMISOTemplateInfo sample_info = new SGFPMISOTemplateInfo();
              //     err = m_FPM.GetIsoTemplateInfo(m_StoredTemplate, sample_info);
              //     for (int i = 0; i < sample_info.TotalSamples; i++)
              //         m_RadioButton[(Int32)sample_info.SampleInfo[i].FingerNumber].Checked = true;
              // }
               Student aStudent = new Student();
                    aStudent.Finger = m_StoredTemplate;
                    aStudent.Id = Convert.ToInt32(cmbStudent.SelectedValue.ToString());
                    String message = aStudentManager.SaveFingerInfo(aStudent);
                    MessageBox.Show(message);
                    StatusBar.Text = "Template registration success";
                    m_StoredTemplate = null;
                    pictureBoxR1.Image = null;
                    pictureBoxR2.Image = null;
                    progressBar_R1.Value = 0;
                    progressBar_R2.Value = 0;
            } 
            else
               StatusBar.Text = "Template registration failed";
         }
         else
            StatusBar.Text = "MatchTemplate() Error: " + err;
      }

      /////////////////////////////////////
      private void BtnVerify_Clickbak(object sender, System.EventArgs e)
      {
         if (m_StoredTemplate == null)
         {
            StatusBar.Text = "No data to verify";
            return;
         }
         
         string[] fingerpos_str = new string []
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
         bool finger_found = false;

         if (m_useAnsiTemplate)
         {
             SGFPMANSITemplateInfo sample_info = new SGFPMANSITemplateInfo();
             err = m_FPM.GetAnsiTemplateInfo(m_StoredTemplate, sample_info);

             for (int i = 0; i < sample_info.TotalSamples; i++)
             {
                 bool matched = false;
                 err = m_FPM.MatchAnsiTemplate(m_StoredTemplate, i, m_VrfMin, 0, m_SecurityLevel, ref matched);
                 if (matched)
                 {
                     finger_found = true;
                     finger_pos = (SGFPMFingerPosition)sample_info.SampleInfo[i].FingerNumber;
                     break;
                 }
             }
         }
         else
         {
             SGFPMISOTemplateInfo sample_info = new SGFPMISOTemplateInfo();
             err = m_FPM.GetIsoTemplateInfo(m_StoredTemplate, sample_info);

             for (int i = 0; i < sample_info.TotalSamples; i++)
             {
                 bool matched = false;
                 err = m_FPM.MatchIsoTemplate(m_StoredTemplate, i, m_VrfMin, 0, m_SecurityLevel, ref matched);
                 if (matched)
                 {
                     finger_found = true;
                     finger_pos = (SGFPMFingerPosition)sample_info.SampleInfo[i].FingerNumber;
                     break;
                 }
             }
         }

         if (err == (Int32)SGFPMError.ERROR_NONE)
         {
             if (finger_found)
                 StatusBar.Text = "The matched data found. Finger position: " + fingerpos_str[(Int32)finger_pos];
             else
                 StatusBar.Text = "Cannot find a matched data";
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

      /////////////////////////////////////
      private void EnableButtons(bool enable)
      {
         BtnCapture1.Enabled = enable;
         BtnCapture2.Enabled = enable;          
         BtnCapture3.Enabled = enable;          
         BtnRegister.Enabled = enable;          
         BtnVerify.Enabled = enable;
      }

      
      /////////////////////////////////////
      private void DrawImage(Byte[] imgData, PictureBox picBox)
      {
         int colorval;
         Bitmap bmp = new Bitmap(m_ImageWidth, m_ImageHeight);
         picBox.Image = (Image)bmp;

         for (int i=0; i< bmp.Width; i++)
         {
            for (int j=0; j< bmp.Height; j++)
            {
               colorval = (int)imgData[(j*m_ImageWidth)+ i];
               bmp.SetPixel(i,j,Color.FromArgb(colorval,colorval, colorval));
            }
         }
         picBox.Refresh();
      }

      /////////////////////////////////////
      private Int32 GetImageFromFile(Byte[] data)
      {
         OpenFileDialog open_dlg;
         open_dlg = new OpenFileDialog();

         open_dlg.Title = "Image raw file dialog" ; 
         open_dlg.Filter = "Image raw files (*.raw)|*.raw" ; 
        
         if (open_dlg.ShowDialog() == DialogResult.OK)
         {
            FileStream inStream = File.OpenRead(open_dlg.FileName);

            BinaryReader br = new BinaryReader(inStream);

            Byte[] local_data = new Byte[data.Length];
            local_data = br.ReadBytes(data.Length);
            Array.Copy(local_data, data, data.Length);
            
            br.Close();
            return (Int32)SGFPMError.ERROR_NONE;
         }
         return (Int32)SGFPMError.ERROR_FUNCTION_FAILED;
      }

       private void BtnVerify_Click(object sender, EventArgs e)
       {
            String message = "Finger Not Found";
            Student aStudent = new Student();
            if (cmbStudent.SelectedIndex < 0)
            {
                StatusBar.Text = "Please Select a student";
                return;
            }

            aStudent.Id = Convert.ToInt32(cmbStudent.SelectedValue.ToString());

            m_StoredTemplate = aStudentManager.GetFingerDataById(aStudent);


            //String message = "Finger Not Found";
            //Student aStudent = new Student();
            //DataTable finger = aStudentManager.GetAllFingerData(aStudent);
            //foreach (DataRow dr in finger.Rows)
            //{
            //    foreach (DataColumn dc in finger.Columns)
            //    {
            //        m_StoredTemplate = (Byte[])dr[dc];
            //        if (m_StoredTemplate == null)
            //        {
            //            StatusBar.Text = "No data to verify";
            //            return;
            //        }

            //        string[] fingerpos_str = new string[]
            //                          {
            //                  "Unknown finger",
            //                  "Right thumb",
            //                  "Right index finger",
            //                  "Right middle finger",
            //                  "Right ring finger",
            //                  "Right little finger",
            //                  "Left thumb",
            //                  "Left index finger",
            //                  "Left middle finger",
            //                  "Left ring finger",
            //                  "Left little finger"};

            //        Int32 err;
            //        SGFPMFingerPosition finger_pos = SGFPMFingerPosition.FINGPOS_UK;
            //        bool finger_found = false;

            //        if (m_useAnsiTemplate)
            //        {

            //            SGFPMANSITemplateInfo sample_info = new SGFPMANSITemplateInfo();
            //            err = m_FPM.GetAnsiTemplateInfo(m_StoredTemplate, sample_info);

            //            for (int i = 0; i < sample_info.TotalSamples; i++)
            //            {
            //                bool matched = false;
            //                err = m_FPM.MatchAnsiTemplate(m_StoredTemplate, i, m_VrfMin, 0, m_SecurityLevel, ref matched);
            //                if (matched)
            //                {
            //                    finger_found = true;
            //                    finger_pos = (SGFPMFingerPosition)sample_info.SampleInfo[i].FingerNumber;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            SGFPMISOTemplateInfo sample_info = new SGFPMISOTemplateInfo();
            //            err = m_FPM.GetIsoTemplateInfo(m_StoredTemplate, sample_info);

            //            for (int i = 0; i < sample_info.TotalSamples; i++)
            //            {
            //                bool matched = false;
            //                err = m_FPM.MatchIsoTemplate(m_StoredTemplate, i, m_VrfMin, 0, m_SecurityLevel, ref matched);
            //                if (matched)
            //                {
            //                    finger_found = true;
            //                    finger_pos = (SGFPMFingerPosition)sample_info.SampleInfo[i].FingerNumber;
            //                    break;
            //                }
            //            }
            //        }

            //        if (err == (Int32)SGFPMError.ERROR_NONE)
            //        {
            //            if (finger_found)
            //            {
            //                StatusBar.Text = "The matched data found. Finger position: " + fingerpos_str[(Int32)finger_pos];
            //                message = "Finger Found";
            //                MessageBox.Show(message);
            //            }
            //            else
            //                StatusBar.Text = "Cannot find a matched data";
            //        }
            //        else
            //        {
            //            if (m_useAnsiTemplate)
            //            {
            //                StatusBar.Text = "MatchAnsiTemplate() Error : " + err;
            //            }
            //            else
            //            {
            //                StatusBar.Text = "MatchIsoTemplate() Error : " + err;
            //            }
            //        }
            //    }

            //}

            if (m_StoredTemplate == null)
            {
                StatusBar.Text = "No data to verify";
                return;
            }

            Int32 err;
            SGFPMFingerPosition finger_pos = SGFPMFingerPosition.FINGPOS_UK;
            bool finger_found = false;

            if (m_useAnsiTemplate)
            {
                SGFPMANSITemplateInfo sample_info = new SGFPMANSITemplateInfo();
                err = m_FPM.GetAnsiTemplateInfo(m_StoredTemplate, sample_info);

                for (int i = 0; i < sample_info.TotalSamples; i++)
                {
                    bool matched = false;
                    err = m_FPM.MatchAnsiTemplate(m_StoredTemplate, i, m_VrfMin, 0, m_SecurityLevel, ref matched);
                    if (matched)
                    {
                        finger_found = true;
                        finger_pos = (SGFPMFingerPosition)sample_info.SampleInfo[i].FingerNumber;
                        break;
                    }
                }
            }
            else
            {
                SGFPMISOTemplateInfo sample_info = new SGFPMISOTemplateInfo();
                err = m_FPM.GetIsoTemplateInfo(m_StoredTemplate, sample_info);

                for (int i = 0; i < sample_info.TotalSamples; i++)
                {
                    bool matched = false;
                    err = m_FPM.MatchIsoTemplate(m_StoredTemplate, i, m_VrfMin, 0, m_SecurityLevel, ref matched);
                    if (matched)
                    {
                        finger_found = true;
                        finger_pos = (SGFPMFingerPosition)sample_info.SampleInfo[i].FingerNumber;
                        break;
                    }
                }
            }

            if (err == (Int32)SGFPMError.ERROR_NONE)
            {
                if (finger_found)
                {
                    message = "Finger Found";
                    MessageBox.Show(message);
                }
                else
                    StatusBar.Text = "Cannot find a matched data";
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
}
