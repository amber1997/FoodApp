namespace FoodRegLogIn
{
    partial class frmVertifyAcc
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
            this.components = new System.ComponentModel.Container();
            this.btnVertify = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtVertifyNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.btnReSend = new System.Windows.Forms.Button();
            this.linkLbChangeEmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnVertify
            // 
            this.btnVertify.Location = new System.Drawing.Point(162, 448);
            this.btnVertify.Name = "btnVertify";
            this.btnVertify.Size = new System.Drawing.Size(235, 66);
            this.btnVertify.TabIndex = 0;
            this.btnVertify.Text = "驗證";
            this.btnVertify.UseVisualStyleBackColor = true;
            this.btnVertify.Click += new System.EventHandler(this.btnVertify_Click);
            // 
            // txtVertifyNum
            // 
            this.txtVertifyNum.Location = new System.Drawing.Point(301, 272);
            this.txtVertifyNum.Name = "txtVertifyNum";
            this.txtVertifyNum.Size = new System.Drawing.Size(387, 36);
            this.txtVertifyNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(304, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "已經寄送至信箱:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmail.Location = new System.Drawing.Point(557, 171);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(0, 32);
            this.labEmail.TabIndex = 4;
            // 
            // btnReSend
            // 
            this.btnReSend.Location = new System.Drawing.Point(466, 448);
            this.btnReSend.Name = "btnReSend";
            this.btnReSend.Size = new System.Drawing.Size(235, 66);
            this.btnReSend.TabIndex = 2;
            this.btnReSend.Text = "重新寄送";
            this.btnReSend.UseVisualStyleBackColor = true;
            this.btnReSend.Click += new System.EventHandler(this.btnReSend_Click);
            // 
            // linkLbChangeEmail
            // 
            this.linkLbChangeEmail.AutoSize = true;
            this.linkLbChangeEmail.Location = new System.Drawing.Point(782, 471);
            this.linkLbChangeEmail.Name = "linkLbChangeEmail";
            this.linkLbChangeEmail.Size = new System.Drawing.Size(140, 24);
            this.linkLbChangeEmail.TabIndex = 5;
            this.linkLbChangeEmail.TabStop = true;
            this.linkLbChangeEmail.Text = "信箱收不到?";
            this.linkLbChangeEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbChangeEmail_LinkClicked);
            // 
            // frmVertifyAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 710);
            this.Controls.Add(this.linkLbChangeEmail);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReSend);
            this.Controls.Add(this.txtVertifyNum);
            this.Controls.Add(this.btnVertify);
            this.Name = "frmVertifyAcc";
            this.Text = "驗證帳號";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVertify;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtVertifyNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Button btnReSend;
        private System.Windows.Forms.LinkLabel linkLbChangeEmail;
    }
}