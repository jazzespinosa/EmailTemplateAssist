namespace Email_Assist_Tool
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTemplate = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.cboxSubTemplate = new System.Windows.Forms.ComboBox();
            this.labelSubTemplate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application:";
            // 
            // cbxTemplate
            // 
            this.cbxTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTemplate.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cbxTemplate.FormattingEnabled = true;
            this.cbxTemplate.Location = new System.Drawing.Point(95, 54);
            this.cbxTemplate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTemplate.Name = "cbxTemplate";
            this.cbxTemplate.Size = new System.Drawing.Size(217, 23);
            this.cbxTemplate.TabIndex = 1;
            this.cbxTemplate.SelectedValueChanged += new System.EventHandler(this.cbxTemplate_SelectedValueChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSend.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSend.Location = new System.Drawing.Point(112, 130);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUsername.BackColor = System.Drawing.Color.White;
            this.tbxUsername.Enabled = false;
            this.tbxUsername.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tbxUsername.Location = new System.Drawing.Point(12, 12);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ReadOnly = true;
            this.tbxUsername.Size = new System.Drawing.Size(300, 23);
            this.tbxUsername.TabIndex = 3;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxSubTemplate
            // 
            this.cboxSubTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSubTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSubTemplate.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cboxSubTemplate.FormattingEnabled = true;
            this.cboxSubTemplate.Location = new System.Drawing.Point(95, 89);
            this.cboxSubTemplate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxSubTemplate.Name = "cboxSubTemplate";
            this.cboxSubTemplate.Size = new System.Drawing.Size(217, 23);
            this.cboxSubTemplate.TabIndex = 4;
            this.cboxSubTemplate.Visible = false;
            this.cboxSubTemplate.VisibleChanged += new System.EventHandler(this.cboxSubTemplate_VisibleChanged);
            // 
            // label2
            // 
            this.labelSubTemplate.AutoSize = true;
            this.labelSubTemplate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelSubTemplate.ForeColor = System.Drawing.Color.White;
            this.labelSubTemplate.Location = new System.Drawing.Point(8, 89);
            this.labelSubTemplate.Name = "label2";
            this.labelSubTemplate.Size = new System.Drawing.Size(76, 19);
            this.labelSubTemplate.TabIndex = 5;
            this.labelSubTemplate.Text = "Template:";
            this.labelSubTemplate.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(324, 176);
            this.Controls.Add(this.labelSubTemplate);
            this.Controls.Add(this.cboxSubTemplate);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbxTemplate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Emailing Template Assistant";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTemplate;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.ComboBox cboxSubTemplate;
        private System.Windows.Forms.Label labelSubTemplate;
    }
}
