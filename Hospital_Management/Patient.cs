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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string gender = textBox4.Text;
            string address = textBox5.Text;

            string query = "insert into patients(patientid,patientname,age,gender,address) values(@patientid,@patientname,@age,@gender,@address)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientid);
                    cmd.Parameters.AddWithValue("@PatientName", patientname);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            PatientData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string gender = textBox4.Text;
            string address = textBox5.Text;

            string query = "update patients set patientname=@patientname,age=@age,gender=@gender,address=@address where patientid=@patientid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientid);
                    cmd.Parameters.AddWithValue("@PatientName", patientname);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            PatientData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int patientid = int.Parse(textBox1.Text);


            string query = "delete from patients where patientid=@patientid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientid);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            PatientData();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

            PatientData();
            
        }

        private void PatientData()
        {
            string query = "select * from patients";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }   

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddToList_Click(object sender, EventArgs e)
        {

        }
    }
}
