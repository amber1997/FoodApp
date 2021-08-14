namespace FoodRegLogIn
{
    partial class ForgetPwd
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnVertifyEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVertifyNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVertify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(221, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(636, 36);
            this.txtEmail.TabIndex = 0;
            // 
            // btnVertifyEmail
            // 
            this.btnVertifyEmail.Location = new System.Drawing.Point(221, 296);
            this.btnVertifyEmail.Name = "btnVertifyEmail";
            this.btnVertifyEmail.Size = new System.Drawing.Size(204, 59);
            this.btnVertifyEmail.TabIndex = 1;
            this.btnVertifyEmail.Text = "確認寄送";
            this.btnVertifyEmail.UseVisualStyleBackColor = true;
            this.btnVertifyEmail.Click += new System.EventHandler(this.btnVertifyEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "請輸入你忘記密碼的那組Email:";
            // 
            // txtVertifyNum
            // 
            this.txtVertifyNum.Location = new System.Drawing.Point(221, 516);
            this.txtVertifyNum.Name = "txtVertifyNum";
            this.txtVertifyNum.Size = new System.Drawing.Size(636, 36);
            this.txtVertifyNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "請輸入驗證碼:";
            // 
            // btnVertify
            // 
            this.btnVertify.Location = new System.Drawing.Point(221, 617);
            this.btnVertify.Name = "btnVertify";
            this.btnVertify.Size = new System.Drawing.Size(204, 59);
            this.btnVertify.TabIndex = 5;
            this.btnVertify.Text = "驗證";
            this.btnVertify.UseVisualStyleBackColor = true;
            this.btnVertify.Click += new System.EventHandler(this.btnVertify_Click);
            // 
            // ForgetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 809);
            this.Controls.Add(this.btnVertify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVertifyNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVertifyEmail);
            this.Controls.Add(this.txtEmail);
            this.Name = "ForgetPwd";
            this.Text = "忘記密碼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnVertifyEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVertifyNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVertify;
    }
}