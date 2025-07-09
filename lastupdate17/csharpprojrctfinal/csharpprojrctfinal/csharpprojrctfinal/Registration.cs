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

	public partial class Registration : Form
	{
		private DataAccess Da { get; set; }

		private string role;
		public Registration()
		{
			InitializeComponent();
			this.Da = new DataAccess();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			role = comboBox1.Text;
			if (role == "Seller")
			{
				sellerreg sellereg = new sellerreg();
				sellereg.Show();
				this.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
			{
				MessageBox.Show("Please provide all the informaiotn.");
			}
			else
			{
				try
				{
					string sql = "Insert into Login values('" + textBox1.Text + "','" + textBox2.Text + "','Buyer')";
					string sql1 = "Insert into BuyerInfo values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
					//var dt = this.Da.ExecuteDMLQuery(sql);
					//int dt1 = this.Da.ExecuteDMLQuery(sql1);
					int count = this.Da.ExecuteDMLQuery(sql);
					int count1 = this.Da.ExecuteDMLQuery(sql1);

					if (count == 1)
						MessageBox.Show("Registrantion succesfull");
					else
						MessageBox.Show("Failed");
					//MessageBox.Show("Registrantion", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.textBox1.Clear();
					this.textBox2.Clear();
					this.textBox3.Clear();
					this.textBox4.Clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error " + ex.Message);
				}
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Alllogin alllogin = new Alllogin();
			alllogin.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
