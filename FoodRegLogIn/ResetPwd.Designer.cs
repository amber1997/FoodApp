namespace FoodRegLogIn
{
    partial class ResetPwd
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
            this.btnResetPwd = new System.Windows.Forms.Button();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPwd = new System.Windows.Forms.TextBox();
            this.labNewPed = new System.Windows.Forms.Label();
            this.labConfirmNewPwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.Location = new System.Drawing.Point(374, 458);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(436, 106);
            this.btnResetPwd.TabIndex = 0;
            this.btnResetPwd.Text = "確定重設";
            this.btnResetPwd.UseVisualStyleBackColor = true;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(308, 161);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(613, 36);
            this.txtNewPwd.TabIndex = 1;
            // 
            // txtConfirmNewPwd
            // 
            this.txtConfirmNewPwd.Location = new System.Drawing.Point(308, 322);
            this.txtConfirmNewPwd.Name = "txtConfirmNewPwd";
            this.txtConfirmNewPwd.PasswordChar = '*';
            this.txtConfirmNewPwd.Size = new System.Drawing.Size(613, 36);
            this.txtConfirmNewPwd.TabIndex = 2;
            // 
            // labNewPed
            // 
            this.labNewPed.AutoSize = true;
            this.labNewPed.Location = new System.Drawing.Point(156, 161);
            this.labNewPed.Name = "labNewPed";
            this.labNewPed.Size = new System.Drawing.Size(88, 24);
            this.labNewPed.TabIndex = 3;
            this.labNewPed.Text = "新密碼:";
            // 
            // labConfirmNewPwd
            // 
            this.labConfirmNewPwd.AutoSize = true;
            this.labConfirmNewPwd.Location = new System.Drawing.Point(108, 322);
            this.labConfirmNewPwd.Name = "labConfirmNewPwd";
            this.labConfirmNewPwd.Size = new System.Drawing.Size(136, 24);
            this.labConfirmNewPwd.TabIndex = 4;
            this.labConfirmNewPwd.Text = "確認新密碼:";
            // 
            // ResetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 685);
            this.Controls.Add(this.labConfirmNewPwd);
            this.Controls.Add(this.labNewPed);
            this.Controls.Add(this.txtConfirmNewPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.btnResetPwd);
            this.Name = "ResetPwd";
            this.Text = "重設密碼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtConfirmNewPwd;
        private System.Windows.Forms.Label labNewPed;
        private System.Windows.Forms.Label labConfirmNewPwd;
    }
}