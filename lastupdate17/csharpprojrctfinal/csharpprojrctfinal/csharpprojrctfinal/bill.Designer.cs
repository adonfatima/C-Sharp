namespace csharpprojrctfinal
{
	partial class bill
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
			dgvbill = new DataGridView();
			label1 = new Label();
			button1 = new Button();
			label2 = new Label();
			textBox1 = new TextBox();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvbill).BeginInit();
			SuspendLayout();
			// 
			// dgvbill
			// 
			dgvbill.BackgroundColor = Color.Teal;
			dgvbill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvbill.GridColor = Color.LightYellow;
			dgvbill.Location = new Point(120, 72);
			dgvbill.Name = "dgvbill";
			dgvbill.RowHeadersWidth = 51;
			dgvbill.RowTemplate.Height = 29;
			dgvbill.Size = new Size(615, 188);
			dgvbill.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(248, 23);
			label1.Name = "label1";
			label1.Size = new Size(354, 46);
			label1.TabIndex = 1;
			label1.Text = "SHOPING LIST ";
			// 
			// button1
			// 
			button1.BackColor = Color.Lime;
			button1.Location = new Point(694, 409);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "Report";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.BorderStyle = BorderStyle.Fixed3D;
			label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(120, 288);
			label2.Name = "label2";
			label2.Size = new Size(458, 31);
			label2.TabIndex = 3;
			label2.Text = "Enter Trade Number For Repoert ";
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.Red;
			textBox1.Location = new Point(581, 288);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(207, 27);
			textBox1.TabIndex = 4;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// button2
			// 
			button2.BackColor = Color.Red;
			button2.Location = new Point(12, 409);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 5;
			button2.Text = "Log out ";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(192, 0, 192);
			button3.Location = new Point(120, 409);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 6;
			button3.Text = "EXIT";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.BackColor = Color.FromArgb(255, 128, 0);
			button4.Location = new Point(234, 409);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 7;
			button4.Text = "Back";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// bill
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources.MicrosoftTeams_image__2_;
			ClientSize = new Size(800, 450);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(dgvbill);
			Name = "bill";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "bill";
			Load += bill_Load;
			((System.ComponentModel.ISupportInitialize)dgvbill).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvbill;
		private Label label1;
		private Button button1;
		private Label label2;
		private TextBox textBox1;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}