namespace csharpprojrctfinal
{
	partial class Buyermenu
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
			button1 = new Button();
			button5 = new Button();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			txtQnty = new NumericUpDown();
			dataGridView2 = new DataGridView();
			textBox2 = new TextBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtQnty).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 192, 0);
			button2.Location = new Point(523, 412);
			button2.Name = "button2";
			button2.Size = new Size(103, 29);
			button2.TabIndex = 4;
			button2.Text = "Add Item";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.Red;
			button1.Location = new Point(12, 412);
			button1.Name = "button1";
			button1.Size = new Size(100, 29);
			button1.TabIndex = 7;
			button1.Text = "Log out ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button5
			// 
			button5.BackColor = SystemColors.MenuHighlight;
			button5.Location = new Point(643, 410);
			button5.Name = "button5";
			button5.Size = new Size(131, 31);
			button5.TabIndex = 8;
			button5.Text = "Pay Bill";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(330, 42);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(458, 113);
			dataGridView1.TabIndex = 9;
			dataGridView1.DoubleClick += button2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Blue;
			label1.Location = new Point(414, 1);
			label1.Name = "label1";
			label1.Size = new Size(317, 35);
			label1.TabIndex = 10;
			label1.Text = "Available Product";
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.SpringGreen;
			textBox1.Location = new Point(202, 42);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(102, 27);
			textBox1.TabIndex = 12;
			textBox1.TextChanged += txt_Search;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.BorderStyle = BorderStyle.Fixed3D;
			label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(2, 39);
			label2.Name = "label2";
			label2.Size = new Size(179, 28);
			label2.TabIndex = 14;
			label2.Text = "Product Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.BorderStyle = BorderStyle.Fixed3D;
			label3.FlatStyle = FlatStyle.Flat;
			label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(2, 83);
			label3.Name = "label3";
			label3.Size = new Size(123, 28);
			label3.TabIndex = 15;
			label3.Text = "Quantity";
			// 
			// txtQnty
			// 
			txtQnty.BackColor = Color.SpringGreen;
			txtQnty.Location = new Point(202, 84);
			txtQnty.Margin = new Padding(2);
			txtQnty.Name = "txtQnty";
			txtQnty.Size = new Size(102, 27);
			txtQnty.TabIndex = 16;
			txtQnty.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// dataGridView2
			// 
			dataGridView2.BackgroundColor = Color.FromArgb(0, 192, 192);
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(287, 186);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowHeadersWidth = 51;
			dataGridView2.RowTemplate.Height = 29;
			dataGridView2.Size = new Size(501, 154);
			dataGridView2.TabIndex = 17;
			dataGridView2.CellContentClick += dataGridView2_CellContentClick;
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.ActiveCaption;
			textBox2.Location = new Point(649, 358);
			textBox2.Margin = new Padding(2);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 18;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.BorderStyle = BorderStyle.Fixed3D;
			label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(492, 358);
			label4.Name = "label4";
			label4.Size = new Size(134, 28);
			label4.TabIndex = 19;
			label4.Text = "Total Bill";
			// 
			// Buyermenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Lime;
			BackgroundImage = Properties.Resources.MicrosoftTeams_image;
			ClientSize = new Size(800, 450);
			Controls.Add(label4);
			Controls.Add(textBox2);
			Controls.Add(dataGridView2);
			Controls.Add(txtQnty);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Controls.Add(button5);
			Controls.Add(button1);
			Controls.Add(button2);
			Name = "Buyermenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Buyermenu";
			Load += Buyermenu_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)txtQnty).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button button2;
		private Button button1;
		private Button button5;
		private DataGridView dataGridView1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private NumericUpDown txtQnty;
		private DataGridView dataGridView2;
		private TextBox textBox2;
		private Label label4;
	}
}