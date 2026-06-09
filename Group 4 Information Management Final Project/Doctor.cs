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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsForm_AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsForm_DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsForm_UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsForm_ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
