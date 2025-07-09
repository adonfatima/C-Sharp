using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpprojrctfinal
{
	public partial class bill : Form
	{
		private DataAccess Da { get; set; }
		public bill()
		{

			InitializeComponent();
			this.Da = new DataAccess();
			this.PopulateMenu();
		}
		private void PopulateMenu(string sql = "select *from Cart")
		{
			var ds = this.Da.ExecuteQuery(sql);
			this.dgvbill.DataSource = ds.Tables[0];
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
				MessageBox.Show("Plaese provide Trade number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				MessageBox.Show("Succesfully reported", "Reported", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Alllogin home = new Alllogin();
			home.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bill_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Buyermenu buyermenu=new Buyermenu();
			buyermenu.Show();
			this.Hide();
		}
	}
}
