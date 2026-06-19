using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group_4_Information_Management_Final_Project
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            timer1.Start();

            PrescriptionList_DataGridView.AutoGenerateColumns = false;

            Prescription_PrescriptionID.DataPropertyName = "prescription_id";
            Prescription_MedicineName.DataPropertyName = "medicine_name";
            Prescription_Dosage.DataPropertyName = "dosage";
            Prescription_Frequency.DataPropertyName = "frequency";
            Prescription_Duration.DataPropertyName = "duration";

            LoadPrescriptions();

            Prescription_UpdateBtn.Click += Prescription_UpdateBtn_Click;
            Prescription_DeleteBtn.Click += Prescription_DeleteBtn_Click;
            Prescription_ClearBtn.Click += Prescription_ClearBtn_Click;
            PrescriptionList_DataGridView.CellClick += Prescription_DataGridView_CellClick;
        }

        private void LoadPrescriptions()
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("GetPrescriptions", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            PrescriptionList_DataGridView.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Prescription_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PresPrescriptionID_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PresMedicineName_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PresDosage_TextBox.Text) ||
                string.IsNullOrWhiteSpace(PresFrequency_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(PresDuration_TextBox.Text))
            {
                MessageBox.Show("Please fill up all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("AddPrescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_prescription_id", PresPrescriptionID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_medicine_name", PresMedicineName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_dosage", PresDosage_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_frequency", PresFrequency_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_duration", PresDuration_TextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Prescription Added Successfully!");
                LoadPrescriptions();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Prescription_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PresPrescriptionID_TextBox.Text))
            {
                MessageBox.Show("Please select a prescription to update.");
                return;
            }
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UpdatePrescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_prescription_id", PresPrescriptionID_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_medicine_name", PresMedicineName_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_dosage", PresDosage_TextBox.Text);
                        cmd.Parameters.AddWithValue("p_frequency", PresFrequency_ComboBox.Text);
                        cmd.Parameters.AddWithValue("p_duration", PresDuration_TextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Prescription Updated Successfully!");
                LoadPrescriptions();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Prescription_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PresPrescriptionID_TextBox.Text))
            {
                MessageBox.Show("Please select a prescription to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand("DeletePrescription", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("p_prescription_id", PresPrescriptionID_TextBox.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Prescription Deleted Successfully!");
                    LoadPrescriptions();
                    ClearFields();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void Prescription_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            PresPrescriptionID_TextBox.Clear();
            PresMedicineName_TextBox.Clear();
            PresDosage_TextBox.Clear();
            PresFrequency_ComboBox.SelectedIndex = -1;
            PresDuration_TextBox.Clear();
            PresPrescriptionID_TextBox.Focus();
        }

        private void Prescription_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PrescriptionList_DataGridView.Rows[e.RowIndex];

                PresPrescriptionID_TextBox.Text = row.Cells["Prescription_PrescriptionID"].Value.ToString();
                PresMedicineName_TextBox.Text = row.Cells["Prescription_MedicineName"].Value.ToString();
                PresDosage_TextBox.Text = row.Cells["Prescription_Dosage"].Value.ToString();
                PresFrequency_ComboBox.Text = row.Cells["Prescription_Frequency"].Value.ToString();
                PresDuration_TextBox.Text = row.Cells["Prescription_Duration"].Value.ToString();
            }
        }

        private void Prescription_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Prescription_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home Prescription_homeForm = new Home();
            Prescription_homeForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void PresFrequency_ComboBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Prescription_ClearBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Prescription_UpdateBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Prescription_DeleteBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}