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
            dataGridView1 = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            RecordBook = new DataGridViewTextBoxColumn();
            Departament = new DataGridViewTextBoxColumn();
            Direction = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            DateOfAdmission = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            comboBox3 = new ComboBox();
            listView2 = new ListView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentName, RecordBook, Departament, Direction, Group, DateOfAdmission });
            dataGridView1.GridColor = SystemColors.GradientInactiveCaption;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(787, 474);
            dataGridView1.TabIndex = 0;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "ФИО студента";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 123;
            // 
            // RecordBook
            // 
            RecordBook.HeaderText = "Зачётная книжка";
            RecordBook.MinimumWidth = 6;
            RecordBook.Name = "RecordBook";
            RecordBook.ReadOnly = true;
            RecordBook.Width = 143;
            // 
            // Departament
            // 
            Departament.HeaderText = "Институт";
            Departament.MinimumWidth = 6;
            Departament.Name = "Departament";
            Departament.ReadOnly = true;
            Departament.Width = 99;
            // 
            // Direction
            // 
            Direction.HeaderText = "Направление";
            Direction.MinimumWidth = 6;
            Direction.Name = "Direction";
            Direction.ReadOnly = true;
            Direction.Width = 133;
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
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(805, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 315);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Изменение информации о студенте";
            // 
            // button3
            // 
            button3.Location = new Point(233, 266);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(112, 266);
            button2.Name = "button2";
            button2.Size = new Size(115, 29);
            button2.TabIndex = 10;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(315, 30);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 187);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Группа";
            textBox3.Size = new Size(315, 30);
            textBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 150);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(315, 31);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 31);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 77);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Зачётка";
            textBox2.Size = new Size(315, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ФИО";
            textBox1.Size = new Size(315, 30);
            textBox1.TabIndex = 3;
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
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(listView2);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.ForeColor = SystemColors.Highlight;
            groupBox2.Location = new Point(805, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Работа с файлом";
            // 
            // button5
            // 
            button5.Location = new Point(174, 103);
            button5.Name = "button5";
            button5.Size = new Size(153, 29);
            button5.TabIndex = 11;
            button5.Text = "Экспорт";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 103);
            button4.Name = "button4";
            button4.Size = new Size(156, 29);
            button4.TabIndex = 10;
            button4.Text = "Импорт";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 38);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 4;
            label1.Text = "Тип файла";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 64);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(328, 31);
            comboBox3.TabIndex = 3;
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
            ClientSize = new Size(1155, 496);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn RecordBook;
        private DataGridViewTextBoxColumn Departament;
        private DataGridViewTextBoxColumn Direction;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn DateOfAdmission;
        private GroupBox groupBox1;
        private ListView listView1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private ListView listView2;
        private ComboBox comboBox3;
        private Button button5;
        private Button button4;
        private Label label1;
    }
}
