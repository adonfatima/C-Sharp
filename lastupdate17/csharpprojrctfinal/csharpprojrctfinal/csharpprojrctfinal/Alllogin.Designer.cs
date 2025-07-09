namespace csharpprojrctfinal
{
	partial class Alllogin
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
			button2 = new Button();
			adlog = new Button();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// button2
			// 
			button2.BackColor = Color.Red;
			button2.Location = new Point(12, 409);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 11;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// adlog
			// 
			adlog.BackColor = Color.LawnGreen;
			adlog.Location = new Point(582, 232);
			adlog.Name = "adlog";
			adlog.Size = new Size(94, 29);
			adlog.TabIndex = 10;
			adlog.Text = "Login";
			adlog.UseVisualStyleBackColor = false;
			adlog.Click += adlog_Click;
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.Teal;
			textBox2.Location = new Point(424, 187);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '*';
			textBox2.Size = new Size(252, 27);
			textBox2.TabIndex = 9;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.Teal;
			textBox1.Location = new Point(424, 130);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(252, 27);
			textBox1.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.BorderStyle = BorderStyle.Fixed3D;
			label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(234, 183);
			label2.Name = "label2";
			label2.Size = new Size(150, 31);
			label2.TabIndex = 7;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(244, 130);
			label1.Name = "label1";
			label1.Size = new Size(140, 31);
			label1.TabIndex = 6;
			label1.Text = "Username";
			// 
			// button1
			// 
			button1.BackColor = Color.Blue;
			button1.Location = new Point(457, 232);
			button1.Margin = new Padding(2);
			button1.Name = "button1";
			button1.Size = new Size(92, 29);
			button1.TabIndex = 12;
			button1.Text = "Register";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Alllogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources.MicrosoftTeams_image__6_;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(button2);
			Controls.Add(adlog);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Alllogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Alllogin";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button adlog;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
		private Button button1;
	}
}