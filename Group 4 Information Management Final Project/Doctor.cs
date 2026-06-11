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
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM doctors";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        DoctorsList_DataGridView.DataSource = table;
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

                    string query = @"INSERT INTO doctors
            (doctor_id, last_name, first_name, specialty, contact_number, availability, start_time, end_time)
            VALUES
            (@id, @lname, @fname, @specialty, @contact, @availability, @start, @end)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", DoctorID_TextBox.Text);
                        cmd.Parameters.AddWithValue("@lname", DoctorLastName_TextBox.Text);
                        cmd.Parameters.AddWithValue("@fname", DoctorFirstName_TextBox.Text);
                        cmd.Parameters.AddWithValue("@specialty", DoctorSpecialty_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@contact", ContactNumber_TextBox.Text);
                        cmd.Parameters.AddWithValue("@availability", Schedule_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@start", StartTime_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@end", EndTime_ComboBox.Text);
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
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE doctors SET
                    last_name=@lname,
                    first_name=@fname,
                    specialty=@specialty,
                    contact_number=@contact,
                    availability=@availability,
                    start_time=@start,
                    end_time=@end
                    WHERE doctor_id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", DoctorID_TextBox.Text);
                        cmd.Parameters.AddWithValue("@lname", DoctorLastName_TextBox.Text);
                        cmd.Parameters.AddWithValue("@fname", DoctorFirstName_TextBox.Text);
                        cmd.Parameters.AddWithValue("@specialty", DoctorSpecialty_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@contact", ContactNumber_TextBox.Text);
                        cmd.Parameters.AddWithValue("@availability", Schedule_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@start", StartTime_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@end", EndTime_ComboBox.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Doctor Updated Successfully!");
                    LoadDoctors();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoctorsForm_DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM doctors WHERE doctor_id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", DoctorID_TextBox.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Doctor Deleted Successfully!");
                    LoadDoctors();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        }

        private void DoctorsList_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DoctorsList_DataGridView.Rows[e.RowIndex];

                DoctorID_TextBox.Text = row.Cells["doctor_id"].Value.ToString();
                DoctorLastName_TextBox.Text = row.Cells["last_name"].Value.ToString();
                DoctorFirstName_TextBox.Text = row.Cells["first_name"].Value.ToString();
                DoctorSpecialty_ComboBox.Text = row.Cells["specialty"].Value.ToString();
                ContactNumber_TextBox.Text = row.Cells["contact_number"].Value.ToString();
                Schedule_ComboBox.Text = row.Cells["availability"].Value.ToString();
                StartTime_ComboBox.Text = row.Cells["start_time"].Value.ToString();
                EndTime_ComboBox.Text = row.Cells["end_time"].Value.ToString();
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
        private void pictureBox9_Click(object sender, EventArgs e) { }
    }
}