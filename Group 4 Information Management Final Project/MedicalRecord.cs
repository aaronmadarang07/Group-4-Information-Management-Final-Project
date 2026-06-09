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
    public partial class MedicalRecord : Form
    {
        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MedRecAppointment_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MedRec_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MedRec_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home MedRec_homeForm = new Home();
            MedRec_homeForm.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
