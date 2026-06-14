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
            AppointmentList_DataGridView.CellClick += AppointmentList_DataGridView_CellClick;

            App_AppointmentID.DataPropertyName = "appointment_id";
            App_PatientName.DataPropertyName = "patient_name";
            App_DoctorName.DataPropertyName = "doctor_name";
            App_AppointmentDate.DataPropertyName = "appointment_date";
            App_AppointmentTime.DataPropertyName = "appointment_time";
            //App_Schedule.DataPropertyName = "schedule";
            App_Status.DataPropertyName = "status";
            App_Remarks.DataPropertyName = "remarks";

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
                                view.RowFilter =
                                    $"appointment_id LIKE '%{search.Replace("'", "''")}%' OR " +
                                    $"patient_name LIKE '%{search.Replace("'", "''")}%' OR " +
                                    $"doctor_name LIKE '%{search.Replace("'", "''")}%'";
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

                        cmd.Parameters.AddWithValue("p_appointment_id", AppID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_patient_id", AppPatientID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_doctor_id", AppDoctorID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_appointment_date", AppDate_DateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("p_appointment_time", AppAppointmentTime_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_status", AppStatus_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_remarks", AppRemarks_TextBox.Text);

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
                            cmd.Parameters.AddWithValue("p_appointment_id", AppID_TextBox.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Appointment deleted successfully!");
                    LoadAppointments();
                    ClearFields();
                }
                catch (Exception ex) { MessageBox.Show("DB Error: " + ex.Message); }
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
                        cmd.Parameters.AddWithValue("p_appointment_id", AppID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_patient_id", AppPatientID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_doctor_id", AppDoctorID_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_appointment_date", AppDate_DateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("p_appointment_time", AppAppointmentTime_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_status", AppStatus_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_remarks", AppRemarks_TextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Appointment updated successfully!");
                LoadAppointments();
            }
            catch (Exception ex) { MessageBox.Show("DB Error: " + ex.Message); }
        }

        private void Appointment_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            AppID_TextBox.Text = "";
            AppPatientID_ComboBox.Text = "";
            AppDoctorID_ComboBox.Text = "";
            AppRemarks_TextBox.Text = "";
            AppDate_DateTimePicker.Value = DateTime.Now;
            AppAppointmentTime_ComboBox.SelectedIndex = -1;
            AppStatus_ComboBox.SelectedIndex = -1;
        }

        private void AppointmentList_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AppointmentList_DataGridView.Rows[e.RowIndex];

                AppID_TextBox.Text = row.Cells["App_AppointmentID"].Value?.ToString();
                AppPatientID_ComboBox.Text = row.Cells["App_PatientID"].Value?.ToString();
                AppDoctorID_ComboBox.Text = row.Cells["App_DoctorID"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["App_AppointmentDate"].Value?.ToString(), out DateTime date))
                    AppDate_DateTimePicker.Value = date;

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

        private void AppointmentList_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppAppointmentTime_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppDoctorID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}