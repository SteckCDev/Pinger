namespace Pinger
{
	partial class SettingForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.lab_ip = new System.Windows.Forms.Label();
			this.var_ip = new System.Windows.Forms.TextBox();
			this.btn_check = new System.Windows.Forms.Button();
			this.btn_start = new System.Windows.Forms.Button();
			this.lab_dif = new System.Windows.Forms.Label();
			this.var_dif = new System.Windows.Forms.TextBox();
			this.lab_avg = new System.Windows.Forms.Label();
			this.var_avg = new System.Windows.Forms.TextBox();
			this.lab_max = new System.Windows.Forms.Label();
			this.var_max = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lab_ip
			// 
			this.lab_ip.AutoSize = true;
			this.lab_ip.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lab_ip.Location = new System.Drawing.Point(87, 127);
			this.lab_ip.Name = "lab_ip";
			this.lab_ip.Size = new System.Drawing.Size(86, 21);
			this.lab_ip.TabIndex = 33;
			this.lab_ip.Text = "IP Address:";
			// 
			// var_ip
			// 
			this.var_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.var_ip.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.var_ip.Location = new System.Drawing.Point(36, 151);
			this.var_ip.Name = "var_ip";
			this.var_ip.Size = new System.Drawing.Size(181, 23);
			this.var_ip.TabIndex = 27;
			this.var_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.var_ip.TextChanged += new System.EventHandler(this.Var_TextChanged);
			// 
			// btn_check
			// 
			this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_check.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_check.Location = new System.Drawing.Point(17, 186);
			this.btn_check.Name = "btn_check";
			this.btn_check.Size = new System.Drawing.Size(92, 34);
			this.btn_check.TabIndex = 28;
			this.btn_check.Text = "CHECK";
			this.btn_check.UseVisualStyleBackColor = true;
			this.btn_check.Click += new System.EventHandler(this.Btn_check_Click);
			// 
			// btn_start
			// 
			this.btn_start.Enabled = false;
			this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_start.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_start.Location = new System.Drawing.Point(107, 186);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(137, 34);
			this.btn_start.TabIndex = 29;
			this.btn_start.Text = "START";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
			// 
			// lab_dif
			// 
			this.lab_dif.AutoSize = true;
			this.lab_dif.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lab_dif.Location = new System.Drawing.Point(32, 100);
			this.lab_dif.Name = "lab_dif";
			this.lab_dif.Size = new System.Drawing.Size(78, 21);
			this.lab_dif.TabIndex = 32;
			this.lab_dif.Text = "Avg - Min";
			// 
			// var_dif
			// 
			this.var_dif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.var_dif.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.var_dif.Location = new System.Drawing.Point(117, 99);
			this.var_dif.Name = "var_dif";
			this.var_dif.Size = new System.Drawing.Size(100, 23);
			this.var_dif.TabIndex = 26;
			this.var_dif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.var_dif.TextChanged += new System.EventHandler(this.Var_TextChanged);
			// 
			// lab_avg
			// 
			this.lab_avg.AutoSize = true;
			this.lab_avg.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lab_avg.Location = new System.Drawing.Point(32, 62);
			this.lab_avg.Name = "lab_avg";
			this.lab_avg.Size = new System.Drawing.Size(67, 21);
			this.lab_avg.TabIndex = 31;
			this.lab_avg.Text = "Average";
			// 
			// var_avg
			// 
			this.var_avg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.var_avg.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.var_avg.Location = new System.Drawing.Point(117, 61);
			this.var_avg.Name = "var_avg";
			this.var_avg.Size = new System.Drawing.Size(100, 23);
			this.var_avg.TabIndex = 25;
			this.var_avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.var_avg.TextChanged += new System.EventHandler(this.Var_TextChanged);
			// 
			// lab_max
			// 
			this.lab_max.AutoSize = true;
			this.lab_max.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lab_max.Location = new System.Drawing.Point(32, 21);
			this.lab_max.Name = "lab_max";
			this.lab_max.Size = new System.Drawing.Size(80, 21);
			this.lab_max.TabIndex = 30;
			this.lab_max.Text = "Maximum";
			// 
			// var_max
			// 
			this.var_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.var_max.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.var_max.Location = new System.Drawing.Point(117, 21);
			this.var_max.Name = "var_max";
			this.var_max.Size = new System.Drawing.Size(100, 23);
			this.var_max.TabIndex = 24;
			this.var_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.var_max.TextChanged += new System.EventHandler(this.Var_TextChanged);
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 240);
			this.Controls.Add(this.lab_ip);
			this.Controls.Add(this.var_ip);
			this.Controls.Add(this.btn_check);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.lab_dif);
			this.Controls.Add(this.var_dif);
			this.Controls.Add(this.lab_avg);
			this.Controls.Add(this.var_avg);
			this.Controls.Add(this.lab_max);
			this.Controls.Add(this.var_max);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lab_ip;
		private System.Windows.Forms.TextBox var_ip;
		private System.Windows.Forms.Button btn_check;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Label lab_dif;
		private System.Windows.Forms.TextBox var_dif;
		private System.Windows.Forms.Label lab_avg;
		private System.Windows.Forms.TextBox var_avg;
		private System.Windows.Forms.Label lab_max;
		private System.Windows.Forms.TextBox var_max;
	}
}

