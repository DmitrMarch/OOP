namespace Lab7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            studentsTbl = new DataGridView();
            Fullname = new DataGridViewTextBoxColumn();
            RecordBook = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Specification = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            DateOfAdmission = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            delBtn = new Button();
            modBtn = new Button();
            addBtn = new Button();
            dateOfAdmissionField = new DateTimePicker();
            groupField = new TextBox();
            specificationField = new ComboBox();
            departmentField = new ComboBox();
            recordBookField = new TextBox();
            fullnameField = new TextBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            exportBtn = new Button();
            importBtn = new Button();
            label1 = new Label();
            fileTypeField = new ComboBox();
            listView2 = new ListView();
            ((System.ComponentModel.ISupportInitialize)studentsTbl).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // studentsTbl
            // 
            studentsTbl.AllowUserToAddRows = false;
            studentsTbl.AllowUserToDeleteRows = false;
            studentsTbl.AllowUserToResizeColumns = false;
            studentsTbl.AllowUserToResizeRows = false;
            studentsTbl.BackgroundColor = SystemColors.Control;
            studentsTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsTbl.Columns.AddRange(new DataGridViewColumn[] { Fullname, RecordBook, Department, Specification, Group, DateOfAdmission });
            studentsTbl.GridColor = SystemColors.GradientInactiveCaption;
            studentsTbl.Location = new Point(12, 12);
            studentsTbl.Name = "studentsTbl";
            studentsTbl.ReadOnly = true;
            studentsTbl.RowHeadersVisible = false;
            studentsTbl.RowHeadersWidth = 51;
            studentsTbl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsTbl.Size = new Size(737, 474);
            studentsTbl.TabIndex = 0;
            studentsTbl.SelectionChanged += studentsTbl_SelectionChanged;
            // 
            // Fullname
            // 
            Fullname.HeaderText = "ФИО студента";
            Fullname.MinimumWidth = 6;
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            Fullname.Width = 123;
            // 
            // RecordBook
            // 
            RecordBook.HeaderText = "Зачётная книжка";
            RecordBook.MinimumWidth = 6;
            RecordBook.Name = "RecordBook";
            RecordBook.ReadOnly = true;
            RecordBook.Width = 143;
            // 
            // Department
            // 
            Department.HeaderText = "Институт";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.ReadOnly = true;
            Department.Width = 99;
            // 
            // Specification
            // 
            Specification.HeaderText = "Направление";
            Specification.MinimumWidth = 6;
            Specification.Name = "Specification";
            Specification.ReadOnly = true;
            Specification.Width = 133;
            // 
            // Group
            // 
            Group.HeaderText = "Группа";
            Group.MinimumWidth = 6;
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Width = 87;
            // 
            // DateOfAdmission
            // 
            DateOfAdmission.HeaderText = "Дата поступления";
            DateOfAdmission.MinimumWidth = 6;
            DateOfAdmission.Name = "DateOfAdmission";
            DateOfAdmission.ReadOnly = true;
            DateOfAdmission.Width = 149;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(delBtn);
            groupBox1.Controls.Add(modBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(dateOfAdmissionField);
            groupBox1.Controls.Add(groupField);
            groupBox1.Controls.Add(specificationField);
            groupBox1.Controls.Add(departmentField);
            groupBox1.Controls.Add(recordBookField);
            groupBox1.Controls.Add(fullnameField);
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(755, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 315);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Изменение информации о студенте";
            // 
            // delBtn
            // 
            delBtn.Location = new Point(233, 266);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 11;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // modBtn
            // 
            modBtn.Location = new Point(112, 266);
            modBtn.Name = "modBtn";
            modBtn.Size = new Size(115, 29);
            modBtn.TabIndex = 10;
            modBtn.Text = "Изменить";
            modBtn.UseVisualStyleBackColor = true;
            modBtn.Click += modBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(12, 266);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 9;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // dateOfAdmissionField
            // 
            dateOfAdmissionField.Location = new Point(12, 223);
            dateOfAdmissionField.Name = "dateOfAdmissionField";
            dateOfAdmissionField.Size = new Size(315, 30);
            dateOfAdmissionField.TabIndex = 8;
            // 
            // groupField
            // 
            groupField.Location = new Point(12, 187);
            groupField.Name = "groupField";
            groupField.PlaceholderText = "Группа";
            groupField.Size = new Size(315, 30);
            groupField.TabIndex = 7;
            // 
            // specificationField
            // 
            specificationField.FormattingEnabled = true;
            specificationField.Location = new Point(12, 150);
            specificationField.Name = "specificationField";
            specificationField.Size = new Size(315, 31);
            specificationField.TabIndex = 6;
            specificationField.Text = "Прикладная информатика";
            // 
            // departmentField
            // 
            departmentField.FormattingEnabled = true;
            departmentField.Location = new Point(12, 113);
            departmentField.Name = "departmentField";
            departmentField.Size = new Size(315, 31);
            departmentField.TabIndex = 5;
            departmentField.Text = "ИТНиИТ";
            // 
            // recordBookField
            // 
            recordBookField.Location = new Point(12, 77);
            recordBookField.Name = "recordBookField";
            recordBookField.PlaceholderText = "Зачётка";
            recordBookField.Size = new Size(315, 30);
            recordBookField.TabIndex = 4;
            // 
            // fullnameField
            // 
            fullnameField.Location = new Point(12, 41);
            fullnameField.Name = "fullnameField";
            fullnameField.PlaceholderText = "ФИО";
            fullnameField.Size = new Size(315, 30);
            fullnameField.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.AccessibleName = "";
            listView1.Location = new Point(6, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(328, 280);
            listView1.TabIndex = 2;
            listView1.Tag = "";
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Window;
            groupBox2.Controls.Add(exportBtn);
            groupBox2.Controls.Add(importBtn);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(fileTypeField);
            groupBox2.Controls.Add(listView2);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.ForeColor = SystemColors.Highlight;
            groupBox2.Location = new Point(755, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Работа с файлом";
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(174, 103);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(153, 29);
            exportBtn.TabIndex = 11;
            exportBtn.Text = "Экспорт";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // importBtn
            // 
            importBtn.Location = new Point(12, 103);
            importBtn.Name = "importBtn";
            importBtn.Size = new Size(156, 29);
            importBtn.TabIndex = 10;
            importBtn.Text = "Импорт";
            importBtn.UseVisualStyleBackColor = true;
            importBtn.Click += importBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 4;
            label1.Text = "Тип файла";
            // 
            // fileTypeField
            // 
            fileTypeField.FormattingEnabled = true;
            fileTypeField.Items.AddRange(new object[] { "JSON", "XML" });
            fileTypeField.Location = new Point(12, 64);
            fileTypeField.Name = "fileTypeField";
            fileTypeField.Size = new Size(315, 31);
            fileTypeField.TabIndex = 3;
            fileTypeField.Text = "JSON";
            // 
            // listView2
            // 
            listView2.AccessibleName = "";
            listView2.Location = new Point(6, 29);
            listView2.Name = "listView2";
            listView2.Size = new Size(328, 114);
            listView2.TabIndex = 2;
            listView2.Tag = "";
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1103, 496);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(studentsTbl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)studentsTbl).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentsTbl;
        private GroupBox groupBox1;
        private ListView listView1;
        private TextBox recordBookField;
        private TextBox fullnameField;
        private Button delBtn;
        private Button modBtn;
        private Button addBtn;
        private DateTimePicker dateOfAdmissionField;
        private TextBox groupField;
        private ComboBox specificationField;
        private ComboBox departmentField;
        private GroupBox groupBox2;
        private ListView listView2;
        private ComboBox fileTypeField;
        private Button exportBtn;
        private Button importBtn;
        private Label label1;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn RecordBook;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Specification;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn DateOfAdmission;
    }
}
