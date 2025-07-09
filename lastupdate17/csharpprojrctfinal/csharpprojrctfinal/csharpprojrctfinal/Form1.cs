namespace csharpprojrctfinal
{
	public partial class home : Form
	{
		public home()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Alllogin option = new Alllogin();
			option.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}