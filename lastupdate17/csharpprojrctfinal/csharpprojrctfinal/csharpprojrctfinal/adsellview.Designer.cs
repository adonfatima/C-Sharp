namespace csharpprojrctfinal
{
	partial class adsellview
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
			dgvads = new DataGridView();
			button1 = new Button();
			label1 = new Label();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvads).BeginInit();
			SuspendLayout();
			// 
			// dgvads
			// 
			dgvads.BackgroundColor = Color.Cyan;
			dgvads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvads.Location = new Point(138, 103);
			dgvads.Name = "dgvads";
			dgvads.RowHeadersWidth = 51;
			dgvads.RowTemplate.Height = 29;
			dgvads.Size = new Size(570, 226);
			dgvads.TabIndex = 0;
			dgvads.CellContentClick += dgvads_CellContentClick;
			// 
			// button1
			// 
			button1.BackColor = Color.Red;
			button1.Location = new Point(12, 409);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 1;
			button1.Text = "Back";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AccessibleRole = AccessibleRole.None;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.Blue;
			label1.Location = new Point(138, 34);
			label1.Name = "label1";
			label1.Size = new Size(553, 43);
			label1.TabIndex = 2;
			label1.Text = "SELLER UPDATE PRODUCT LIST ";
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(255, 128, 0);
			button2.Location = new Point(123, 409);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 3;
			button2.Text = "Exit";
			button2.UseVisualStyleBackColor = false;
			// 
			// adsellview
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightSteelBlue;
			BackgroundImage = Properties.Resources.MicrosoftTeams_image__3_;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(dgvads);
			Name = "adsellview";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "adsellview";
			((System.ComponentModel.ISupportInitialize)dgvads).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvads;
		private Button button1;
		private Label label1;
		private Button button2;
	}
}