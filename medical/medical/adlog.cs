using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical
{
    public partial class adlog :MetroFramework.Forms.MetroForm
    {
        public adlog()
        {
            InitializeComponent();
        }

        private void adlog_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "brijesh" && metroTextBox2.Text == "123")
            {
                add obj = new add();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("INVALID Username/Password");

            }

        }
    }
}
