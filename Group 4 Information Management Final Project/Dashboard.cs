using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Group_4_Information_Management_Final_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadAppointmentsChart();
            timer1.Start();
        }

        private void LoadAppointmentsChart()
        {
            AppointmentsChart.Series.Clear();

            Series series = new Series("Appointments");

            series.ChartType = SeriesChartType.Line;

            series.Points.AddXY("Mon", 3);
            series.Points.AddXY("Tue", 2);
            series.Points.AddXY("Wed", 4);
            series.Points.AddXY("Thu", 3);
            series.Points.AddXY("Fri", 3);
            series.Points.AddXY("Sat", 3);
            series.Points.AddXY("Sun", 1);

            AppointmentsChart.Series.Add(series);
        }

        private void AppointmentsChart_Click(object sender, EventArgs e)
        {
           
        }


        private void LoadDashboardStats()
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM patients", conn))
                        label7.Text = cmd.ExecuteScalar().ToString();

                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM doctors", conn))
                        label8.Text = cmd.ExecuteScalar().ToString();

                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM appointments", conn))
                        label9.Text = cmd.ExecuteScalar().ToString();

                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM medical_records", conn))
                        label10.Text = cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void LoadTodaysAppointments()
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT a.appointment_date AS Time,
                                  p.name AS Patient,
                                  d.name AS Doctor,
                                  a.status AS Status
                           FROM appointments a
                           JOIN patients p ON a.patient_id = p.id
                           JOIN doctors d ON a.doctor_id = d.id";

                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        TodApp_DataGridView.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }
        private void DashBoard_GoToAppointmentsBtn_Click(object sender, EventArgs e)
        {
            Appointments DB_appointmentsForm = new Appointments();
            DB_appointmentsForm.Show();
            this.Hide();
        }

        private void Home_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoard_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home DB_homeForm = new Home();
            DB_homeForm.Show();
            this.Hide();
        }

        private void DashBoard_GoToPatientsBtn_Click(object sender, EventArgs e)
        {
            Patient DB_patientForm = new Patient();
            DB_patientForm.Show();
            this.Hide();
        }

        private void DashBoard_GoToDoctorsBtn_Click(object sender, EventArgs e)
        {
            Doctor DB_doctorForm = new Doctor();
            DB_doctorForm.Show();
            this.Hide();
        }

        private void DashBoard_GoToMedRecordsBtn_Click(object sender, EventArgs e)
        {
            MedicalRecord DB_medrecForm = new MedicalRecord();
            DB_medrecForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
