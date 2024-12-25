namespace MVP.Views
{
    partial class MVPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MVPForm));
            panel1 = new Panel();
            btnOrders = new Button();
            btnDepartment = new Button();
            btnUsers = new Button();
            panelmain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnDepartment);
            panel1.Controls.Add(btnUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 55);
            panel1.TabIndex = 0;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Location = new Point(288, 0);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(138, 55);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Location = new Point(144, 0);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(138, 55);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = "Отделы";
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Location = new Point(0, 0);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(138, 55);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Пользователи";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // panelmain
            // 
            panelmain.BackColor = SystemColors.GradientActiveCaption;
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 55);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(952, 503);
            panelmain.TabIndex = 1;
            // 
            // MVPForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 558);
            Controls.Add(panelmain);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MVPForm";
            Text = "MVPForm";
            Load += MVPForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelmain;
        private Button btnUsers;
        private Button btnDepartment;
        private Button btnOrders;
    }
}