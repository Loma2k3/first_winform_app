namespace WinFormsApp1.control
{
	partial class CartControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			CartView = new DataGridView();
			OrderView = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)CartView).BeginInit();
			((System.ComponentModel.ISupportInitialize)OrderView).BeginInit();
			SuspendLayout();
			// 
			// CartView
			// 
			CartView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			CartView.Location = new Point(35, 51);
			CartView.Name = "CartView";
			CartView.RowHeadersWidth = 51;
			CartView.RowTemplate.Height = 29;
			CartView.Size = new Size(216, 231);
			CartView.TabIndex = 0;
			// 
			// OrderView
			// 
			OrderView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			OrderView.Location = new Point(273, 51);
			OrderView.Name = "OrderView";
			OrderView.RowHeadersWidth = 51;
			OrderView.RowTemplate.Height = 29;
			OrderView.Size = new Size(323, 288);
			OrderView.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(35, 10);
			label1.Name = "label1";
			label1.Size = new Size(70, 38);
			label1.TabIndex = 2;
			label1.Text = "Cart";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(273, 10);
			label2.Name = "label2";
			label2.Size = new Size(90, 38);
			label2.TabIndex = 3;
			label2.Text = "Order";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(140, 311);
			label3.Name = "label3";
			label3.Size = new Size(34, 28);
			label3.TabIndex = 4;
			label3.Text = "0$";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(232, 79, 46);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = SystemColors.ControlLightLight;
			button1.Location = new Point(35, 307);
			button1.Name = "button1";
			button1.Size = new Size(99, 37);
			button1.TabIndex = 5;
			button1.Text = "Buy";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// CartControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(OrderView);
			Controls.Add(CartView);
			Name = "CartControl";
			Size = new Size(629, 375);
			((System.ComponentModel.ISupportInitialize)CartView).EndInit();
			((System.ComponentModel.ISupportInitialize)OrderView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView CartView;
		private DataGridView OrderView;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
	}
}
