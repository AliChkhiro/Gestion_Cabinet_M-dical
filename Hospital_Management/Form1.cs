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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text=="admin" && textPassword.Text=="1234")
            {
                Main mn = new Main();
                mn.ShowDialog();
            }
            else if (textUsername.Text != "admin" || textPassword.Text != "1234")
            {
                MessageBox.Show("Ivalid username or password");
            }
        }
    }
}
