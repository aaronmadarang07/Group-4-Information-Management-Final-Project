using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Group_4_Information_Management_Final_Project
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            timer1.Start();
            PatientsList_DataGridView.AutoGenerateColumns = false;

            PL_PatientID.DataPropertyName = "patient_id";
            PL_LastName.DataPropertyName = "last_name";
            PL_FirstName.DataPropertyName = "first_name";
            PL_DateOfBirth.DataPropertyName = "date_of_birth";
            PL_Gender.DataPropertyName = "gender";
            PL_ContactNumber.DataPropertyName = "contact_number";
            PL_BloodType.DataPropertyName = "blood_type";

            LoadPatients();
        }

        private void LoadPatients()
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("GetPatients", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            PatientsList_DataGridView.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            PatientID_TextBox.Clear();
            PatientLastName_TextBox.Clear();
            PatientFirstName_TextBox.Clear();
            PatientGender_ComboBox.SelectedIndex = -1;
            PatientContactNumber_TextBox.Clear();
            PatientAddress_TextBox.Clear();
            PatientBloodType_ComboBox.SelectedIndex = -1;
        }

        private void PatientsForm_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PatientLastName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PatientFirstName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PatientGender_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(PatientContactNumber_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PatientAddress_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PatientBloodType_ComboBox.Text))
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

                    using (MySqlCommand cmd = new MySqlCommand("AddPatient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_patient_id", PatientID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_last_name", PatientLastName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_first_name", PatientFirstName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_date_of_birth", PatientDOB_DateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("p_gender", PatientGender_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_contact_number", PatientContactNumber_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_address", PatientAddress_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_blood_type", PatientBloodType_ComboBox.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Patient Added Successfully!");
                    LoadPatients();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Patient_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Patient_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home Patient_homeForm = new Home();
            Patient_homeForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void pictureBox12_Click(object sender, EventArgs e) { }
        private void TimeLabel_Click(object sender, EventArgs e) { }
        private void DateLabel_Click(object sender, EventArgs e) { }
    }
}