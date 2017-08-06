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

namespace medical
{
    public partial class newuser : MetroFramework.Forms.MetroForm
    {
        public newuser()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection("data source=.; initial catalog= MEDICAL; integrated security =true ");
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand();
            da.InsertCommand = new SqlCommand("insert into NEWUSER values   (@USERNAME,@PASSWORD,@EMAIL,@MOBILE)", cs);
            da.InsertCommand.Parameters.Add("USERNAME", SqlDbType.VarChar).Value = metroTextBox1.Text;
            da.InsertCommand.Parameters.Add("PASSWORD", SqlDbType.VarChar).Value = metroTextBox2.Text;
            da.InsertCommand.Parameters.Add("EMAIL", SqlDbType.VarChar).Value = metroTextBox3.Text;
            da.InsertCommand.Parameters.Add("MOBILE", SqlDbType.VarChar).Value = metroTextBox4.Text;


            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            MessageBox.Show("DATA SAVED");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            alaccount obj = new alaccount();
            obj.Show();
            this.Hide();
        }
    }
}
