namespace Lab10
{
    partial class Account
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
            this.label2 = new System.Windows.Forms.Label();
            this.eventsTbl = new System.Windows.Forms.DataGridView();
            this.roleLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventsTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Логин =>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Роль =>";
            // 
            // eventsTbl
            // 
            this.eventsTbl.AllowUserToAddRows = false;
            this.eventsTbl.AllowUserToDeleteRows = false;
            this.eventsTbl.AllowUserToResizeColumns = false;
            this.eventsTbl.AllowUserToResizeRows = false;
            this.eventsTbl.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.eventsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventDate,
            this.eventType,
            this.userName,
            this.roleName});
            this.eventsTbl.Location = new System.Drawing.Point(37, 112);
            this.eventsTbl.Name = "eventsTbl";
            this.eventsTbl.RowHeadersVisible = false;
            this.eventsTbl.RowHeadersWidth = 51;
            this.eventsTbl.RowTemplate.Height = 24;
            this.eventsTbl.Size = new System.Drawing.Size(641, 296);
            this.eventsTbl.TabIndex = 24;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.Location = new System.Drawing.Point(144, 66);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(54, 23);
            this.roleLabel.TabIndex = 26;
            this.roleLabel.Text = "Текст";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(144, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(54, 23);
            this.loginLabel.TabIndex = 25;
            this.loginLabel.Text = "Текст";
            // 
            // eventDate
            // 
            this.eventDate.HeaderText = "Дата события";
            this.eventDate.MinimumWidth = 6;
            this.eventDate.Name = "eventDate";
            this.eventDate.ReadOnly = true;
            this.eventDate.Width = 125;
            // 
            // eventType
            // 
            this.eventType.HeaderText = "Тип события";
            this.eventType.MinimumWidth = 6;
            this.eventType.Name = "eventType";
            this.eventType.ReadOnly = true;
            this.eventType.Width = 125;
            // 
            // userName
            // 
            this.userName.HeaderText = "Имя пользователя";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 125;
            // 
            // roleName
            // 
            this.roleName.HeaderText = "Роль пользователя";
            this.roleName.MinimumWidth = 6;
            this.roleName.Name = "roleName";
            this.roleName.ReadOnly = true;
            this.roleName.Width = 125;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 441);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.eventsTbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Account_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.eventsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView eventsTbl;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleName;
    }
}