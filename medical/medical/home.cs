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
    public partial class home : MetroFramework.Forms.MetroForm
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alaccount obj = new alaccount();
            obj.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newuser obj = new newuser();
            obj.Show();
            this.Hide();
        }
    }
}
