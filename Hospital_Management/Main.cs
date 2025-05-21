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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient pt = new Patient();
            pt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nurse ne = new Nurse();
            ne.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Appointment at = new Appointment();
            at.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicalRecord mr = new MedicalRecord();
            mr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bill bl = new Bill();
            bl.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}
