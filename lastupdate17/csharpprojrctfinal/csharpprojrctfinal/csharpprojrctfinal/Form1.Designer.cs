namespace csharpprojrctfinal
{
	partial class home
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			label1 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.Lime;
			button1.Location = new Point(630, 401);
			button1.Name = "button1";
			button1.Size = new Size(141, 37);
			button1.TabIndex = 0;
			button1.Text = "NEXT";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(113, 44);
			label1.Name = "label1";
			label1.Size = new Size(539, 37);
			label1.TabIndex = 1;
			label1.Text = "CENTRALIZED PRICING MEGANISM ";
			// 
			// button2
			// 
			button2.BackColor = Color.Red;
			button2.Location = new Point(12, 401);
			button2.Name = "button2";
			button2.Size = new Size(141, 37);
			button2.TabIndex = 2;
			button2.Text = "EXIT";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// home
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources.o;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "home";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "HOME PAGE";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private Button button2;
	}
}