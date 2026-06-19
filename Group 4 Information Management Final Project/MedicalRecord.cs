using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group_4_Information_Management_Final_Project
{
    public partial class MedicalRecord : Form
    {
        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            timer1.Start();

            MedRec_DataGridView.AutoGenerateColumns = false;

            MedRec_RecordID.DataPropertyName = "record_id";
            MedRec_AppointmentID.DataPropertyName = "appointment_id";
            MedRec_DoctorName.DataPropertyName = "doctor_name";
            MedRec_VisitDate.DataPropertyName = "visit_date";
            MedRec_Diagnosis.DataPropertyName = "diagnosis";
            MedRec_Notes.DataPropertyName = "notes";

            LoadMedicalRecords();

            MedRec_AddBtn.Click += MedRec_AddBtn_Click;
            MedRec_UpdateBtn.Click += MedRec_UpdateBtn_Click;
            MedRec_DeleteBtn.Click += MedRec_DeleteBtn_Click;
            MedRec_ClearBtn.Click += MedRec_ClearBtn_Click;
            MedRec_DataGridView.CellClick += MedRec_DataGridView_CellClick;

            LoadAppointmentIDs();
            LoadDoctorIDs();

        }

        private void LoadMedicalRecords()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("GetMedicalRecords", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            MedRec_DataGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAppointmentIDs()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT appointment_id FROM appointments";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    MedRecAppointmentID_ComboBox.DataSource = dt;

                    MedRecAppointmentID_ComboBox.DisplayMember =
                        "appointment_id";

                    MedRecAppointmentID_ComboBox.ValueMember =
                        "appointment_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDoctorIDs()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT doctor_id FROM doctors";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    MedRecDoctorID_ComboBox.DataSource = dt;

                    MedRecDoctorID_ComboBox.DisplayMember =
                        "doctor_id";

                    MedRecDoctorID_ComboBox.ValueMember =
                        "doctor_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MedRec_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MedRecRecordID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(MedRecAppointmentID_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(MedRecDoctorID_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(MedRecDiagnosis_TextBox.Text) ||
                string.IsNullOrWhiteSpace(MedRecNotes_TextBox.Text))
            {
                MessageBox.Show("Please fill up all fields!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("AddMedicalRecord", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_record_id", MedRecRecordID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_appointment_id", MedRecAppointmentID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_doctor_id", MedRecDoctorID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_visit_date", MedRecVisitDate_DateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("p_diagnosis", MedRecDiagnosis_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_notes", MedRecNotes_TextBox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Medical Record Added Successfully!");
                    LoadMedicalRecords();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MedRec_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MedRecRecordID_TextBox.Text))
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("UpdateMedicalRecord", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_record_id", MedRecRecordID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_appointment_id", MedRecAppointmentID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_doctor_id", MedRecDoctorID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_visit_date", MedRecVisitDate_DateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("p_diagnosis", MedRecDiagnosis_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_notes", MedRecNotes_TextBox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Medical Record Updated Successfully!");
                LoadMedicalRecords();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MedRec_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MedRecRecordID_TextBox.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DBHelper.GetConnection())
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand("DeleteMedicalRecord", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("p_record_id", MedRecRecordID_TextBox.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Medical Record Deleted Successfully!");
                    LoadMedicalRecords();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MedRec_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            MedRecRecordID_TextBox.Clear();
            MedRecAppointmentID_ComboBox.SelectedIndex = -1;
            MedRecDoctorID_ComboBox.SelectedIndex = -1;
            MedRecDiagnosis_TextBox.Clear();
            MedRecNotes_TextBox.Clear();
            MedRecVisitDate_DateTimePicker.Value = DateTime.Now;
            MedRecRecordID_TextBox.Focus();
        }

        private void MedRecRecordID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currentText = MedRecRecordID_TextBox.Text;

            if (e.KeyChar == (char)Keys.Back)
                return;

            if (currentText.Length == 0)
            {
                if (char.ToUpper(e.KeyChar) == 'R')
                {
                    e.Handled = true;
                    MedRecRecordID_TextBox.Text = "R";
                    MedRecRecordID_TextBox.SelectionStart = MedRecRecordID_TextBox.Text.Length;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Invalid input. Medical Record ID must start with letter R.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (currentText.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void MedRec_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MedRec_DataGridView.Rows[e.RowIndex];

                MedRecRecordID_TextBox.Text = row.Cells["MedRec_RecordID"].Value?.ToString();
                MedRecAppointmentID_ComboBox.Text = row.Cells["MedRec_AppointmentID"].Value?.ToString();
                MedRecDoctorID_ComboBox.Text = row.Cells["MedRec_DoctorName"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["MedRec_VisitDate"].Value?.ToString(), out DateTime visitDate))
                {
                    MedRecVisitDate_DateTimePicker.Value = visitDate;
                }

                MedRecDiagnosis_TextBox.Text = row.Cells["MedRec_Diagnosis"].Value?.ToString();
                MedRecNotes_TextBox.Text = row.Cells["MedRec_Notes"].Value?.ToString();
            }
        }

        private void MedRecSearch_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SearchMedicalRecords", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_search", MedRecSearch_TextBox.Text);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            MedRec_DataGridView.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); 
            }
        }

        private void MedRec_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MedRec_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home MedRec_homeForm = new Home();
            MedRec_homeForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void pictureBox9_Click(object sender, EventArgs e) { }
        private void pictureBox10_Click(object sender, EventArgs e) { }
        private void MedRec_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void MedRec_AddBtn_Click_1(object sender, EventArgs e) { }
        private void MedRec_DeleteBtn_Click_1(object sender, EventArgs e) { }
        private void MedRec_UpdateBtn_Click_1(object sender, EventArgs e) { }
        private void MedRec_ClearBtn_Click_1(object sender, EventArgs e) { }
    }
}