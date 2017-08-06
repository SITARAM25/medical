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
    public partial class add : MetroFramework.Forms.MetroForm
    {
        SqlConnection cs = new SqlConnection("Data Source=.;Initial Catalog= medical;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public add()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("insert into details1 values(@ITEMS,@QUANTITY)", cs);
            da.InsertCommand.Parameters.Add("ITEMS", SqlDbType.VarChar).Value = metroComboBox1.Text;
            da.InsertCommand.Parameters.Add("QUANTITY", SqlDbType.Int).Value = metroTextBox1.Text; ;
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            MessageBox.Show("ENTERED");

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select *from details1", cs);
            ds.Clear();
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];


            MessageBox.Show("display");
        }

        private void dpupg()
        { //  BindingSource bs = new BindingSource();

            bs.DataSource = ds.Tables[0];
            metroGrid1.ClearSelection();
            metroGrid1.Rows[bs.Position].Selected = true;
        }

        
        private void metroButton3_Click(object sender, EventArgs e)
        {
            bs.DataSource = ds.Tables[0];
            // BindingSource bs = new BindingSource();
            bs.MoveNext();
            dpupg();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            bs.DataSource = ds.Tables[0];
            // BindingSource bs = new BindingSource();
            bs.MovePrevious();
            dpupg();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            bs.DataSource = ds.Tables[0];
            da.DeleteCommand = new SqlCommand("delete from details1 where ITEMS=@ITEMS", cs);
            da.DeleteCommand.Parameters.Add("@ITEMS", SqlDbType.VarChar).Value =ds.Tables[0].Rows[bs.Position][0];
          


            cs.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cs.Close();
            MessageBox.Show("Item Deleted");
            da.SelectCommand = new SqlCommand("select *from details1", cs);
            ds.Clear();
            da.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
