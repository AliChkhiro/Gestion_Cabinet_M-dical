using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class MedicalRecord : Form
    {
        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int mid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            string doctorname = textBox3.Text;
            string nurse = textBox4.Text;
            string diagnosis = textBox5.Text;
            string prescription = textBox6.Text;
            string treatment = textBox7.Text;

            string query = "insert into records(mid,patientname,doctorname,nurse,diagnosis,prescription,treatment) values(@mid,@patientname,@doctorname,@nurse,@diagnosis,@prescription,@treatment)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MID", mid);
                    cmd.Parameters.AddWithValue("@PatientName", patientname);
                    cmd.Parameters.AddWithValue("@DoctorName", doctorname);
                    cmd.Parameters.AddWithValue("@Nurse", nurse);
                    cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
                    cmd.Parameters.AddWithValue("@Prescription", prescription);
                    cmd.Parameters.AddWithValue("@Treatment", treatment);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            ReacordData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int mid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            string doctorname = textBox3.Text;
            string nurse = textBox4.Text;
            string diagnosis = textBox5.Text;
            string prescription = textBox6.Text;
            string treatment = textBox7.Text;

            string query = "update records set patientname=@patientname,doctorname=@doctorname,nurse=@nurse,diagnosis=@diagnosis,prescription=@prescription,treatment=@treatment  where mid=@mid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MID", mid);
                    cmd.Parameters.AddWithValue("@PatientName", patientname);
                    cmd.Parameters.AddWithValue("@DoctorName", doctorname);
                    cmd.Parameters.AddWithValue("@Nurse", nurse);
                    cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
                    cmd.Parameters.AddWithValue("@Prescription", prescription);
                    cmd.Parameters.AddWithValue("@Treatment", treatment);
                    
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            ReacordData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int mid = int.Parse(textBox1.Text);


            string query = "delete from records where mid=@mid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MID", mid);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            ReacordData();
        }

        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            ReacordData();
        }
        private void ReacordData()
        {
            string query = "select * from records";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
