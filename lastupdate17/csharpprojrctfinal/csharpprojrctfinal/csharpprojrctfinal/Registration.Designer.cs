namespace csharpprojrctfinal
{
	partial class Registration
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
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			comboBox1 = new ComboBox();
			textBox4 = new TextBox();
			label4 = new Label();
			button3 = new Button();
			SuspendLayout();
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.Cyan;
			textBox3.Location = new Point(414, 154);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(402, 27);
			textBox3.TabIndex = 26;
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.Cyan;
			textBox2.Location = new Point(414, 84);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(402, 27);
			textBox2.TabIndex = 25;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.Cyan;
			textBox1.ForeColor = Color.Black;
			textBox1.Location = new Point(414, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(402, 27);
			textBox1.TabIndex = 24;
			// 
			// button2
			// 
			button2.BackColor = Color.Lime;
			button2.Location = new Point(630, 280);
			button2.Name = "button2";
			button2.Size = new Size(186, 29);
			button2.TabIndex = 23;
			button2.Text = "Confrim Register ";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.DarkOrange;
			button1.Location = new Point(108, 444);
			button1.Name = "button1";
			button1.Size = new Size(94, 33);
			button1.TabIndex = 22;
			button1.Text = "Back";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.BorderStyle = BorderStyle.Fixed3D;
			label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Red;
			label3.Location = new Point(266, 216);
			label3.Name = "label3";
			label3.Size = new Size(104, 37);
			label3.TabIndex = 21;
			label3.Text = "Email";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.BorderStyle = BorderStyle.Fixed3D;
			label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(242, 91);
			label2.Name = "label2";
			label2.Size = new Size(150, 31);
			label2.TabIndex = 20;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(242, 19);
			label1.Name = "label1";
			label1.Size = new Size(140, 31);
			label1.TabIndex = 19;
			label1.Text = "username";
			label1.Click += label1_Click;
			// 
			// comboBox1
			// 
			comboBox1.BackColor = Color.Cyan;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Buyer", "Seller" });
			comboBox1.Location = new Point(414, 281);
			comboBox1.Margin = new Padding(2);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(150, 28);
			comboBox1.TabIndex = 27;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// textBox4
			// 
			textBox4.BackColor = Color.Cyan;
			textBox4.Location = new Point(414, 216);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(402, 27);
			textBox4.TabIndex = 28;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.BorderStyle = BorderStyle.Fixed3D;
			label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Red;
			label4.Location = new Point(266, 154);
			label4.Name = "label4";
			label4.Size = new Size(79, 31);
			label4.TabIndex = 29;
			label4.Text = "Name";
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.Location = new Point(12, 444);
			button3.Name = "button3";
			button3.Size = new Size(72, 33);
			button3.TabIndex = 30;
			button3.Text = "EXIT";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources.MicrosoftTeams_image__6_;
			ClientSize = new Size(882, 493);
			Controls.Add(button3);
			Controls.Add(label4);
			Controls.Add(textBox4);
			Controls.Add(comboBox1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(2);
			Name = "Registration";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registration";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Button button2;
		private Button button1;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox comboBox1;
		private TextBox textBox4;
		private Label label4;
		private Button button3;
	}
}