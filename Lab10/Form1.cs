using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private string _userRole = "гость";

        private List<List<string>> _filmGenres = new List<List<string>>();
        private static string _connectionString = "Server=localhost\\" +
            "SQLEXPRESS; Database=films_db; TrustServerCertificate=True; " +
            "User Id=sa; Password=123;";

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

                    genresField.Items.Add("");
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
            BindingSource bs = new BindingSource();
            bs.DataSource = filmsTable.DataSource;
            bs.Filter = filmsTable.Columns[1].Name +
                $" LIKE '%{genresField.Text}%' AND " +
                filmsTable.Columns[0].Name +
                $" LIKE '%{filmNameField.Text}%'";
            filmsTable.DataSource = bs;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
        }
    }
}
