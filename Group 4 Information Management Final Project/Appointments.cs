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
            LoadAppointments();
        }

        private void LoadAppointments(string search = "")
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT appointment_id, patient_name, doctor_name, 
                                          appointment_date, appointment_time, schedule, 
                                          status, remarks 
                                   FROM appointments_tbl";

                    if (!string.IsNullOrEmpty(search))
                        sql += " WHERE appointment_id LIKE @s OR patient_name LIKE @s OR doctor_name LIKE @s";

                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        if (!string.IsNullOrEmpty(search))
                            adapter.SelectCommand.Parameters.AddWithValue("@s", "%" + search + "%");

                        var table = new DataTable();
                        adapter.Fill(table);
                        AppointmentList_DataGridView.DataSource = table;
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
                string.IsNullOrWhiteSpace(AppPatientName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(AppDoctorID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(AppStartTime_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(AppSchedule_ComboBox.Text) ||
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

                    string sql = @"INSERT INTO appointments_tbl 
                          (appointment_id, patient_name, doctor_name, appointment_date, 
                           appointment_time, schedule, status, remarks)
                          VALUES (@id, @patient, @doctor, @date, @time, @schedule, @status, @remarks)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", AppID_TextBox.Text);
                        cmd.Parameters.AddWithValue("@patient", AppPatientName_TextBox.Text);
                        cmd.Parameters.AddWithValue("@doctor", AppDoctorID_TextBox.Text);
                        cmd.Parameters.AddWithValue("@date", AppDate_DateTimePicker.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@time", AppStartTime_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@schedule", AppSchedule_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@status", AppStatus_ComboBox.Text);
                        cmd.Parameters.AddWithValue("@remarks", AppRemarks_TextBox.Text);

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

            if (MessageBox.Show("Are you sure you want to delete this appointment?",
                "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM appointments_tbl WHERE appointment_id = @id";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", AppID_TextBox.Text);
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
                    string sql = @"UPDATE appointments_tbl SET 
                                   patient_name = @patient,
                                   doctor_name = @doctor,
                                   appointment_date = @date,
                                   appointment_time = @time,
                                   schedule = @schedule,
                                   status = @status,
                                   remarks = @remarks
                                   WHERE appointment_id = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@patient", AppPatientName_TextBox.Text);
                        cmd.Parameters.AddWithValue("@doctor", AppDoctorID_TextBox.Text);
                        cmd.Parameters.AddWithValue("@date", AppDate_DateTimePicker.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@time", AppStartTime_ComboBox.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@schedule", AppSchedule_ComboBox.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@status", AppStatus_ComboBox.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@remarks", AppRemarks_TextBox.Text);
                        cmd.Parameters.AddWithValue("@id", AppID_TextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Appointment updated successfully!");
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void Appointment_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            AppID_TextBox.Text = "";
            AppPatientName_TextBox.Text = "";
            AppDoctorID_TextBox.Text = "";
            AppRemarks_TextBox.Text = "";
            AppDate_DateTimePicker.Value = DateTime.Now;
            AppStartTime_ComboBox.SelectedIndex = -1;
            AppSchedule_ComboBox.SelectedIndex = -1;
            AppStatus_ComboBox.SelectedIndex = 0;
        }

        private void AppointmentList_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AppointmentList_DataGridView.Rows[e.RowIndex];
                AppID_TextBox.Text = row.Cells[0].Value?.ToString();
                AppPatientName_TextBox.Text = row.Cells[1].Value?.ToString();
                AppDoctorID_TextBox.Text = row.Cells[2].Value?.ToString();

                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime date))
                    AppDate_DateTimePicker.Value = date;

                AppStartTime_ComboBox.Text = row.Cells[4].Value?.ToString();
                AppSchedule_ComboBox.Text = row.Cells[5].Value?.ToString();
                AppStatus_ComboBox.Text = row.Cells[6].Value?.ToString();
                AppRemarks_TextBox.Text = row.Cells[7].Value?.ToString();
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

        }
    }
