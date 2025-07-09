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
	public partial class adsellview : Form
	{
		private DataAccess Da { get; set; }
		public adsellview()
		{
			InitializeComponent();
			this.Da = new DataAccess();
			this.PopulateMenu();
		}
		private void PopulateMenu(string sql = "select *from sellertab")
		{
			var ds = this.Da.ExecuteQuery(sql);
			this.dgvads.DataSource = ds.Tables[0];
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Adminmenu sellermenu = new Adminmenu();
			sellermenu.Show(this);
			this.Hide();
		}

		private void dgvads_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
