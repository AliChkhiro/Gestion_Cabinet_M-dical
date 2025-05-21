using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int aid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            string doctorname = textBox3.Text;
            string date_created = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string status = textBox4.Text;

            string query = "insert into appointments(aid,patientname,doctorname,date_created,status) values(@aid,@patientname,@doctorname,@date_created,@status)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AID", aid);
                    cmd.Parameters.AddWithValue("@PatientName", patientname);
                    cmd.Parameters.AddWithValue("@DoctorName", doctorname);
                    cmd.Parameters.AddWithValue("@Date_Created", date_created);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            AppointData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int aid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            string doctorname = textBox3.Text;
            string date_created = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string status = textBox4.Text;

            string query = "update appointments set patientname=@patientname,doctorname=@doctorname,date_created=@date_created,status=@status  where aid=@aid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AID", aid);
                    cmd.Parameters.AddWithValue("@PatientName", patientname);
                    cmd.Parameters.AddWithValue("@DoctorName", doctorname);
                    cmd.Parameters.AddWithValue("@Date_Created", date_created);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            AppointData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int aid = int.Parse(textBox1.Text);


            string query = "delete from appointments where aid=@aid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AID", aid);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            AppointData();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            AppointData();
        }
        private void AppointData()
        {
            string query = "select * from appointments";
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
