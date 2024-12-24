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
            StudentsTbl = new DataGridView();
            Fullname = new DataGridViewTextBoxColumn();
            RecordBook = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Specification = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            DateOfAdmission = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            DelBtn = new Button();
            ModBtn = new Button();
            AddBtn = new Button();
            DateOfAdmissionField = new DateTimePicker();
            GroupField = new TextBox();
            SpecificationField = new ComboBox();
            DepartmentField = new ComboBox();
            RecordBookField = new TextBox();
            FullnameField = new TextBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            ExportBtn = new Button();
            ImportBtn = new Button();
            label1 = new Label();
            FileTypeField = new ComboBox();
            listView2 = new ListView();
            ((System.ComponentModel.ISupportInitialize)StudentsTbl).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // StudentsTbl
            // 
            StudentsTbl.AllowUserToAddRows = false;
            StudentsTbl.AllowUserToDeleteRows = false;
            StudentsTbl.AllowUserToResizeColumns = false;
            StudentsTbl.AllowUserToResizeRows = false;
            StudentsTbl.BackgroundColor = SystemColors.Control;
            StudentsTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsTbl.Columns.AddRange(new DataGridViewColumn[] { Fullname, RecordBook, Department, Specification, Group, DateOfAdmission });
            StudentsTbl.GridColor = SystemColors.GradientInactiveCaption;
            StudentsTbl.Location = new Point(12, 12);
            StudentsTbl.Name = "StudentsTbl";
            StudentsTbl.ReadOnly = true;
            StudentsTbl.RowHeadersVisible = false;
            StudentsTbl.RowHeadersWidth = 51;
            StudentsTbl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentsTbl.Size = new Size(737, 474);
            StudentsTbl.TabIndex = 0;
            StudentsTbl.SelectionChanged += StudentsTbl_SelectionChanged;
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
            groupBox1.Controls.Add(DelBtn);
            groupBox1.Controls.Add(ModBtn);
            groupBox1.Controls.Add(AddBtn);
            groupBox1.Controls.Add(DateOfAdmissionField);
            groupBox1.Controls.Add(GroupField);
            groupBox1.Controls.Add(SpecificationField);
            groupBox1.Controls.Add(DepartmentField);
            groupBox1.Controls.Add(RecordBookField);
            groupBox1.Controls.Add(FullnameField);
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
            // DelBtn
            // 
            DelBtn.Location = new Point(233, 266);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(94, 29);
            DelBtn.TabIndex = 11;
            DelBtn.Text = "Удалить";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // ModBtn
            // 
            ModBtn.Location = new Point(112, 266);
            ModBtn.Name = "ModBtn";
            ModBtn.Size = new Size(115, 29);
            ModBtn.TabIndex = 10;
            ModBtn.Text = "Изменить";
            ModBtn.UseVisualStyleBackColor = true;
            ModBtn.Click += ModBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(12, 266);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 9;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DateOfAdmissionField
            // 
            DateOfAdmissionField.Location = new Point(12, 223);
            DateOfAdmissionField.Name = "DateOfAdmissionField";
            DateOfAdmissionField.Size = new Size(315, 30);
            DateOfAdmissionField.TabIndex = 8;
            // 
            // GroupField
            // 
            GroupField.Location = new Point(12, 187);
            GroupField.Name = "GroupField";
            GroupField.PlaceholderText = "Группа";
            GroupField.Size = new Size(315, 30);
            GroupField.TabIndex = 7;
            // 
            // SpecificationField
            // 
            SpecificationField.FormattingEnabled = true;
            SpecificationField.Location = new Point(12, 150);
            SpecificationField.Name = "SpecificationField";
            SpecificationField.Size = new Size(315, 31);
            SpecificationField.TabIndex = 6;
            SpecificationField.Text = "Прикладная информатика";
            // 
            // DepartmentField
            // 
            DepartmentField.FormattingEnabled = true;
            DepartmentField.Location = new Point(12, 113);
            DepartmentField.Name = "DepartmentField";
            DepartmentField.Size = new Size(315, 31);
            DepartmentField.TabIndex = 5;
            DepartmentField.Text = "ИТНиИТ";
            // 
            // RecordBookField
            // 
            RecordBookField.Location = new Point(12, 77);
            RecordBookField.Name = "RecordBookField";
            RecordBookField.PlaceholderText = "Зачётка";
            RecordBookField.Size = new Size(315, 30);
            RecordBookField.TabIndex = 4;
            // 
            // FullnameField
            // 
            FullnameField.Location = new Point(12, 41);
            FullnameField.Name = "FullnameField";
            FullnameField.PlaceholderText = "ФИО";
            FullnameField.Size = new Size(315, 30);
            FullnameField.TabIndex = 3;
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
            groupBox2.Controls.Add(ExportBtn);
            groupBox2.Controls.Add(ImportBtn);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(FileTypeField);
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
            // ExportBtn
            // 
            ExportBtn.Location = new Point(174, 103);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(153, 29);
            ExportBtn.TabIndex = 11;
            ExportBtn.Text = "Экспорт";
            ExportBtn.UseVisualStyleBackColor = true;
            // 
            // ImportBtn
            // 
            ImportBtn.Location = new Point(12, 103);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(156, 29);
            ImportBtn.TabIndex = 10;
            ImportBtn.Text = "Импорт";
            ImportBtn.UseVisualStyleBackColor = true;
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
            // FileTypeField
            // 
            FileTypeField.FormattingEnabled = true;
            FileTypeField.Items.AddRange(new object[] { "JSON", "XML" });
            FileTypeField.Location = new Point(12, 64);
            FileTypeField.Name = "FileTypeField";
            FileTypeField.Size = new Size(315, 31);
            FileTypeField.TabIndex = 3;
            FileTypeField.Text = "JSON";
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
            Controls.Add(StudentsTbl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)StudentsTbl).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StudentsTbl;
        private GroupBox groupBox1;
        private ListView listView1;
        private TextBox RecordBookField;
        private TextBox FullnameField;
        private Button DelBtn;
        private Button ModBtn;
        private Button AddBtn;
        private DateTimePicker DateOfAdmissionField;
        private TextBox GroupField;
        private ComboBox SpecificationField;
        private ComboBox DepartmentField;
        private GroupBox groupBox2;
        private ListView listView2;
        private ComboBox FileTypeField;
        private Button ExportBtn;
        private Button ImportBtn;
        private Label label1;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn RecordBook;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Specification;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn DateOfAdmission;
    }
}
