namespace Group6
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.form1_start_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(60, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(375, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "ROUND ROBIN CPU";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LightGray;
			this.label2.Location = new System.Drawing.Point(116, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(262, 45);
			this.label2.TabIndex = 1;
			this.label2.Text = "SCHEDULING";
			// 
			// form1_start_btn
			// 
			this.form1_start_btn.BackColor = System.Drawing.Color.MidnightBlue;
			this.form1_start_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("form1_start_btn.BackgroundImage")));
			this.form1_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.form1_start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.form1_start_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.form1_start_btn.ForeColor = System.Drawing.Color.Transparent;
			this.form1_start_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.form1_start_btn.Location = new System.Drawing.Point(211, 257);
			this.form1_start_btn.Name = "form1_start_btn";
			this.form1_start_btn.Size = new System.Drawing.Size(61, 61);
			this.form1_start_btn.TabIndex = 2;
			this.form1_start_btn.UseVisualStyleBackColor = false;
			this.form1_start_btn.Click += new System.EventHandler(this.form1_start_btn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Group6.Properties.Resources.auto;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.form1_start_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button form1_start_btn;
	}
}

