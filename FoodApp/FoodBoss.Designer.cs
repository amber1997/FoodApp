namespace FoodApp
{
    partial class FoodBoss
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
            this.labRestaurant = new System.Windows.Forms.Label();
            this.dgvFoodMenu = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTodayMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // labRestaurant
            // 
            this.labRestaurant.AutoSize = true;
            this.labRestaurant.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRestaurant.Location = new System.Drawing.Point(50, 80);
            this.labRestaurant.Name = "labRestaurant";
            this.labRestaurant.Size = new System.Drawing.Size(460, 43);
            this.labRestaurant.TabIndex = 0;
            this.labRestaurant.Text = "新增、刪除、修改菜單:";
            // 
            // dgvFoodMenu
            // 
            this.dgvFoodMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodMenu.Location = new System.Drawing.Point(30, 267);
            this.dgvFoodMenu.Name = "dgvFoodMenu";
            this.dgvFoodMenu.ReadOnly = true;
            this.dgvFoodMenu.RowTemplate.Height = 38;
            this.dgvFoodMenu.Size = new System.Drawing.Size(1405, 520);
            this.dgvFoodMenu.TabIndex = 1;
            this.dgvFoodMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodMenu_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(184, 842);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(219, 82);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "新增菜單";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(643, 842);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(219, 82);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "刪除菜單";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1084, 842);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(219, 82);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改菜單";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1209, 53);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(175, 70);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "登出";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTodayMenu
            // 
            this.btnTodayMenu.Location = new System.Drawing.Point(184, 1035);
            this.btnTodayMenu.Name = "btnTodayMenu";
            this.btnTodayMenu.Size = new System.Drawing.Size(171, 86);
            this.btnTodayMenu.TabIndex = 6;
            this.btnTodayMenu.Text = "今日餐點收據";
            this.btnTodayMenu.UseVisualStyleBackColor = true;
            this.btnTodayMenu.Click += new System.EventHandler(this.btnTodayMenu_Click);
            // 
            // FoodBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 1167);
            this.Controls.Add(this.btnTodayMenu);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvFoodMenu);
            this.Controls.Add(this.labRestaurant);
            this.Name = "FoodBoss";
            this.Text = "業者";
            this.Load += new System.EventHandler(this.FoodBoss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRestaurant;
        private System.Windows.Forms.DataGridView dgvFoodMenu;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTodayMenu;
    }
}

