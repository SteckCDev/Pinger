namespace Pinger
{
	partial class MainForm
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
			this.lab_status = new System.Windows.Forms.Label();
			this.pct_status = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pct_status)).BeginInit();
			this.SuspendLayout();
			// 
			// lab_status
			// 
			this.lab_status.AutoSize = true;
			this.lab_status.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lab_status.Location = new System.Drawing.Point(3, 2);
			this.lab_status.Name = "lab_status";
			this.lab_status.Size = new System.Drawing.Size(39, 15);
			this.lab_status.TabIndex = 15;
			this.lab_status.Text = "Status";
			this.lab_status.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// pct_status
			// 
			this.pct_status.BackColor = System.Drawing.Color.Red;
			this.pct_status.Location = new System.Drawing.Point(0, 20);
			this.pct_status.Name = "pct_status";
			this.pct_status.Size = new System.Drawing.Size(220, 20);
			this.pct_status.TabIndex = 14;
			this.pct_status.TabStop = false;
			this.pct_status.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(220, 40);
			this.Controls.Add(this.lab_status);
			this.Controls.Add(this.pct_status);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pct_status)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lab_status;
		private System.Windows.Forms.PictureBox pct_status;
	}
}