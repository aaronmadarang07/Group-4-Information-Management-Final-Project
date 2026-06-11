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
            MedRec_Appointment.DataPropertyName = "appointment";
            MedRec_Doctor.DataPropertyName = "doctor";
            MedRec_VisitDate.DataPropertyName = "visit_date";
            MedRec_Diagnosis.DataPropertyName = "diagnosis";
            MedRec_Notes.DataPropertyName = "notes";

            LoadMedicalRecords();

            MedRec_AddBtn.Click += MedRec_AddBtn_Click;
            MedRec_UpdateBtn.Click += MedRec_UpdateBtn_Click;
            MedRec_DeleteBtn.Click += MedRec_DeleteBtn_Click;
            MedRec_ClearBtn.Click += MedRec_ClearBtn_Click;
            MedRec_DataGridView.CellClick += MedRec_DataGridView_CellClick;
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

        private void MedRec_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MedRecRecordID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(MedRecAppointment_TextBox.Text) ||
                string.IsNullOrWhiteSpace(MedRecDoctor_TextBox.Text) ||
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
                        cmd.Parameters.AddWithValue("p_appointment", MedRecAppointment_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_doctor", MedRecDoctor_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_visit_date", MedRecVisitDate_DateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("p_diagnosis", MedRecDiagnosis_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_notes", MedRecNotes_TextBox.Text);

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
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE medical_records SET
                    appointment = @appointment,
                    doctor = @doctor,
                    visit_date = @date,
                    diagnosis = @diagnosis,
                    notes = @notes
                    WHERE record_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", MedRecRecordID_TextBox.Text);
                    cmd.Parameters.AddWithValue("@appointment", MedRecAppointment_TextBox.Text);
                    cmd.Parameters.AddWithValue("@doctor", MedRecDoctor_TextBox.Text);
                    cmd.Parameters.AddWithValue("@date", MedRecVisitDate_DateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@diagnosis", MedRecDiagnosis_TextBox.Text);
                    cmd.Parameters.AddWithValue("@notes", MedRecNotes_TextBox.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medical Record Updated Successfully!");

                    LoadMedicalRecords();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MedRec_DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM medical_records WHERE record_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", MedRecRecordID_TextBox.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medical Record Deleted Successfully!");

                    LoadMedicalRecords();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MedRec_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            MedRecRecordID_TextBox.Clear();
            MedRecAppointment_TextBox.Clear();
            MedRecDoctor_TextBox.Clear();
            MedRecDiagnosis_TextBox.Clear();
            MedRecNotes_TextBox.Clear();
            MedRecVisitDate_DateTimePicker.Value = DateTime.Now;
        }

        private void MedRec_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MedRec_DataGridView.Rows[e.RowIndex];

                MedRecRecordID_TextBox.Text = row.Cells["MedRec_RecordID"].Value?.ToString();
                MedRecAppointment_TextBox.Text = row.Cells["MedRec_Appointment"].Value?.ToString();
                MedRecDoctor_TextBox.Text = row.Cells["MedRec_Doctor"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["MedRec_VisitDate"].Value?.ToString(), out DateTime visitDate))
                {
                    MedRecVisitDate_DateTimePicker.Value = visitDate;
                }

                MedRecDiagnosis_TextBox.Text = row.Cells["MedRec_Diagnosis"].Value?.ToString();
                MedRecNotes_TextBox.Text = row.Cells["MedRec_Notes"].Value?.ToString();
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
        private void MedRecAppointment_TextBox_TextChanged(object sender, EventArgs e) { }
        private void pictureBox9_Click(object sender, EventArgs e) { }
        private void pictureBox10_Click(object sender, EventArgs e) { }

        private void MedRec_AddBtn_Click_1(object sender, EventArgs e) { }
    }
}