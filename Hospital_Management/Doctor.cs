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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(textBox1.Text);
            string doctorname = textBox2.Text;
            string Speciality = textBox3.Text;
            string phone = textBox4.Text;
            string department = textBox5.Text;

            string query = "insert into doctors(doctorid,doctorname,Speciality,phone,department) values(@doctorid,@doctorname,@Speciality,@phone,@department)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctorID", doctorid);
                    cmd.Parameters.AddWithValue("@doctorName", doctorname);
                    cmd.Parameters.AddWithValue("@Speciality", Speciality);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            DoctorData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(textBox1.Text);
            string doctorname = textBox2.Text;
            string Speciality = textBox3.Text;
            string phone = textBox4.Text;
            string department = textBox5.Text;

            string query = "update doctors set doctorname=@doctorname,Speciality=@Speciality,phone=@phone,department=@department where doctorid=@doctorid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctorID", doctorid);
                    cmd.Parameters.AddWithValue("@doctorName", doctorname);
                    cmd.Parameters.AddWithValue("@Speciality", Speciality);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            DoctorData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(textBox1.Text);


            string query = "delete from doctors where doctorid=@doctorid";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorid);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            DoctorData();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            DoctorData();
        }
        private void DoctorData()
        {
            string query = "select * from doctors";
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
