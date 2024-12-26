namespace Lab10
{
    partial class FilmsMod
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
            this.label5 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.filmName = new System.Windows.Forms.TextBox();
            this.modFilm = new System.Windows.Forms.Button();
            this.filmGenres = new System.Windows.Forms.ComboBox();
            this.filmTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.filmTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Длительность";
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTime.Location = new System.Drawing.Point(252, 147);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 34);
            this.startTime.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Жанр";
            // 
            // filmName
            // 
            this.filmName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmName.Location = new System.Drawing.Point(251, 29);
            this.filmName.Name = "filmName";
            this.filmName.Size = new System.Drawing.Size(201, 34);
            this.filmName.TabIndex = 27;
            // 
            // modFilm
            // 
            this.modFilm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modFilm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modFilm.Location = new System.Drawing.Point(116, 282);
            this.modFilm.Name = "modFilm";
            this.modFilm.Size = new System.Drawing.Size(231, 42);
            this.modFilm.TabIndex = 26;
            this.modFilm.Text = "Изменить фильм";
            this.modFilm.UseVisualStyleBackColor = false;
            this.modFilm.Click += new System.EventHandler(this.modFilm_Click);
            // 
            // filmGenres
            // 
            this.filmGenres.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmGenres.FormattingEnabled = true;
            this.filmGenres.Location = new System.Drawing.Point(251, 86);
            this.filmGenres.Name = "filmGenres";
            this.filmGenres.Size = new System.Drawing.Size(201, 36);
            this.filmGenres.TabIndex = 25;
            // 
            // filmTime
            // 
            this.filmTime.DecimalPlaces = 1;
            this.filmTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.filmTime.Location = new System.Drawing.Point(252, 215);
            this.filmTime.Name = "filmTime";
            this.filmTime.Size = new System.Drawing.Size(201, 34);
            this.filmTime.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Время начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название фильма";
            // 
            // FilmsMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filmName);
            this.Controls.Add(this.modFilm);
            this.Controls.Add(this.filmGenres);
            this.Controls.Add(this.filmTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FilmsMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить фильм";
            ((System.ComponentModel.ISupportInitialize)(this.filmTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filmName;
        private System.Windows.Forms.Button modFilm;
        private System.Windows.Forms.ComboBox filmGenres;
        private System.Windows.Forms.NumericUpDown filmTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}