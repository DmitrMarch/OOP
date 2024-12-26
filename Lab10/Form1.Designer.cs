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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filmsTable = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.films_dbDataSet = new Lab10.films_dbDataSet();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.appendBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.genresField = new System.Windows.Forms.ComboBox();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Lab10.films_dbDataSetTableAdapters.filmsTableAdapter();
            this.genresTableAdapter = new Lab10.films_dbDataSetTableAdapters.genresTableAdapter();
            this.tableAdapterManager = new Lab10.films_dbDataSetTableAdapters.TableAdapterManager();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Lab10.films_dbDataSetTableAdapters.DataTable1TableAdapter();
            this.filmNameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountBtn = new System.Windows.Forms.Button();
            this.film_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filmsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.films_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
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
            this.film_name,
            this.genre_name,
            this.start_time,
            this.film_time});
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
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.films_dbDataSet;
            // 
            // films_dbDataSet
            // 
            this.films_dbDataSet.DataSetName = "films_dbDataSet";
            this.films_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(252, 397);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(268, 42);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "Сброс";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterBtn.Location = new System.Drawing.Point(525, 397);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(213, 42);
            this.filterBtn.TabIndex = 18;
            this.filterBtn.Text = "Фильтр";
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // genresField
            // 
            this.genresField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresField.FormattingEnabled = true;
            this.genresField.Location = new System.Drawing.Point(527, 356);
            this.genresField.Name = "genresField";
            this.genresField.Size = new System.Drawing.Size(210, 36);
            this.genresField.TabIndex = 25;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "films";
            this.filmsBindingSource.DataSource = this.films_dbDataSet;
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
            this.tableAdapterManager.UpdateOrder = Lab10.films_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.films_dbDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // filmNameField
            // 
            this.filmNameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmNameField.Location = new System.Drawing.Point(253, 357);
            this.filmNameField.Name = "filmNameField";
            this.filmNameField.Size = new System.Drawing.Size(264, 34);
            this.filmNameField.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название фаильма =>";
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountBtn.Location = new System.Drawing.Point(33, 397);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(213, 42);
            this.accountBtn.TabIndex = 27;
            this.accountBtn.Text = "Личный кабинет";
            this.accountBtn.UseVisualStyleBackColor = false;
            // 
            // film_name
            // 
            this.film_name.DataPropertyName = "film_name";
            this.film_name.HeaderText = "Название фильма";
            this.film_name.MinimumWidth = 6;
            this.film_name.Name = "film_name";
            this.film_name.ReadOnly = true;
            this.film_name.Width = 155;
            // 
            // genre_name
            // 
            this.genre_name.DataPropertyName = "genre_name";
            this.genre_name.HeaderText = "Название жанра";
            this.genre_name.MinimumWidth = 6;
            this.genre_name.Name = "genre_name";
            this.genre_name.ReadOnly = true;
            this.genre_name.Width = 125;
            // 
            // start_time
            // 
            this.start_time.DataPropertyName = "start_time";
            this.start_time.HeaderText = "Время начала";
            this.start_time.MinimumWidth = 6;
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            this.start_time.Width = 125;
            // 
            // film_time
            // 
            this.film_time.DataPropertyName = "film_time";
            this.film_time.HeaderText = "Длительность";
            this.film_time.MinimumWidth = 6;
            this.film_time.Name = "film_time";
            this.film_time.ReadOnly = true;
            this.film_time.Width = 125;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "genres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 474);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.filmNameField);
            this.Controls.Add(this.genresField);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.appendBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.filmsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильмы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.filmsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.films_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filmsTable;
        private films_dbDataSet films_dbDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private films_dbDataSetTableAdapters.filmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button appendBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.ComboBox genresField;
        private films_dbDataSetTableAdapters.genresTableAdapter genresTableAdapter;
        private films_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private films_dbDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.TextBox filmNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_time;
    }
}

