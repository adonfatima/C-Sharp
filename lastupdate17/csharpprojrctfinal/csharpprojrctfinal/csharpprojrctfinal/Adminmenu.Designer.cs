namespace csharpprojrctfinal
{
	partial class Adminmenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			textBox3 = new TextBox();
			dgvadmin = new DataGridView();
			button5 = new Button();
			label4 = new Label();
			button6 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvadmin).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(192, 0, 192);
			button1.Location = new Point(123, 413);
			button1.Name = "button1";
			button1.Size = new Size(118, 33);
			button1.TabIndex = 0;
			button1.Text = "Log out ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 192, 0);
			button2.Location = new Point(258, 413);
			button2.Name = "button2";
			button2.Size = new Size(131, 33);
			button2.TabIndex = 1;
			button2.Text = "Insert";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.Location = new Point(395, 413);
			button3.Name = "button3";
			button3.Size = new Size(131, 33);
			button3.TabIndex = 2;
			button3.Text = "DELETE";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.BackColor = Color.Blue;
			button4.Location = new Point(532, 413);
			button4.Name = "button4";
			button4.Size = new Size(131, 33);
			button4.TabIndex = 3;
			button4.Text = "Update";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.FromArgb(255, 128, 255);
			textBox1.Location = new Point(152, 66);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(45, 66);
			label1.Name = "label1";
			label1.Size = new Size(85, 31);
			label1.TabIndex = 5;
			label1.Text = "Name ";
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.FromArgb(255, 128, 255);
			textBox2.Location = new Point(152, 116);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 6;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.BorderStyle = BorderStyle.Fixed3D;
			label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(12, 116);
			label2.Name = "label2";
			label2.Size = new Size(128, 28);
			label2.TabIndex = 7;
			label2.Text = "Catagory";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.BorderStyle = BorderStyle.Fixed3D;
			label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(44, 173);
			label3.Name = "label3";
			label3.Size = new Size(86, 31);
			label3.TabIndex = 8;
			label3.Text = "Price";
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.FromArgb(255, 128, 255);
			textBox3.Location = new Point(152, 179);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 27);
			textBox3.TabIndex = 9;
			// 
			// dgvadmin
			// 
			dgvadmin.BackgroundColor = Color.Cyan;
			dgvadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvadmin.Location = new Point(318, 66);
			dgvadmin.Name = "dgvadmin";
			dgvadmin.RowHeadersWidth = 51;
			dgvadmin.RowTemplate.Height = 29;
			dgvadmin.Size = new Size(445, 235);
			dgvadmin.TabIndex = 10;
			dgvadmin.CellContentClick += dataGridView1_CellContentClick;
			// 
			// button5
			// 
			button5.BackColor = Color.Yellow;
			button5.Location = new Point(669, 413);
			button5.Name = "button5";
			button5.Size = new Size(131, 33);
			button5.TabIndex = 11;
			button5.Text = "View Seller Update";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.DarkOrchid;
			label4.Location = new Point(423, 10);
			label4.Name = "label4";
			label4.Size = new Size(217, 35);
			label4.TabIndex = 12;
			label4.Text = "PRODUCT LIST ";
			// 
			// button6
			// 
			button6.BackColor = Color.Red;
			button6.Location = new Point(12, 413);
			button6.Name = "button6";
			button6.Size = new Size(105, 33);
			button6.TabIndex = 13;
			button6.Text = "EXIT";
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click;
			// 
			// Adminmenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources.MicrosoftTeams_image__7_;
			ClientSize = new Size(800, 451);
			Controls.Add(button6);
			Controls.Add(label4);
			Controls.Add(button5);
			Controls.Add(dgvadmin);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Adminmenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Adminmenu";
			((System.ComponentModel.ISupportInitialize)dgvadmin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private TextBox textBox1;
		private Label label1;
		private TextBox textBox2;
		private Label label2;
		private Label label3;
		private TextBox textBox3;
		private DataGridView dgvadmin;
		private Button button5;
		private Label label4;
		private Button button6;
	}
}