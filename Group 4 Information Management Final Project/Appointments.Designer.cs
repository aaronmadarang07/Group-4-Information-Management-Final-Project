namespace Group_4_Information_Management_Final_Project
{
    partial class Appointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppDoctorID_ComboBox = new System.Windows.Forms.ComboBox();
            this.AppPatientID_ComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AppStatus_ComboBox = new System.Windows.Forms.ComboBox();
            this.AppRemarks_TextBox = new System.Windows.Forms.TextBox();
            this.AppAppointmentTime_ComboBox = new System.Windows.Forms.ComboBox();
            this.AppDate_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Appointment_DeleteBtn = new System.Windows.Forms.Button();
            this.Appointment_UpdateBtn = new System.Windows.Forms.Button();
            this.Appointment_ClearBtn = new System.Windows.Forms.Button();
            this.Appointment_AddBtn = new System.Windows.Forms.Button();
            this.AppID_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AppointmentSearch_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AppointmentList_DataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Appointments_GobackHomeBtn = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Appointments_ExitBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.App_AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentList_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.AppDoctorID_ComboBox);
            this.groupBox1.Controls.Add(this.AppPatientID_ComboBox);
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.AppStatus_ComboBox);
            this.groupBox1.Controls.Add(this.AppRemarks_TextBox);
            this.groupBox1.Controls.Add(this.AppAppointmentTime_ComboBox);
            this.groupBox1.Controls.Add(this.AppDate_DateTimePicker);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Appointment_DeleteBtn);
            this.groupBox1.Controls.Add(this.Appointment_UpdateBtn);
            this.groupBox1.Controls.Add(this.Appointment_ClearBtn);
            this.groupBox1.Controls.Add(this.Appointment_AddBtn);
            this.groupBox1.Controls.Add(this.AppID_TextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AppDoctorID_ComboBox
            // 
            this.AppDoctorID_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppDoctorID_ComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDoctorID_ComboBox.FormattingEnabled = true;
            this.AppDoctorID_ComboBox.Items.AddRange(new object[] {
            "D001",
            "D002",
            "D003",
            "D004",
            "D005",
            "D006",
            "D007",
            "D008",
            "D009",
            "D010",
            "D011",
            "D012",
            "D013",
            "D014",
            "D015",
            "D016",
            "D017",
            "D018",
            "D019",
            "D020",
            "D021",
            "D022",
            "D023",
            "D024",
            "D025",
            "D026",
            "D027",
            "D028",
            "D029",
            "D030",
            "D031",
            "D032",
            "D033",
            "D034",
            "D035",
            "D036",
            "D037",
            "D038",
            "D039",
            "D040",
            "D041",
            "D042",
            "D043",
            "D044",
            "D045",
            "D046",
            "D047",
            "D048",
            "D049",
            "D050"});
            this.AppDoctorID_ComboBox.Location = new System.Drawing.Point(194, 145);
            this.AppDoctorID_ComboBox.Name = "AppDoctorID_ComboBox";
            this.AppDoctorID_ComboBox.Size = new System.Drawing.Size(238, 28);
            this.AppDoctorID_ComboBox.TabIndex = 60;
            this.AppDoctorID_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AppDoctorID_ComboBox_SelectedIndexChanged);
            // 
            // AppPatientID_ComboBox
            // 
            this.AppPatientID_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppPatientID_ComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppPatientID_ComboBox.FormattingEnabled = true;
            this.AppPatientID_ComboBox.Items.AddRange(new object[] {
            "P001",
            "P002",
            "P003",
            "P004",
            "P005",
            "P006",
            "P007",
            "P008",
            "P009",
            "P010",
            "P011",
            "P012",
            "P013",
            "P014",
            "P015",
            "P016",
            "P017",
            "P018",
            "P019",
            "P020",
            "P021",
            "P022",
            "P023",
            "P024",
            "P025",
            "P026",
            "P027",
            "P028",
            "P029",
            "P030",
            "P031",
            "P032",
            "P033",
            "P034",
            "P035",
            "P036",
            "P037",
            "P038",
            "P039",
            "P040",
            "P041",
            "P042",
            "P043",
            "P044",
            "P045",
            "P046",
            "P047",
            "P048",
            "P049",
            "P050"});
            this.AppPatientID_ComboBox.Location = new System.Drawing.Point(194, 102);
            this.AppPatientID_ComboBox.Name = "AppPatientID_ComboBox";
            this.AppPatientID_ComboBox.Size = new System.Drawing.Size(238, 28);
            this.AppPatientID_ComboBox.TabIndex = 59;
            this.AppPatientID_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.calendar_icon_png__0;
            this.pictureBox12.Location = new System.Drawing.Point(788, 7);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(43, 43);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 58;
            this.pictureBox12.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimeLabel.Location = new System.Drawing.Point(831, 31);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 17);
            this.TimeLabel.TabIndex = 57;
            this.TimeLabel.Text = "Time";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DateLabel.Location = new System.Drawing.Point(831, 8);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 17);
            this.DateLabel.TabIndex = 56;
            this.DateLabel.Text = "Date";
            // 
            // AppStatus_ComboBox
            // 
            this.AppStatus_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppStatus_ComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppStatus_ComboBox.FormattingEnabled = true;
            this.AppStatus_ComboBox.Items.AddRange(new object[] {
            "Scheduled",
            "Finished",
            "Cancelled",
            "Ongoing",
            "Postponed"});
            this.AppStatus_ComboBox.Location = new System.Drawing.Point(194, 270);
            this.AppStatus_ComboBox.Name = "AppStatus_ComboBox";
            this.AppStatus_ComboBox.Size = new System.Drawing.Size(238, 28);
            this.AppStatus_ComboBox.TabIndex = 47;
            // 
            // AppRemarks_TextBox
            // 
            this.AppRemarks_TextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppRemarks_TextBox.Location = new System.Drawing.Point(536, 57);
            this.AppRemarks_TextBox.Multiline = true;
            this.AppRemarks_TextBox.Name = "AppRemarks_TextBox";
            this.AppRemarks_TextBox.Size = new System.Drawing.Size(238, 180);
            this.AppRemarks_TextBox.TabIndex = 45;
            // 
            // AppAppointmentTime_ComboBox
            // 
            this.AppAppointmentTime_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppAppointmentTime_ComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppAppointmentTime_ComboBox.FormattingEnabled = true;
            this.AppAppointmentTime_ComboBox.Items.AddRange(new object[] {
            "6:00 AM",
            "7:00 AM",
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 AM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM"});
            this.AppAppointmentTime_ComboBox.Location = new System.Drawing.Point(194, 227);
            this.AppAppointmentTime_ComboBox.Name = "AppAppointmentTime_ComboBox";
            this.AppAppointmentTime_ComboBox.Size = new System.Drawing.Size(238, 28);
            this.AppAppointmentTime_ComboBox.TabIndex = 44;
            this.AppAppointmentTime_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AppAppointmentTime_ComboBox_SelectedIndexChanged);
            // 
            // AppDate_DateTimePicker
            // 
            this.AppDate_DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDate_DateTimePicker.Location = new System.Drawing.Point(194, 186);
            this.AppDate_DateTimePicker.Name = "AppDate_DateTimePicker";
            this.AppDate_DateTimePicker.Size = new System.Drawing.Size(238, 27);
            this.AppDate_DateTimePicker.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.ChatGPT_Image_Jun_9__2026__01_00_54_PM2;
            this.pictureBox1.Location = new System.Drawing.Point(797, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(454, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Remarks:";
            // 
            // Appointment_DeleteBtn
            // 
            this.Appointment_DeleteBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Appointment_DeleteBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Appointment_DeleteBtn.Location = new System.Drawing.Point(591, 258);
            this.Appointment_DeleteBtn.Name = "Appointment_DeleteBtn";
            this.Appointment_DeleteBtn.Size = new System.Drawing.Size(120, 36);
            this.Appointment_DeleteBtn.TabIndex = 37;
            this.Appointment_DeleteBtn.Text = "DELETE";
            this.Appointment_DeleteBtn.UseVisualStyleBackColor = false;
            this.Appointment_DeleteBtn.Click += new System.EventHandler(this.Appointment_DeleteBtn_Click);
            // 
            // Appointment_UpdateBtn
            // 
            this.Appointment_UpdateBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.Appointment_UpdateBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_UpdateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Appointment_UpdateBtn.Location = new System.Drawing.Point(723, 258);
            this.Appointment_UpdateBtn.Name = "Appointment_UpdateBtn";
            this.Appointment_UpdateBtn.Size = new System.Drawing.Size(120, 36);
            this.Appointment_UpdateBtn.TabIndex = 36;
            this.Appointment_UpdateBtn.Text = "UPDATE";
            this.Appointment_UpdateBtn.UseVisualStyleBackColor = false;
            this.Appointment_UpdateBtn.Click += new System.EventHandler(this.Appointment_UpdateBtn_Click);
            // 
            // Appointment_ClearBtn
            // 
            this.Appointment_ClearBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.Appointment_ClearBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_ClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Appointment_ClearBtn.Location = new System.Drawing.Point(857, 258);
            this.Appointment_ClearBtn.Name = "Appointment_ClearBtn";
            this.Appointment_ClearBtn.Size = new System.Drawing.Size(120, 36);
            this.Appointment_ClearBtn.TabIndex = 35;
            this.Appointment_ClearBtn.Text = "CLEAR";
            this.Appointment_ClearBtn.UseVisualStyleBackColor = false;
            this.Appointment_ClearBtn.Click += new System.EventHandler(this.Appointment_ClearBtn_Click);
            // 
            // Appointment_AddBtn
            // 
            this.Appointment_AddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Appointment_AddBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Appointment_AddBtn.Location = new System.Drawing.Point(458, 258);
            this.Appointment_AddBtn.Name = "Appointment_AddBtn";
            this.Appointment_AddBtn.Size = new System.Drawing.Size(120, 36);
            this.Appointment_AddBtn.TabIndex = 34;
            this.Appointment_AddBtn.Text = "ADD";
            this.Appointment_AddBtn.UseVisualStyleBackColor = false;
            this.Appointment_AddBtn.Click += new System.EventHandler(this.Appointment_AddBtn_Click);
            // 
            // AppID_TextBox
            // 
            this.AppID_TextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppID_TextBox.Location = new System.Drawing.Point(194, 58);
            this.AppID_TextBox.Name = "AppID_TextBox";
            this.AppID_TextBox.Size = new System.Drawing.Size(238, 27);
            this.AppID_TextBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(15, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Appointment Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Patient ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Doctor ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Appointment Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Appointment ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(57, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Appointment Management";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.Copilot_20260607_181622;
            this.pictureBox5.Location = new System.Drawing.Point(11, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.AppointmentSearch_TextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.AppointmentList_DataGridView);
            this.groupBox3.Location = new System.Drawing.Point(20, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(995, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(15, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 23);
            this.label12.TabIndex = 33;
            this.label12.Text = "Appointmets List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.free_search_icon_337_thumb;
            this.pictureBox2.Location = new System.Drawing.Point(600, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // AppointmentSearch_TextBox
            // 
            this.AppointmentSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentSearch_TextBox.Location = new System.Drawing.Point(814, 8);
            this.AppointmentSearch_TextBox.Name = "AppointmentSearch_TextBox";
            this.AppointmentSearch_TextBox.Size = new System.Drawing.Size(163, 25);
            this.AppointmentSearch_TextBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(629, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Search Appointments:";
            // 
            // AppointmentList_DataGridView
            // 
            this.AppointmentList_DataGridView.AllowUserToOrderColumns = true;
            this.AppointmentList_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentList_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AppointmentList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentList_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.App_AppointmentID,
            this.App_PatientName,
            this.App_DoctorName,
            this.App_AppointmentDate,
            this.App_AppointmentTime,
            this.App_Status,
            this.App_Remarks});
            this.AppointmentList_DataGridView.Location = new System.Drawing.Point(18, 38);
            this.AppointmentList_DataGridView.Name = "AppointmentList_DataGridView";
            this.AppointmentList_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AppointmentList_DataGridView.RowHeadersVisible = false;
            this.AppointmentList_DataGridView.RowHeadersWidth = 51;
            this.AppointmentList_DataGridView.Size = new System.Drawing.Size(959, 197);
            this.AppointmentList_DataGridView.TabIndex = 0;
            this.AppointmentList_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentList_DataGridView_CellContentClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox9.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources._25694;
            this.pictureBox9.Location = new System.Drawing.Point(23, 632);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(43, 43);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 37;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.Appointments_GobackHomeBtn_Click);
            // 
            // Appointments_GobackHomeBtn
            // 
            this.Appointments_GobackHomeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Appointments_GobackHomeBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointments_GobackHomeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Appointments_GobackHomeBtn.Location = new System.Drawing.Point(20, 628);
            this.Appointments_GobackHomeBtn.Name = "Appointments_GobackHomeBtn";
            this.Appointments_GobackHomeBtn.Size = new System.Drawing.Size(177, 50);
            this.Appointments_GobackHomeBtn.TabIndex = 36;
            this.Appointments_GobackHomeBtn.Text = "         MAIN MENU";
            this.Appointments_GobackHomeBtn.UseVisualStyleBackColor = false;
            this.Appointments_GobackHomeBtn.Click += new System.EventHandler(this.Appointments_GobackHomeBtn_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Red;
            this.pictureBox10.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.login_icon_no_bg;
            this.pictureBox10.Location = new System.Drawing.Point(841, 632);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(42, 42);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // Appointments_ExitBtn
            // 
            this.Appointments_ExitBtn.BackColor = System.Drawing.Color.Red;
            this.Appointments_ExitBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointments_ExitBtn.ForeColor = System.Drawing.Color.White;
            this.Appointments_ExitBtn.Location = new System.Drawing.Point(838, 628);
            this.Appointments_ExitBtn.Name = "Appointments_ExitBtn";
            this.Appointments_ExitBtn.Size = new System.Drawing.Size(177, 50);
            this.Appointments_ExitBtn.TabIndex = 34;
            this.Appointments_ExitBtn.Text = "      EXIT";
            this.Appointments_ExitBtn.UseVisualStyleBackColor = false;
            this.Appointments_ExitBtn.Click += new System.EventHandler(this.Appointments_ExitBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // App_AppointmentID
            // 
            this.App_AppointmentID.DataPropertyName = "appointment_id";
            this.App_AppointmentID.HeaderText = "Appointment ID";
            this.App_AppointmentID.MinimumWidth = 6;
            this.App_AppointmentID.Name = "App_AppointmentID";
            // 
            // App_PatientName
            // 
            this.App_PatientName.DataPropertyName = "patient_name";
            this.App_PatientName.HeaderText = "Patient Name";
            this.App_PatientName.MinimumWidth = 6;
            this.App_PatientName.Name = "App_PatientName";
            // 
            // App_DoctorName
            // 
            this.App_DoctorName.DataPropertyName = "doctor_name";
            this.App_DoctorName.HeaderText = "Doctor Name";
            this.App_DoctorName.MinimumWidth = 6;
            this.App_DoctorName.Name = "App_DoctorName";
            // 
            // App_AppointmentDate
            // 
            this.App_AppointmentDate.DataPropertyName = "appointment_date";
            this.App_AppointmentDate.HeaderText = "Appointment Date";
            this.App_AppointmentDate.MinimumWidth = 6;
            this.App_AppointmentDate.Name = "App_AppointmentDate";
            // 
            // App_AppointmentTime
            // 
            this.App_AppointmentTime.DataPropertyName = "appointment_time";
            this.App_AppointmentTime.HeaderText = "Appointment Time";
            this.App_AppointmentTime.MinimumWidth = 6;
            this.App_AppointmentTime.Name = "App_AppointmentTime";
            // 
            // App_Status
            // 
            this.App_Status.DataPropertyName = "status";
            this.App_Status.HeaderText = "Status";
            this.App_Status.MinimumWidth = 6;
            this.App_Status.Name = "App_Status";
            // 
            // App_Remarks
            // 
            this.App_Remarks.DataPropertyName = "remarks";
            this.App_Remarks.HeaderText = "Remarks";
            this.App_Remarks.MinimumWidth = 6;
            this.App_Remarks.Name = "App_Remarks";
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_4_Information_Management_Final_Project.Properties.Resources.light_blue_background_gradient_wall_design_vector5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 696);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Appointments_GobackHomeBtn);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.Appointments_ExitBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Appointments";
            this.Text = "Appointments Form";
            this.Load += new System.EventHandler(this.Appointments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentList_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Appointment_DeleteBtn;
        private System.Windows.Forms.Button Appointment_UpdateBtn;
        private System.Windows.Forms.Button Appointment_ClearBtn;
        private System.Windows.Forms.Button Appointment_AddBtn;
        private System.Windows.Forms.TextBox AppID_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DateTimePicker AppDate_DateTimePicker;
        private System.Windows.Forms.ComboBox AppAppointmentTime_ComboBox;
        private System.Windows.Forms.ComboBox AppStatus_ComboBox;
        private System.Windows.Forms.TextBox AppRemarks_TextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox AppointmentSearch_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView AppointmentList_DataGridView;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button Appointments_GobackHomeBtn;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button Appointments_ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox AppPatientID_ComboBox;
        private System.Windows.Forms.ComboBox AppDoctorID_ComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_Remarks;
    }
}