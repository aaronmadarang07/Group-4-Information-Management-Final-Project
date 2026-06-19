using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group_4_Information_Management_Final_Project
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            timer1.Start();

            DoctorsList_DataGridView.AutoGenerateColumns = false;

            DL_DoctorID.DataPropertyName = "doctor_id";
            DL_LastName.DataPropertyName = "last_name";
            DL_FirstName.DataPropertyName = "first_name";
            DL_Specialty.DataPropertyName = "specialty";
            DL_ContactNumber.DataPropertyName = "contact_number";
            DL_Availability.DataPropertyName = "availability";
            DL_StartTime.DataPropertyName = "start_time";
            DL_EndTime.DataPropertyName = "end_time";

            LoadDoctors();
        }

        private void LoadDoctors()
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("GetDoctors", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            DoctorsList_DataGridView.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoctorsForm_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorLastName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorFirstName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorSpecialty_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNumber_TextBox.Text) ||
                string.IsNullOrWhiteSpace(Schedule_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(StartTime_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(EndTime_ComboBox.Text))
            {
                MessageBox.Show("Please fill up all fields!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("AddDoctor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_doctor_id", DoctorID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_last_name", DoctorLastName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_first_name", DoctorFirstName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_specialty", DoctorSpecialty_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_contact_number", ContactNumber_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_availability", Schedule_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_start_time", StartTime_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_end_time", EndTime_ComboBox.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Doctor Added Successfully!");
                    LoadDoctors();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoctorsForm_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorLastName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorFirstName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorSpecialty_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNumber_TextBox.Text) ||
                string.IsNullOrWhiteSpace(Schedule_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(StartTime_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(EndTime_ComboBox.Text))
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UpdateDoctor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_doctor_id", DoctorID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_last_name", DoctorLastName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_first_name", DoctorFirstName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_specialty", DoctorSpecialty_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_contact_number", ContactNumber_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_availability", Schedule_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_start_time", StartTime_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_end_time", EndTime_ComboBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Doctor Updated Successfully!");
                LoadDoctors();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DoctorsForm_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorID_TextBox.Text))
            {
                MessageBox.Show("Please select a doctor to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand("DeleteDoctor", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("p_doctor_id", DoctorID_TextBox.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Doctor Deleted Successfully!");
                    LoadDoctors();
                    ClearFields();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void DoctorsForm_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            DoctorID_TextBox.Clear();
            DoctorLastName_TextBox.Clear();
            DoctorFirstName_TextBox.Clear();
            ContactNumber_TextBox.Clear();
            DoctorSpecialty_ComboBox.SelectedIndex = -1;
            Schedule_ComboBox.SelectedIndex = -1;
            StartTime_ComboBox.SelectedIndex = -1;
            EndTime_ComboBox.SelectedIndex = -1;
            DoctorID_TextBox.Focus();
        }

        private void DoctorsList_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DoctorsList_DataGridView.Rows[e.RowIndex];

                DoctorID_TextBox.Text = row.Cells["DL_DoctorID"].Value?.ToString();
                DoctorLastName_TextBox.Text = row.Cells["DL_LastName"].Value?.ToString();
                DoctorFirstName_TextBox.Text = row.Cells["DL_FirstName"].Value?.ToString();
                DoctorSpecialty_ComboBox.Text = row.Cells["DL_Specialty"].Value?.ToString();
                ContactNumber_TextBox.Text = row.Cells["DL_ContactNumber"].Value?.ToString();
                Schedule_ComboBox.Text = row.Cells["DL_Availability"].Value?.ToString();
                StartTime_ComboBox.Text = row.Cells["DL_StartTime"].Value?.ToString();
                EndTime_ComboBox.Text = row.Cells["DL_EndTime"].Value?.ToString();
            }
        }

        private void Appointments_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Appointments_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home doctor_homeForm = new Home();
            doctor_homeForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label9_Click(object sender, EventArgs e) { }
        private void pictureBox10_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}