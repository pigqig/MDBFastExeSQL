namespace MDBFastExeSQL
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnOpenSql = new System.Windows.Forms.Button();
            this.btnOpendATA = new System.Windows.Forms.Button();
            this.txtSqlPath = new System.Windows.Forms.TextBox();
            this.txtMdbSource = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExecute);
            this.groupBox1.Controls.Add(this.btnOpenSql);
            this.groupBox1.Controls.Add(this.btnOpendATA);
            this.groupBox1.Controls.Add(this.txtSqlPath);
            this.groupBox1.Controls.Add(this.txtMdbSource);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(600, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "來源";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExecute.Location = new System.Drawing.Point(457, 115);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(139, 54);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "確定執行";
            this.btnExecute.UseVisualStyleBackColor = false;
            // 
            // btnOpenSql
            // 
            this.btnOpenSql.Location = new System.Drawing.Point(344, 81);
            this.btnOpenSql.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenSql.Name = "btnOpenSql";
            this.btnOpenSql.Size = new System.Drawing.Size(98, 18);
            this.btnOpenSql.TabIndex = 1;
            this.btnOpenSql.Text = "選擇SQL檔";
            this.btnOpenSql.UseVisualStyleBackColor = true;
            // 
            // btnOpendATA
            // 
            this.btnOpendATA.Location = new System.Drawing.Point(344, 29);
            this.btnOpendATA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpendATA.Name = "btnOpendATA";
            this.btnOpendATA.Size = new System.Drawing.Size(98, 18);
            this.btnOpendATA.TabIndex = 1;
            this.btnOpendATA.Text = "選擇MDB";
            this.btnOpendATA.UseVisualStyleBackColor = true;
            // 
            // txtSqlPath
            // 
            this.txtSqlPath.Location = new System.Drawing.Point(124, 79);
            this.txtSqlPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSqlPath.Name = "txtSqlPath";
            this.txtSqlPath.Size = new System.Drawing.Size(194, 22);
            this.txtSqlPath.TabIndex = 0;
            // 
            // txtMdbSource
            // 
            this.txtMdbSource.Location = new System.Drawing.Point(124, 27);
            this.txtMdbSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMdbSource.Name = "txtMdbSource";
            this.txtMdbSource.Size = new System.Drawing.Size(194, 22);
            this.txtMdbSource.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 170);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(600, 190);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MDB本文SQL快速執行器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.Button btnOpenSql;
		private System.Windows.Forms.Button btnOpendATA;
		private System.Windows.Forms.TextBox txtSqlPath;
		private System.Windows.Forms.TextBox txtMdbSource;
		private System.Windows.Forms.RichTextBox txtMessage;
	}
}

