using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private List<List<string>> _filmGenres = new List<List<string>>();
        private static string _connectionString = "Server=localhost\\" +
            "SQLEXPRESS; Database=films_db; TrustServerCertificate=True; " +
            "User Id=sa; Password=123;";
        private string _logFilePath = "events.log";
        private string _logFilePass = "123";

        public string RoleName { get; set; }
        public string UserName { get; set; }

        public Form1()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT genre_id, genre_name FROM genres";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    _filmGenres = new List<List<string>>();

                    while (reader.Read())
                    {
                        _filmGenres.Add(new List<string> { reader[0].ToString(),
                            (string)reader[1]});
                    }

                    foreach (List<string> film_genre in _filmGenres)
                    {
                        genresField.Items.Add(film_genre[1]);
                    }

                    genresField.Items.Add("Все");
                    genresField.Text = _filmGenres[0][1];

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void updateTable()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = filmsTable.DataSource;
            bs.Filter = "";
            filmsTable.DataSource = bs;
            dataTable1TableAdapter.Fill(films_dbDataSet.DataTable1);
        }

        public static string getSha1Hash(string text)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);

            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(textBytes);
                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public void updateLog(string event_type)
        {
            try
            {
                string log_file = File.Exists(_logFilePath)
                    ? File.ReadAllText(_logFilePath)
                    : string.Empty;

                if (log_file != "")
                {
                    log_file = AesCode.decryptText(log_file, _logFilePass);
                }

                string new_event = DateTime.Now.ToString("dd.MM.yyyy HH:mm") + 
                    "; " + event_type + "; " + UserName + "; " + RoleName + "\n";

                log_file += new_event;
                log_file = AesCode.encryptText(log_file, _logFilePass);
                File.WriteAllText(_logFilePath, log_file);
            }

            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public string readLog()
        {
            try
            {
                string log_file = File.ReadAllText(_logFilePath);
                return AesCode.decryptText(log_file, _logFilePass);
            }

            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "films_dbDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            dataTable1TableAdapter.Fill(films_dbDataSet.DataTable1);
        }

        private void appendBtn_Click(object sender, EventArgs e)
        {
            FilmsAdd films_add = new FilmsAdd(this, this.filmsTable);
            films_add.Show();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (filmsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строку для изменения");
            }

            else
            {
                FilmsMod films_mod = new FilmsMod(this, this.filmsTable);
                films_mod.Show();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (filmsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строку для удаления");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();

                        DataGridViewRow row = filmsTable.SelectedRows[0];

                        string film_name = row.Cells[0].Value.ToString();
                        string deleteQuery = "DELETE FROM films WHERE film_name=@film_name";

                        SqlCommand del_command = new SqlCommand(deleteQuery, connection);
                        del_command.Parameters.AddWithValue("@film_name", film_name);
                        del_command.ExecuteNonQuery().ToString();

                        MessageBox.Show("Фильм удалён");
                        updateLog("удаление записи из бд");
                        updateTable();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string genre_name = genresField.Text == "Все" ? 
                "" : genresField.Text;

            BindingSource bs = new BindingSource();
            bs.DataSource = filmsTable.DataSource;
            bs.Filter = filmsTable.Columns[1].Name +
                $" LIKE '%{genre_name}%' AND " +
                filmsTable.Columns[0].Name +
                $" LIKE '%{filmNameField.Text}%'";
            filmsTable.DataSource = bs;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            Account account = new Account(this);
            account.Show();
        }
    }
}
