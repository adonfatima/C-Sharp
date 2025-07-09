using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpprojrctfinal
{
	public partial class Sellermenu : Form
	{
		private DataAccess Da { get; set; }
		public Sellermenu()
		{
			InitializeComponent();
			this.Da = new DataAccess();
			this.PopulateMenu();
		}
		private void PopulateMenu(string sql = "select *from sellertab")
		{
			var ds = this.Da.ExecuteQuery(sql);
			this.dgvseller.DataSource = ds.Tables[0];
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Alllogin home = new Alllogin();
			home.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=EMON\SQLEXPRESS;Initial Catalog=PriceHike15;Integrated Security=True");
			con.Open();
			var query = "delete from sellertab where AvproductName = '" + textBox1.Text + "';";
			//var query1 = "delete from admintab where Catagory = '" + textBox2.Text + "';";
			//var query2 = "delete from admintab where Price = '" + textBox3.Text + "';";
			var count = this.Da.ExecuteDMLQuery(query);
			//var count1 = this.Da.ExecuteDMLQuery(query1);
			//var count2 = this.Da.ExecuteDMLQuery(query2);
			con.Close();
			MessageBox.Show("Succesfully Delete");
			this.PopulateMenu();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=EMON\SQLEXPRESS;Initial Catalog=PriceHike15;Integrated Security=True");
			con.Open();
			string sql1 = "Insert into sellertab values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
			int count = Da.ExecuteDMLQuery(sql1);
			con.Close();
			MessageBox.Show("Succesfully ADD");

			this.PopulateMenu();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=EMON\SQLEXPRESS;Initial Catalog=PriceHike15;Integrated Security=True");
			con.Open();


			var query = "UPDATE sellertab SET Quantity = '" + textBox3.Text + "' WHERE AvProductName = '" + textBox1.Text + "'";
			var query1 = "UPDATE sellertab SET Quantity = '" + textBox3.Text + "' WHERE AvProductCatagory = '" + textBox2.Text + "'";
			var query2 = "UPDATE sellertab SET Quantity = '" + textBox3.Text + "' WHERE Tradenum = '" + textBox4.Text + "'";

			var count = this.Da.ExecuteDMLQuery(query);
			var count1 = this.Da.ExecuteDMLQuery(query1);
			var count2 = this.Da.ExecuteDMLQuery(query2);
			con.Close();
			MessageBox.Show("Succesfully Update");
			this.PopulateMenu();
		}

		private void dgvseller_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
