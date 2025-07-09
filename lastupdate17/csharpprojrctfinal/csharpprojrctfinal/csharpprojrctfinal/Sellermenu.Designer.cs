namespace csharpprojrctfinal
{
	partial class Sellermenu
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
			textBox3 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			textBox2 = new TextBox();
			label1 = new Label();
			textBox1 = new TextBox();
			button4 = new Button();
			dgvseller = new DataGridView();
			textBox4 = new TextBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvseller).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(192, 0, 192);
			button1.Location = new Point(12, 409);
			button1.Name = "button1";
			button1.Size = new Size(119, 29);
			button1.TabIndex = 1;
			button1.Text = "Log Out ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.Lime;
			button2.Location = new Point(436, 409);
			button2.Name = "button2";
			button2.Size = new Size(107, 29);
			button2.TabIndex = 2;
			button2.Text = "ADD PRODUCT";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.Location = new Point(549, 409);
			button3.Name = "button3";
			button3.Size = new Size(111, 29);
			button3.TabIndex = 3;
			button3.Text = "REMOVE PRODUCT";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// textBox3
			// 
			textBox3.AutoCompleteSource = AutoCompleteSource.HistoryList;
			textBox3.BackColor = Color.Lime;
			textBox3.Location = new Point(129, 130);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(121, 27);
			textBox3.TabIndex = 15;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.BorderStyle = BorderStyle.Fixed3D;
			label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Red;
			label3.Location = new Point(3, 188);
			label3.Name = "label3";
			label3.Size = new Size(116, 23);
			label3.TabIndex = 14;
			label3.Text = "Trade Num";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.BorderStyle = BorderStyle.Fixed3D;
			label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(3, 78);
			label2.Name = "label2";
			label2.Size = new Size(128, 28);
			label2.TabIndex = 13;
			label2.Text = "Catagory";
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.Lime;
			textBox2.Location = new Point(114, 78);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(136, 27);
			textBox2.TabIndex = 12;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(10, 30);
			label1.Name = "label1";
			label1.Size = new Size(85, 31);
			label1.TabIndex = 11;
			label1.Text = "Name ";
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.Lime;
			textBox1.ForeColor = SystemColors.ControlText;
			textBox1.Location = new Point(129, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(121, 27);
			textBox1.TabIndex = 10;
			// 
			// button4
			// 
			button4.BackColor = Color.FromArgb(0, 0, 192);
			button4.Location = new Point(666, 409);
			button4.Name = "button4";
			button4.Size = new Size(131, 29);
			button4.TabIndex = 16;
			button4.Text = "Update";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// dgvseller
			// 
			dgvseller.BackgroundColor = Color.FromArgb(0, 192, 192);
			dgvseller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvseller.Location = new Point(288, 21);
			dgvseller.Name = "dgvseller";
			dgvseller.RowHeadersWidth = 51;
			dgvseller.RowTemplate.Height = 29;
			dgvseller.Size = new Size(500, 250);
			dgvseller.TabIndex = 17;
			dgvseller.CellContentClick += dgvseller_CellContentClick;
			// 
			// textBox4
			// 
			textBox4.BackColor = Color.Lime;
			textBox4.Location = new Point(129, 184);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(121, 27);
			textBox4.TabIndex = 18;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.BorderStyle = BorderStyle.Fixed3D;
			label4.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Red;
			label4.Location = new Point(3, 134);
			label4.Name = "label4";
			label4.Size = new Size(109, 25);
			label4.TabIndex = 19;
			label4.Text = "Quantity";
			// 
			// Sellermenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources.MicrosoftTeams_image__1_;
			ClientSize = new Size(800, 450);
			Controls.Add(label4);
			Controls.Add(textBox4);
			Controls.Add(dgvseller);
			Controls.Add(button4);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Sellermenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Sellermenu";
			((System.ComponentModel.ISupportInitialize)dgvseller).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private TextBox textBox3;
		private Label label3;
		private Label label2;
		private TextBox textBox2;
		private Label label1;
		private TextBox textBox1;
		private Button button4;
		private DataGridView dgvseller;
		private TextBox textBox4;
		private Label label4;
	}
}