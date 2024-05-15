namespace Animal_Shelter
{
	partial class Form1
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
			dataGridView1 = new DataGridView();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			label2 = new Label();
			button6 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 138);
			button1.Name = "button1";
			button1.Size = new Size(122, 40);
			button1.TabIndex = 0;
			button1.Text = "Hayvanları Getir";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(288, 9);
			label1.Name = "label1";
			label1.Size = new Size(177, 32);
			label1.TabIndex = 1;
			label1.Text = "Animal Shelter ";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 244);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(776, 284);
			dataGridView1.TabIndex = 2;
			// 
			// button2
			// 
			button2.Location = new Point(12, 184);
			button2.Name = "button2";
			button2.Size = new Size(122, 42);
			button2.TabIndex = 3;
			button2.Text = "Çalışanları Getir";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(140, 138);
			button3.Name = "button3";
			button3.Size = new Size(122, 40);
			button3.TabIndex = 4;
			button3.Text = "Sağlık Kayıtlarını Getir";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(627, 31);
			button4.Name = "button4";
			button4.Size = new Size(78, 31);
			button4.TabIndex = 5;
			button4.Text = "Open Conn";
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(711, 31);
			button5.Name = "button5";
			button5.Size = new Size(77, 31);
			button5.TabIndex = 6;
			button5.Text = "Close Conn";
			button5.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(627, 9);
			label2.Name = "label2";
			label2.Size = new Size(108, 19);
			label2.TabIndex = 7;
			label2.Text = "Database Status";
			// 
			// button6
			// 
			button6.Location = new Point(140, 184);
			button6.Name = "button6";
			button6.Size = new Size(122, 42);
			button6.TabIndex = 8;
			button6.Text = "Sahiplendirilen Hayvanlar";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 540);
			Controls.Add(button6);
			Controls.Add(label2);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(dataGridView1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private DataGridView dataGridView1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Label label2;
		private Button button6;
	}
}