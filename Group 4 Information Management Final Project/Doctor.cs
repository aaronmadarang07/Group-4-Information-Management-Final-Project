using System;
using System.Data;
using System.Linq;
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

        private bool HasEmptyFields()
        {
            return string.IsNullOrWhiteSpace(DoctorID_TextBox.Text) ||
                   string.IsNullOrWhiteSpace(DoctorLastName_TextBox.Text) ||
                   string.IsNullOrWhiteSpace(DoctorFirstName_TextBox.Text) ||
                   string.IsNullOrWhiteSpace(DoctorSpecialty_ComboBox.Text) ||
                   string.IsNullOrWhiteSpace(ContactNumber_TextBox.Text) ||
                   string.IsNullOrWhiteSpace(Schedule_ComboBox.Text) ||
                   string.IsNullOrWhiteSpace(StartTime_ComboBox.Text) ||
                   string.IsNullOrWhiteSpace(EndTime_ComboBox.Text);
        }

        private void DoctorsForm_AddBtn_Click(object sender, EventArgs e)
        {
            if (HasEmptyFields())
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
            if (string.IsNullOrWhiteSpace(DoctorID_TextBox.Text))
            {
                MessageBox.Show("Please select a doctor to update.",
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

                    using (MySqlCommand cmd = new MySqlCommand("UpdateDoctor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_doctor_id", DoctorID_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_last_name", DoctorLastName_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_first_name", DoctorFirstName_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_specialty", DoctorSpecialty_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_contact_number", ContactNumber_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_availability", Schedule_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_start_time", StartTime_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_end_time", EndTime_ComboBox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Doctor Updated Successfully!");
                LoadDoctors();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                            cmd.Parameters.AddWithValue("p_doctor_id", DoctorID_TextBox.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Doctor Deleted Successfully!");
                    LoadDoctors();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            DoctorSpecialty_ComboBox.Text = "";
            Schedule_ComboBox.SelectedIndex = -1;
            Schedule_ComboBox.Text = "";
            StartTime_ComboBox.SelectedIndex = -1;
            StartTime_ComboBox.Text = "";
            EndTime_ComboBox.SelectedIndex = -1;
            EndTime_ComboBox.Text = "";
        }

        private void DoctorID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currentText = DoctorID_TextBox.Text;

            if (e.KeyChar == (char)Keys.Back)
                return;

            if (currentText.Length == 0)
            {
                if (char.ToUpper(e.KeyChar) == 'D')
                {
                    e.Handled = true;
                    DoctorID_TextBox.Text = "D";
                    DoctorID_TextBox.SelectionStart = DoctorID_TextBox.Text.Length;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Invalid input. Doctor ID must start with letter D.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool isDoctorFormatting = false;

        private void ContactNumber_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid field type. Please input your phone number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string digitsOnly = new string(ContactNumber_TextBox.Text.Where(char.IsDigit).ToArray());

            if (digitsOnly.Length >= 11)
                e.Handled = true;
        }

        private void ContactNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isDoctorFormatting) return;

            isDoctorFormatting = true;

            string digits = new string(ContactNumber_TextBox.Text.Where(char.IsDigit).ToArray());

            if (digits.Length > 11)
                digits = digits.Substring(0, 11);

            string formatted = digits;

            if (digits.Length > 4 && digits.Length <= 7)
                formatted = digits.Substring(0, 4) + "-" + digits.Substring(4);
            else if (digits.Length > 7)
                formatted = digits.Substring(0, 4) + "-" + digits.Substring(4, 3) + "-" + digits.Substring(7);

            ContactNumber_TextBox.Text = formatted;
            ContactNumber_TextBox.SelectionStart = ContactNumber_TextBox.Text.Length;

            isDoctorFormatting = false;
        }

        private void ContactNumber_TextBox_Leave(object sender, EventArgs e)
        {
            string digits = new string(ContactNumber_TextBox.Text.Where(char.IsDigit).ToArray());

            if (digits.Length > 0 && (digits.Length != 11 || !digits.StartsWith("09")))
            {
                MessageBox.Show("Contact number must start with '09' and be exactly 11 digits.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}