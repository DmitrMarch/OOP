namespace Lab10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.filmsTable = new System.Windows.Forms.DataGridView();
            this.filmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exam_dbDataSet = new Lab10.exam_dbDataSet();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.appendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.genresField = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Lab10.exam_dbDataSetTableAdapters.filmsTableAdapter();
            this.genresTableAdapter = new Lab10.exam_dbDataSetTableAdapters.genresTableAdapter();
            this.tableAdapterManager = new Lab10.exam_dbDataSetTableAdapters.TableAdapterManager();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Lab10.exam_dbDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filmsTable
            // 
            this.filmsTable.AllowUserToAddRows = false;
            this.filmsTable.AllowUserToDeleteRows = false;
            this.filmsTable.AllowUserToResizeColumns = false;
            this.filmsTable.AllowUserToResizeRows = false;
            this.filmsTable.AutoGenerateColumns = false;
            this.filmsTable.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.filmsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmnameDataGridViewTextBoxColumn,
            this.genre_name,
            this.starttimeDataGridViewTextBoxColumn,
            this.filmtimeDataGridViewTextBoxColumn});
            this.filmsTable.DataSource = this.dataTable1BindingSource1;
            this.filmsTable.Location = new System.Drawing.Point(33, 38);
            this.filmsTable.Name = "filmsTable";
            this.filmsTable.ReadOnly = true;
            this.filmsTable.RowHeadersVisible = false;
            this.filmsTable.RowHeadersWidth = 51;
            this.filmsTable.RowTemplate.Height = 24;
            this.filmsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmsTable.Size = new System.Drawing.Size(705, 242);
            this.filmsTable.TabIndex = 0;
            // 
            // filmnameDataGridViewTextBoxColumn
            // 
            this.filmnameDataGridViewTextBoxColumn.DataPropertyName = "film_name";
            this.filmnameDataGridViewTextBoxColumn.HeaderText = "Название фильма";
            this.filmnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmnameDataGridViewTextBoxColumn.Name = "filmnameDataGridViewTextBoxColumn";
            this.filmnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmnameDataGridViewTextBoxColumn.Width = 155;
            // 
            // genre_name
            // 
            this.genre_name.DataPropertyName = "genre_name";
            this.genre_name.HeaderText = "genre_name";
            this.genre_name.MinimumWidth = 6;
            this.genre_name.Name = "genre_name";
            this.genre_name.ReadOnly = true;
            this.genre_name.Width = 125;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "время начала";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.starttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmtimeDataGridViewTextBoxColumn
            // 
            this.filmtimeDataGridViewTextBoxColumn.DataPropertyName = "film_time";
            this.filmtimeDataGridViewTextBoxColumn.HeaderText = "длительность";
            this.filmtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmtimeDataGridViewTextBoxColumn.Name = "filmtimeDataGridViewTextBoxColumn";
            this.filmtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.exam_dbDataSet;
            // 
            // exam_dbDataSet
            // 
            this.exam_dbDataSet.DataSetName = "exam_dbDataSet";
            this.exam_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifyBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modifyBtn.Location = new System.Drawing.Point(252, 309);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(268, 42);
            this.modifyBtn.TabIndex = 24;
            this.modifyBtn.Text = "Изменить";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(526, 309);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(212, 42);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // appendBtn
            // 
            this.appendBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.appendBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appendBtn.Location = new System.Drawing.Point(33, 309);
            this.appendBtn.Name = "appendBtn";
            this.appendBtn.Size = new System.Drawing.Size(213, 42);
            this.appendBtn.TabIndex = 22;
            this.appendBtn.Text = "Добавить";
            this.appendBtn.UseVisualStyleBackColor = false;
            this.appendBtn.Click += new System.EventHandler(this.appendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Жанр для поиска";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(33, 357);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(104, 42);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "Сброс";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(143, 357);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(103, 42);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // genresField
            // 
            this.genresField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresField.FormattingEnabled = true;
            this.genresField.Location = new System.Drawing.Point(526, 359);
            this.genresField.Name = "genresField";
            this.genresField.Size = new System.Drawing.Size(212, 36);
            this.genresField.TabIndex = 25;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "genres";
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "films";
            this.filmsBindingSource.DataSource = this.exam_dbDataSet;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.filmsTableAdapter = null;
            this.tableAdapterManager.genresTableAdapter = this.genresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab10.exam_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.exam_dbDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 435);
            this.Controls.Add(this.genresField);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.appendBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.filmsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильмы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filmsTable;
        private exam_dbDataSet exam_dbDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private exam_dbDataSetTableAdapters.filmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button appendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox genresField;
        private exam_dbDataSetTableAdapters.genresTableAdapter genresTableAdapter;
        private exam_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private exam_dbDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmtimeDataGridViewTextBoxColumn;
    }
}

