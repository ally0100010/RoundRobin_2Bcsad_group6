namespace Group6
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.form2_compute_btn = new System.Windows.Forms.Button();
			this.form2_view_btn = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(312, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "MAIN MENU";
			// 
			// form2_compute_btn
			// 
			this.form2_compute_btn.BackgroundImage = global::Group6.Properties.Resources.auto1;
			this.form2_compute_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.form2_compute_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.form2_compute_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.form2_compute_btn.ForeColor = System.Drawing.Color.Gainsboro;
			this.form2_compute_btn.Location = new System.Drawing.Point(318, 176);
			this.form2_compute_btn.Name = "form2_compute_btn";
			this.form2_compute_btn.Size = new System.Drawing.Size(174, 34);
			this.form2_compute_btn.TabIndex = 1;
			this.form2_compute_btn.Text = "SINGLE QUEUE";
			this.form2_compute_btn.UseVisualStyleBackColor = true;
			this.form2_compute_btn.Click += new System.EventHandler(this.form2_compute_btn_Click);
			// 
			// form2_view_btn
			// 
			this.form2_view_btn.BackgroundImage = global::Group6.Properties.Resources.auto1;
			this.form2_view_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.form2_view_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.form2_view_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.form2_view_btn.ForeColor = System.Drawing.Color.LightGray;
			this.form2_view_btn.Location = new System.Drawing.Point(318, 216);
			this.form2_view_btn.Name = "form2_view_btn";
			this.form2_view_btn.Size = new System.Drawing.Size(174, 34);
			this.form2_view_btn.TabIndex = 2;
			this.form2_view_btn.Text = "MULTIPLE QUEUE";
			this.form2_view_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.form2_view_btn.UseVisualStyleBackColor = true;
			this.form2_view_btn.Click += new System.EventHandler(this.form2_view_btn_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::Group6.Properties.Resources.auto1;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.LightGray;
			this.button3.Location = new System.Drawing.Point(357, 256);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 34);
			this.button3.TabIndex = 3;
			this.button3.Text = "EXIT";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Group6.Properties.Resources.auto3;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(534, 331);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.form2_view_btn);
			this.Controls.Add(this.form2_compute_btn);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ROUND ROBIN CPU SCHEDULING";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button form2_compute_btn;
		private System.Windows.Forms.Button form2_view_btn;
		private System.Windows.Forms.Button button3;
	}
}