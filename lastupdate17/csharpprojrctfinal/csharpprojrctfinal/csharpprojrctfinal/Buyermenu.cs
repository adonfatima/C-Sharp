using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace csharpprojrctfinal
{
	public partial class Buyermenu : Form
	{
		private DataAccess Da { get; set; }
		public Buyermenu()
		{
			InitializeComponent();
			this.Da = new DataAccess();
			this.PopulateMenu();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count < 1)
			{
				MessageBox.Show("Plaese select a Row first to Add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{

				string Name = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
				string amount = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
				string Cat = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();


				string net = (Convert.ToInt32(amount) * Convert.ToInt32(this.txtQnty.Text)).ToString();
				//Console.WriteLine("amount:" + amount + "net:" + net);

				//MessageBox.Show("An error has occured: " + amount + net);
				var query = "select * from Cart where Name = '" + Name + "'";
				var ds = this.Da.ExecuteQuery(query);

				if (ds.Tables[0].Rows.Count == 0)
				{

					var sql = "insert into Cart values('" + Name + "','" + Cat + "','" + amount + "'," + this.txtQnty.Text + "," + net + ")";

					int count = this.Da.ExecuteDMLQuery(sql);

					this.totalAmount();
					this.PopulateTBill();
					this.txtQnty.Text = "01";

				}
				else
				{
					//					string Uprice = (Convert.ToInt32(amount) * Convert.ToInt32(this.txtQnty.Text)).ToString();

					var sql = "update Cart set Quantity = '" + this.txtQnty.Text + "', Net=" + net + " where Name = '" + Name + "'";
					var count = this.Da.ExecuteDMLQuery(sql);
					this.PopulateTBill();
					this.txtQnty.Text = "01";
					this.totalAmount();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show("An error has occured: " + exc.Message);
			}
		}

		internal void totalAmount()
		{
			var cmd = "select sum(Net) from Cart ";
			var dt = this.Da.ExecuteScalarQuery(cmd);
			this.textBox2.Text = dt;

		}
		private void button1_Click(object sender, EventArgs e)
		{
			Alllogin home = new Alllogin();
			home.Show();
			this.Hide();
		}

		private void Buyermenu_Load(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			bill bill = new bill();
			bill.Show();
			this.Hide();
			this.ClearContant();
		}
		private void PopulateMenu(string sql = "select * from admintab")
		{
			var ds = this.Da.ExecuteQuery(sql);
			this.dataGridView1.DataSource = ds.Tables[0];
		}
		private void PopulateTBill(string sql = "select * from Cart")
		{
			var ds = this.Da.ExecuteQuery(sql);
			this.dataGridView2.DataSource = ds.Tables[0];
		}
		private void txt_Search(object sender, EventArgs e)
		{
			string sqlS = "select * from admintab where Name like '" + this.textBox1.Text + "%';";
			this.PopulateMenu(sqlS);
		}

		internal void ClearContant()
		{
			var sql = "delete from Cart";
			var dml = this.Da.ExecuteDMLQuery(sql);
			this.PopulateTBill();
		}

		private void update_click(object sender, EventArgs e)
		{
			if (this.dataGridView2.SelectedRows.Count < 1)
			{
				//MessageBox.Show("Plaese select a Row first to Add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				this.txtQnty.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
				string Price = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
				string price = (Convert.ToInt32(Price) * Convert.ToInt32(this.txtQnty.Text)).ToString();
				string Name = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
				string cmd = "Update Cart set Quantity='" + this.txtQnty.Text + "' , Net = " + price + " where Name = '" + Name + "'";
				var count = this.Da.ExecuteDMLQuery(cmd);
				//this.ClearContant();
				//
			}
			catch (Exception exc)
			{
				MessageBox.Show("An error has occured: " + exc.Message);
			}
		}

		private void update_click(object sender, MouseEventArgs e)
		{
			if (this.dataGridView2.SelectedRows.Count < 1)
			{
				//MessageBox.Show("Plaese select a Row first to Add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				this.txtQnty.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
				string Price = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
				string price = (Convert.ToInt32(Price) * Convert.ToInt32(this.txtQnty.Text)).ToString();
				string Name = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
				string cmd = "Update Cart set Quantity='" + this.txtQnty.Text + "' , Net = " + price + " where Name = '" + Name + "'";
				var count = this.Da.ExecuteDMLQuery(cmd);
				//this.ClearContant();
				//
			}
			catch (Exception exc)
			{
				MessageBox.Show("An error has occured: " + exc.Message);
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			this.ClearContant();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (this.dataGridView2.SelectedRows.Count < 1)
			{
				//MessageBox.Show("Plaese select a Row first to Add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				this.txtQnty.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
				string Price = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
				string price = (Convert.ToInt32(Price) * Convert.ToInt32(this.txtQnty.Text)).ToString();
				string Name = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
				string cmd = "Update Cart set Quantity='" + this.txtQnty.Text + "' , Net = " + price + " where Name = '" + Name + "'";
				var count = this.Da.ExecuteDMLQuery(cmd);
				//this.ClearContant();
				this.PopulateTBill();
			}
			catch (Exception exc)
			{
				MessageBox.Show("An error has occured: " + exc.Message);
			}
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
