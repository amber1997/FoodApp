namespace FoodRegLogIn
{
    partial class frmConfirmEamil
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
            this.btnConfirmDeleteAcc = new System.Windows.Forms.Button();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.labUserTextEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.labMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmDeleteAcc
            // 
            this.btnConfirmDeleteAcc.Location = new System.Drawing.Point(438, 230);
            this.btnConfirmDeleteAcc.Name = "btnConfirmDeleteAcc";
            this.btnConfirmDeleteAcc.Size = new System.Drawing.Size(265, 57);
            this.btnConfirmDeleteAcc.TabIndex = 0;
            this.btnConfirmDeleteAcc.Text = "刪除帳號";
            this.btnConfirmDeleteAcc.UseVisualStyleBackColor = true;
            this.btnConfirmDeleteAcc.Click += new System.EventHandler(this.btnConfirmAccPwd_Click);
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(281, 62);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(583, 36);
            this.txtAcc.TabIndex = 1;
            // 
            // labUserTextEmail
            // 
            this.labUserTextEmail.AutoSize = true;
            this.labUserTextEmail.Location = new System.Drawing.Point(16, 62);
            this.labUserTextEmail.Name = "labUserTextEmail";
            this.labUserTextEmail.Size = new System.Drawing.Size(226, 24);
            this.labUserTextEmail.TabIndex = 2;
            this.labUserTextEmail.Text = "請輸入您註冊的帳號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "請輸入您註冊的密碼";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(281, 176);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(583, 36);
            this.txtPwd.TabIndex = 4;
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(339, 315);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(0, 24);
            this.labMessage.TabIndex = 5;
            // 
            // frmConfirmEamil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 590);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labUserTextEmail);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.btnConfirmDeleteAcc);
            this.Name = "frmConfirmEamil";
            this.Text = "確認信箱";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmDeleteAcc;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label labUserTextEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label labMessage;
    }
}