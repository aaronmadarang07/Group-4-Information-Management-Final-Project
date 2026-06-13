using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_4_Information_Management_Final_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_GoToPatientsBtn_Click(object sender, EventArgs e)
        {
            Patient patientsForm = new Patient();
            patientsForm.Show();
            this.Hide();
        }

        private void Home_GoToMedRecordsBtn_Click(object sender, EventArgs e)
        {
            MedicalRecord medicalrecordForm = new MedicalRecord();
            medicalrecordForm.Show();
            this.Hide();
        }

        private void Home_GoToDashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show(); 
            this.Hide();
        }

        private void Home_GoToAppointmentsBtn_Click(object sender, EventArgs e)
        {
            Appointments appointmentsForm = new Appointments();
            appointmentsForm.Show();
            this.Hide();
        }

        private void Home_GoToDoctorsBtn_Click(object sender, EventArgs e)
        {
            Doctor doctorForm = new Doctor();
            doctorForm.Show();
            this.Hide();
        }

        private void Home_GoToPrescriptionsBtn_Click(object sender, EventArgs e)
        {
            Prescription prescriptionForm = new Prescription();
            prescriptionForm.Show();
            this.Hide();
        }

        private void Home_ExitBtn_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Home_ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
