using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace medical
{
    public partial class alaccount : MetroFramework.Forms.MetroForm
    {
        public alaccount()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            forgot obj = new forgot();
            obj.Show();
            this.Hide();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alaccount_Load(object sender, EventArgs e)
        {
         
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection("data source=.; initial catalog= medical; integrated security =true ");
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand("select USERNAME,PASSWORD from NEWUSER where USERNAME='" + metroTextBox1.Text + "' and PASSWORD='" + metroTextBox2.Text + "'", cs);

            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cs.Open();
                items obj = new items();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" not valid");
                cs.Close();
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            adlog obj = new adlog();
            obj.Show();
            this.Hide();
        }
    }
}
