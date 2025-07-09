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
	public partial class Alllogin : Form
	{

		private DataAccess Da { get; set; }
		public Alllogin()
		{
			InitializeComponent();
			this.Da = new DataAccess();
		}

		private void adlog_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("Please provide Both username And password.");
			}
			else
			{
				try
				{
					string sql = "select * from Login where UserName = '" + this.textBox1.Text + "' and Password = '" + this.textBox2.Text + "'";
					var dt = this.Da.ExecuteQuery(sql);
					if (dt.Tables[0].Rows.Count == 1)
					{
						if (dt.Tables[0].Rows[0][2].ToString().Equals("Admin                                                                                               "))
						{
							Adminmenu admin = new Adminmenu();
							admin.Visible = true;
							this.Visible = false;
						}
						else if (dt.Tables[0].Rows[0][2].ToString().Equals("Buyer                                                                                               "))
						{
							Buyermenu Buyer = new Buyermenu();
							Buyer.Visible = true;
							this.Visible = false;
						}
						else
						{
							Sellermenu Seller = new Sellermenu();
							Seller.Visible = true;
							this.Visible = false;

						}
					}
					else
					{
						MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.textBox1.Clear();
						this.textBox2.Clear();

						//this.txtUserID.Focus();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error " + ex.Message);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Registration registration = new Registration();
			registration.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			home home = new home();
			home.Show();
			this.Hide();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
