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
	public partial class sellerreg : Form
	{
		private DataAccess Da { get; set; }

		private string role;
		public sellerreg()
		{
			this.Da = new DataAccess();
			InitializeComponent();
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
					string sql = "Insert into Login values('" + textBox1.Text + "','" + textBox2.Text + "','Seller')";
					string sql1 = "Insert into SellerInfo values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
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
					this.textBox5.Clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error " + ex.Message);
				}
			}
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Alllogin alllogin = new Alllogin();
			alllogin.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void sellerreg_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
