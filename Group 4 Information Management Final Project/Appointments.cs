using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group_4_Information_Management_Final_Project
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            timer1.Start();

            AppointmentList_DataGridView.AutoGenerateColumns = false;

            App_AppointmentID.DataPropertyName = "appointment_id";
            App_PatientName.DataPropertyName = "patient_name";
            App_DoctorName.DataPropertyName = "doctor_name";
            App_AppointmentDate.DataPropertyName = "appointment_date";
            App_AppointmentTime.DataPropertyName = "appointment_time";
            App_Status.DataPropertyName = "status";
            App_Remarks.DataPropertyName = "remarks";

            LoadDoctorIDs();
            LoadPatientIDs();

            LoadAppointments();
        }

        private void LoadAppointments(string search = "")
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("GetAppointments", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (!string.IsNullOrWhiteSpace(search))
                            {
                                DataView view = table.DefaultView;
                                string safeSearch = search.Replace("'", "''");

                                view.RowFilter =
                                    $"appointment_id LIKE '%{safeSearch}%' OR " +
                                    $"patient_name LIKE '%{safeSearch}%' OR " +
                                    $"doctor_name LIKE '%{safeSearch}%'";

                                AppointmentList_DataGridView.DataSource = view;
                            }
                            else
                            {
                                AppointmentList_DataGridView.DataSource = table;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void LoadPatientIDs()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT patient_id FROM patients";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    AppPatientID_ComboBox.DataSource = dt;

                    AppPatientID_ComboBox.DisplayMember =
                        "patient_id";

                    AppPatientID_ComboBox.ValueMember =
                        "patient_id";
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

                    AppDoctorID_ComboBox.DataSource = dt;

                    AppDoctorID_ComboBox.DisplayMember =
                        "doctor_id";

                    AppDoctorID_ComboBox.ValueMember =
                        "doctor_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetPatientDisplay(string patientId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT CONCAT(patient_id, ' - ', first_name, ' ', last_name) FROM patients WHERE patient_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", patientId);
                    object result = cmd.ExecuteScalar();

                    return result == null ? patientId + " - Not Found" : result.ToString();
                }
            }
        }

        private string GetDoctorDisplay(string doctorId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT CONCAT(doctor_id, ' - ', first_name, ' ', last_name) FROM doctors WHERE doctor_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", doctorId);
                    object result = cmd.ExecuteScalar();

                    return result == null ? doctorId + " - Not Found" : result.ToString();
                }
            }
        }

        private void Appointment_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AppID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(AppPatientID_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(AppDoctorID_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(AppAppointmentTime_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(AppStatus_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(AppRemarks_TextBox.Text))
            {
                MessageBox.Show("Please fill up all required fields!",
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

                    using (MySqlCommand cmd = new MySqlCommand("AddAppointment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_appointment_id", AppID_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_patient_name", GetPatientDisplay(AppPatientID_ComboBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("p_doctor_name", GetDoctorDisplay(AppDoctorID_ComboBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("p_appointment_date", AppDate_DateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("p_appointment_time", AppAppointmentTime_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_schedule", AppAppointmentTime_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_status", AppStatus_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_remarks", AppRemarks_TextBox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment added successfully!");
                LoadAppointments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void Appointment_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AppID_TextBox.Text))
            {
                MessageBox.Show("Please select an appointment to update.");
                return;
            }

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("UpdateAppointment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_appointment_id", AppID_TextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_patient_name", GetPatientDisplay(AppPatientID_ComboBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("p_doctor_name", GetDoctorDisplay(AppDoctorID_ComboBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("p_appointment_date", AppDate_DateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("p_appointment_time", AppAppointmentTime_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_schedule", AppAppointmentTime_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_status", AppStatus_ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("p_remarks", AppRemarks_TextBox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment updated successfully!");
                LoadAppointments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void Appointment_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AppID_TextBox.Text))
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand("DeleteAppointment", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("p_appointment_id", AppID_TextBox.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Appointment deleted successfully!");
                    LoadAppointments();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Error: " + ex.Message);
                }
            }
        }

        private void Appointment_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            AppID_TextBox.Clear();
            AppPatientID_ComboBox.Text = "";
            AppDoctorID_ComboBox.Text = "";
            AppRemarks_TextBox.Clear();
            AppDate_DateTimePicker.Value = DateTime.Now;
            AppAppointmentTime_ComboBox.SelectedIndex = -1;

            AppDoctorID_ComboBox.SelectedIndex = -1;
            AppPatientID_ComboBox.SelectedIndex = -1;
            AppRemarks_TextBox.Text = "";
            AppStatus_ComboBox.SelectedIndex = -1;
            AppID_TextBox.Focus();

            AppAppointmentTime_ComboBox.Text = "";
            AppStatus_ComboBox.SelectedIndex = -1;
            AppStatus_ComboBox.Text = "";
        }

        private void AppID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currentText = AppID_TextBox.Text;

            if (e.KeyChar == (char)Keys.Back)
                return;

            if (currentText.Length == 0)
            {
                if (char.ToUpper(e.KeyChar) == 'A')
                {
                    e.Handled = true;
                    AppID_TextBox.Text = "A";
                    AppID_TextBox.SelectionStart = AppID_TextBox.Text.Length;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Invalid input. Appointment ID must start with letter A.",
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

        private void AppointmentList_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AppointmentList_DataGridView.Rows[e.RowIndex];

                AppID_TextBox.Text = row.Cells["App_AppointmentID"].Value?.ToString();
                AppPatientID_ComboBox.Text = row.Cells["App_PatientName"].Value?.ToString();
                AppDoctorID_ComboBox.Text = row.Cells["App_DoctorName"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["App_AppointmentDate"].Value?.ToString(), out DateTime date))
                {
                    AppDate_DateTimePicker.Value = date;
                }

                AppAppointmentTime_ComboBox.Text = row.Cells["App_AppointmentTime"].Value?.ToString();
                AppStatus_ComboBox.Text = row.Cells["App_Status"].Value?.ToString();
                AppRemarks_TextBox.Text = row.Cells["App_Remarks"].Value?.ToString();
            }
        }

        private void AppointmentSearch_TextBox_TextChanged(object sender, EventArgs e)
        {
            LoadAppointments(AppointmentSearch_TextBox.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Appointments_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Appointments_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home Appointments_homeForm = new Home();
            Appointments_homeForm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e) { }
        private void pictureBox10_Click(object sender, EventArgs e) { }
        private void pictureBox9_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void AppointmentList_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AppAppointmentTime_ComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AppDoctorID_ComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}