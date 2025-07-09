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
	public partial class Adminmenu : Form
	{
		private DataAccess Da { get; set; }
		public Adminmenu()
		{
			InitializeComponent();
			this.Da = new DataAccess();
			this.PopulateMenu();
		}
		private void PopulateMenu(string sql = "select *from admintab")
		{
			var ds = this.Da.ExecuteQuery(sql);
			this.dgvadmin.DataSource = ds.Tables[0];
		}
		private void button1_Click(object sender, EventArgs e)
		{
	       Alllogin home = new Alllogin();
			home.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=EMON\SQLEXPRESS;Initial Catalog=PriceHike15;Integrated Security=True");
			con.Open();
			string sql1 = "Insert into admintab values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
			int count = Da.ExecuteDMLQuery(sql1);
			con.Close();
			MessageBox.Show("Succesfully Insert");

			this.PopulateMenu();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=EMON\SQLEXPRESS;Initial Catalog=PriceHike15;Integrated Security=True");
			con.Open();
			var query = "delete from admintab where Name = '" + textBox1.Text + "';";
			//var query1 = "delete from admintab where Catagory = '" + textBox2.Text + "';";
			//var query2 = "delete from admintab where Price = '" + textBox3.Text + "';";
			var count = this.Da.ExecuteDMLQuery(query);
			//var count1 = this.Da.ExecuteDMLQuery(query1);
			//var count2 = this.Da.ExecuteDMLQuery(query2);
			con.Close();
			MessageBox.Show("Succesfully Delete");
			this.PopulateMenu();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=EMON\SQLEXPRESS;Initial Catalog=PriceHike15;Integrated Security=True");
			con.Open();


			var query = "UPDATE admintab SET Price = '" + textBox3.Text + "' WHERE Name = '" + textBox1.Text + "'";
			//var query1 = "UPDATE admintab SET Price = '" + textBox3.Text + "' WHERE Catagory = '" + textBox2.Text + "'";

			var count = this.Da.ExecuteDMLQuery(query);
			//var count1 = this.Da.ExecuteDMLQuery(query1);
			con.Close();
			MessageBox.Show("Succesfully Update");
			this.PopulateMenu();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			adsellview adsellview = new adsellview();
			adsellview.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
