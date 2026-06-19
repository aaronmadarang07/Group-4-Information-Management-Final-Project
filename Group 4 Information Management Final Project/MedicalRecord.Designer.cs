namespace Group_4_Information_Management_Final_Project
{
    partial class MedicalRecord
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
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.MedRecNotes_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MedRecDiagnosis_TextBox = new System.Windows.Forms.TextBox();
            this.MedRecVisitDate_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MedRec_DeleteBtn = new System.Windows.Forms.Button();
            this.MedRec_UpdateBtn = new System.Windows.Forms.Button();
            this.MedRec_ClearBtn = new System.Windows.Forms.Button();
            this.MedRec_AddBtn = new System.Windows.Forms.Button();
            this.MedRecRecordID_TextBox = new System.Windows.Forms.TextBox();
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
            this.MedRecSearch_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MedRec_DataGridView = new System.Windows.Forms.DataGridView();
            this.MedRec_RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedRec_AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedRec_DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedRec_VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedRec_Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedRec_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.MedRec_GobackHomeBtn = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.MedRec_ExitBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MedRecAppointmentID_ComboBox = new System.Windows.Forms.ComboBox();
            this.MedRecDoctorID_ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedRec_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.MedRecDoctorID_ComboBox);
            this.groupBox1.Controls.Add(this.MedRecAppointmentID_ComboBox);
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.MedRecNotes_TextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.MedRecDiagnosis_TextBox);
            this.groupBox1.Controls.Add(this.MedRecVisitDate_DateTimePicker);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.MedRec_DeleteBtn);
            this.groupBox1.Controls.Add(this.MedRec_UpdateBtn);
            this.groupBox1.Controls.Add(this.MedRec_ClearBtn);
            this.groupBox1.Controls.Add(this.MedRec_AddBtn);
            this.groupBox1.Controls.Add(this.MedRecRecordID_TextBox);
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
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.calendar_icon_png__0;
            this.pictureBox12.Location = new System.Drawing.Point(788, 7);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(43, 43);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 55;
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
            this.TimeLabel.TabIndex = 54;
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
            this.DateLabel.TabIndex = 53;
            this.DateLabel.Text = "Date";
            // 
            // MedRecNotes_TextBox
            // 
            this.MedRecNotes_TextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRecNotes_TextBox.Location = new System.Drawing.Point(518, 58);
            this.MedRecNotes_TextBox.Multiline = true;
            this.MedRecNotes_TextBox.Name = "MedRecNotes_TextBox";
            this.MedRecNotes_TextBox.Size = new System.Drawing.Size(238, 179);
            this.MedRecNotes_TextBox.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(454, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Notes:";
            // 
            // MedRecDiagnosis_TextBox
            // 
            this.MedRecDiagnosis_TextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRecDiagnosis_TextBox.Location = new System.Drawing.Point(194, 229);
            this.MedRecDiagnosis_TextBox.Multiline = true;
            this.MedRecDiagnosis_TextBox.Name = "MedRecDiagnosis_TextBox";
            this.MedRecDiagnosis_TextBox.Size = new System.Drawing.Size(238, 62);
            this.MedRecDiagnosis_TextBox.TabIndex = 48;
            // 
            // MedRecVisitDate_DateTimePicker
            // 
            this.MedRecVisitDate_DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRecVisitDate_DateTimePicker.Location = new System.Drawing.Point(194, 186);
            this.MedRecVisitDate_DateTimePicker.Name = "MedRecVisitDate_DateTimePicker";
            this.MedRecVisitDate_DateTimePicker.Size = new System.Drawing.Size(238, 27);
            this.MedRecVisitDate_DateTimePicker.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.ChatGPT_Image_Jun_9__2026__01_00_54_PM1;
            this.pictureBox1.Location = new System.Drawing.Point(797, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // MedRec_DeleteBtn
            // 
            this.MedRec_DeleteBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.MedRec_DeleteBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRec_DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MedRec_DeleteBtn.Location = new System.Drawing.Point(591, 258);
            this.MedRec_DeleteBtn.Name = "MedRec_DeleteBtn";
            this.MedRec_DeleteBtn.Size = new System.Drawing.Size(120, 36);
            this.MedRec_DeleteBtn.TabIndex = 37;
            this.MedRec_DeleteBtn.Text = "DELETE";
            this.MedRec_DeleteBtn.UseVisualStyleBackColor = false;
            this.MedRec_DeleteBtn.Click += new System.EventHandler(this.MedRec_DeleteBtn_Click_1);
            // 
            // MedRec_UpdateBtn
            // 
            this.MedRec_UpdateBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.MedRec_UpdateBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRec_UpdateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MedRec_UpdateBtn.Location = new System.Drawing.Point(723, 258);
            this.MedRec_UpdateBtn.Name = "MedRec_UpdateBtn";
            this.MedRec_UpdateBtn.Size = new System.Drawing.Size(120, 36);
            this.MedRec_UpdateBtn.TabIndex = 36;
            this.MedRec_UpdateBtn.Text = "UPDATE";
            this.MedRec_UpdateBtn.UseVisualStyleBackColor = false;
            this.MedRec_UpdateBtn.Click += new System.EventHandler(this.MedRec_UpdateBtn_Click_1);
            // 
            // MedRec_ClearBtn
            // 
            this.MedRec_ClearBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.MedRec_ClearBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRec_ClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MedRec_ClearBtn.Location = new System.Drawing.Point(857, 258);
            this.MedRec_ClearBtn.Name = "MedRec_ClearBtn";
            this.MedRec_ClearBtn.Size = new System.Drawing.Size(120, 36);
            this.MedRec_ClearBtn.TabIndex = 35;
            this.MedRec_ClearBtn.Text = "CLEAR";
            this.MedRec_ClearBtn.UseVisualStyleBackColor = false;
            this.MedRec_ClearBtn.Click += new System.EventHandler(this.MedRec_ClearBtn_Click_1);
            // 
            // MedRec_AddBtn
            // 
            this.MedRec_AddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.MedRec_AddBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRec_AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MedRec_AddBtn.Location = new System.Drawing.Point(458, 258);
            this.MedRec_AddBtn.Name = "MedRec_AddBtn";
            this.MedRec_AddBtn.Size = new System.Drawing.Size(120, 36);
            this.MedRec_AddBtn.TabIndex = 34;
            this.MedRec_AddBtn.Text = "ADD";
            this.MedRec_AddBtn.UseVisualStyleBackColor = false;
            this.MedRec_AddBtn.Click += new System.EventHandler(this.MedRec_AddBtn_Click_1);
            // 
            // MedRecRecordID_TextBox
            // 
            this.MedRecRecordID_TextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRecRecordID_TextBox.Location = new System.Drawing.Point(194, 58);
            this.MedRecRecordID_TextBox.Name = "MedRecRecordID_TextBox";
            this.MedRecRecordID_TextBox.Size = new System.Drawing.Size(238, 27);
            this.MedRecRecordID_TextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Visit Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Appointment ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Diagnosis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Record ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(57, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Medical Record Information";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.Copilot_20260607_180702;
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
            this.groupBox3.Controls.Add(this.MedRecSearch_TextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.MedRec_DataGridView);
            this.groupBox3.Location = new System.Drawing.Point(20, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(995, 255);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(15, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 23);
            this.label12.TabIndex = 33;
            this.label12.Text = "Medical Record List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.free_search_icon_337_thumb;
            this.pictureBox2.Location = new System.Drawing.Point(652, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // MedRecSearch_TextBox
            // 
            this.MedRecSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRecSearch_TextBox.Location = new System.Drawing.Point(814, 8);
            this.MedRecSearch_TextBox.Name = "MedRecSearch_TextBox";
            this.MedRecSearch_TextBox.Size = new System.Drawing.Size(163, 25);
            this.MedRecSearch_TextBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(681, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Search Records:";
            // 
            // MedRec_DataGridView
            // 
            this.MedRec_DataGridView.AllowUserToOrderColumns = true;
            this.MedRec_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedRec_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MedRec_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedRec_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedRec_RecordID,
            this.MedRec_AppointmentID,
            this.MedRec_DoctorName,
            this.MedRec_VisitDate,
            this.MedRec_Diagnosis,
            this.MedRec_Notes});
            this.MedRec_DataGridView.Location = new System.Drawing.Point(18, 38);
            this.MedRec_DataGridView.Name = "MedRec_DataGridView";
            this.MedRec_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MedRec_DataGridView.RowHeadersVisible = false;
            this.MedRec_DataGridView.RowHeadersWidth = 51;
            this.MedRec_DataGridView.Size = new System.Drawing.Size(959, 197);
            this.MedRec_DataGridView.TabIndex = 0;
            this.MedRec_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedRec_DataGridView_CellContentClick);
            // 
            // MedRec_RecordID
            // 
            this.MedRec_RecordID.DataPropertyName = "record_id";
            this.MedRec_RecordID.HeaderText = "Record ID";
            this.MedRec_RecordID.MinimumWidth = 6;
            this.MedRec_RecordID.Name = "MedRec_RecordID";
            // 
            // MedRec_AppointmentID
            // 
            this.MedRec_AppointmentID.DataPropertyName = "appointment_id";
            this.MedRec_AppointmentID.HeaderText = "Appointment ID";
            this.MedRec_AppointmentID.MinimumWidth = 6;
            this.MedRec_AppointmentID.Name = "MedRec_AppointmentID";
            // 
            // MedRec_DoctorName
            // 
            this.MedRec_DoctorName.DataPropertyName = "doctor_name";
            this.MedRec_DoctorName.HeaderText = "Doctor";
            this.MedRec_DoctorName.MinimumWidth = 6;
            this.MedRec_DoctorName.Name = "MedRec_DoctorName";
            // 
            // MedRec_VisitDate
            // 
            this.MedRec_VisitDate.DataPropertyName = "visit_date";
            this.MedRec_VisitDate.HeaderText = "Visit Date";
            this.MedRec_VisitDate.MinimumWidth = 6;
            this.MedRec_VisitDate.Name = "MedRec_VisitDate";
            // 
            // MedRec_Diagnosis
            // 
            this.MedRec_Diagnosis.DataPropertyName = "diagnosis";
            this.MedRec_Diagnosis.HeaderText = "Diagnosis";
            this.MedRec_Diagnosis.MinimumWidth = 6;
            this.MedRec_Diagnosis.Name = "MedRec_Diagnosis";
            // 
            // MedRec_Notes
            // 
            this.MedRec_Notes.DataPropertyName = "notes";
            this.MedRec_Notes.HeaderText = "Notes";
            this.MedRec_Notes.MinimumWidth = 6;
            this.MedRec_Notes.Name = "MedRec_Notes";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox9.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources._25694;
            this.pictureBox9.Location = new System.Drawing.Point(23, 632);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(43, 43);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 41;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.MedRec_GobackHomeBtn_Click);
            // 
            // MedRec_GobackHomeBtn
            // 
            this.MedRec_GobackHomeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MedRec_GobackHomeBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRec_GobackHomeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MedRec_GobackHomeBtn.Location = new System.Drawing.Point(20, 628);
            this.MedRec_GobackHomeBtn.Name = "MedRec_GobackHomeBtn";
            this.MedRec_GobackHomeBtn.Size = new System.Drawing.Size(177, 50);
            this.MedRec_GobackHomeBtn.TabIndex = 40;
            this.MedRec_GobackHomeBtn.Text = "         MAIN MENU";
            this.MedRec_GobackHomeBtn.UseVisualStyleBackColor = false;
            this.MedRec_GobackHomeBtn.Click += new System.EventHandler(this.MedRec_GobackHomeBtn_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Red;
            this.pictureBox10.Image = global::Group_4_Information_Management_Final_Project.Properties.Resources.login_icon_no_bg;
            this.pictureBox10.Location = new System.Drawing.Point(841, 632);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(42, 42);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 39;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // MedRec_ExitBtn
            // 
            this.MedRec_ExitBtn.BackColor = System.Drawing.Color.Red;
            this.MedRec_ExitBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRec_ExitBtn.ForeColor = System.Drawing.Color.White;
            this.MedRec_ExitBtn.Location = new System.Drawing.Point(838, 628);
            this.MedRec_ExitBtn.Name = "MedRec_ExitBtn";
            this.MedRec_ExitBtn.Size = new System.Drawing.Size(177, 50);
            this.MedRec_ExitBtn.TabIndex = 38;
            this.MedRec_ExitBtn.Text = "      EXIT";
            this.MedRec_ExitBtn.UseVisualStyleBackColor = false;
            this.MedRec_ExitBtn.Click += new System.EventHandler(this.MedRec_ExitBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MedRecAppointmentID_ComboBox
            // 
            this.MedRecAppointmentID_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedRecAppointmentID_ComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRecAppointmentID_ComboBox.FormattingEnabled = true;
            this.MedRecAppointmentID_ComboBox.Items.AddRange(new object[] {
            "A001",
            "",
            "A002",
            "",
            "A003",
            "",
            "A004",
            "",
            "A005",
            "",
            "A006",
            "",
            "A007",
            "",
            "A008",
            "",
            "A009",
            "",
            "A010",
            "",
            "A011",
            "",
            "A012",
            "",
            "A013",
            "",
            "A014",
            "",
            "A015",
            "",
            "A016",
            "",
            "A017",
            "",
            "A018",
            "",
            "A019",
            "",
            "A020",
            "",
            "A021",
            "",
            "A022",
            "",
            "A023",
            "",
            "A024",
            "",
            "A025",
            "",
            "A026",
            "",
            "A027",
            "",
            "A028",
            "",
            "A029",
            "",
            "A030",
            "",
            "A031",
            "",
            "A032",
            "",
            "A033",
            "",
            "A034",
            "",
            "A035",
            "",
            "A036",
            "",
            "A037",
            "",
            "A038",
            "",
            "A039",
            "",
            "A040",
            "",
            "A041",
            "",
            "A042",
            "",
            "A043",
            "",
            "A044",
            "",
            "A045",
            "",
            "A046",
            "",
            "A047",
            "",
            "A048",
            "",
            "A049",
            "",
            "A050"});
            this.MedRecAppointmentID_ComboBox.Location = new System.Drawing.Point(194, 100);
            this.MedRecAppointmentID_ComboBox.Name = "MedRecAppointmentID_ComboBox";
            this.MedRecAppointmentID_ComboBox.Size = new System.Drawing.Size(238, 28);
            this.MedRecAppointmentID_ComboBox.TabIndex = 56;
            // 
            // MedRecDoctorID_ComboBox
            // 
            this.MedRecDoctorID_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedRecDoctorID_ComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRecDoctorID_ComboBox.FormattingEnabled = true;
            this.MedRecDoctorID_ComboBox.Items.AddRange(new object[] {
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
            this.MedRecDoctorID_ComboBox.Location = new System.Drawing.Point(194, 142);
            this.MedRecDoctorID_ComboBox.Name = "MedRecDoctorID_ComboBox";
            this.MedRecDoctorID_ComboBox.Size = new System.Drawing.Size(238, 28);
            this.MedRecDoctorID_ComboBox.TabIndex = 57;
            // 
            // MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_4_Information_Management_Final_Project.Properties.Resources.light_blue_background_gradient_wall_design_vector4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 696);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.MedRec_GobackHomeBtn);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.MedRec_ExitBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedicalRecord";
            this.Text = "Medical Record Forms";
            this.Load += new System.EventHandler(this.MedicalRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedRec_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker MedRecVisitDate_DateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MedRec_DeleteBtn;
        private System.Windows.Forms.Button MedRec_UpdateBtn;
        private System.Windows.Forms.Button MedRec_ClearBtn;
        private System.Windows.Forms.Button MedRec_AddBtn;
        private System.Windows.Forms.TextBox MedRecRecordID_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox MedRecDiagnosis_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MedRecNotes_TextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox MedRecSearch_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView MedRec_DataGridView;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button MedRec_GobackHomeBtn;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button MedRec_ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedRec_RecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedRec_AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedRec_DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedRec_VisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedRec_Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedRec_Notes;
        private System.Windows.Forms.ComboBox MedRecDoctorID_ComboBox;
        private System.Windows.Forms.ComboBox MedRecAppointmentID_ComboBox;
    }
}