using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FilmsMod : Form
    {
        private List<List<string>> _filmGenres = new List<List<string>>();
        private Form1 _form1;
        private DataGridView _filmsTable;
        private static string _connectionString = "Server=localhost\\" +
            "SQLEXPRESS; Database=films_db; TrustServerCertificate=True; " +
            "User Id=sa; Password=123;";

        private string old_film_name;

        public FilmsMod(Form1 form1, DataGridView table)
        {
            InitializeComponent();

            _form1 = form1;
            _filmsTable = table;

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
                        _filmGenres.Add(new List<string> 
                        { 
                            reader[0].ToString(),
                            (string)reader[1] 
                        });
                    }

                    foreach (List<string> film_genre in _filmGenres)
                    {
                        filmGenres.Items.Add(film_genre[1]);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DataGridViewRow row = _filmsTable.SelectedRows[0];

                filmName.Text = row.Cells[0].Value.ToString();
                filmGenres.Text = (string)row.Cells[1].Value;
                startTime.Value = (DateTime)row.Cells[2].Value;
                filmTime.Value = (decimal)(float)row.Cells[3].Value;

                old_film_name = filmName.Text;
    }
        }

        private void modFilm_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT film_name FROM films WHERE " +
                        "film_name=@film_name";

                    string film_name = filmName.Text;
                    string genre_name = filmGenres.Text;
                    DateTime start_time = startTime.Value;
                    float film_time = (float)filmTime.Value;
                    int genre_id = 0;

                    foreach (List<string> film_genre in _filmGenres)
                    {
                        if (film_genre[1] == genre_name)
                        {
                            genre_id = int.Parse(film_genre[0]);
                        }
                    }

                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@film_name", film_name);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() && old_film_name != film_name)
                    {
                        reader.Close();
                        MessageBox.Show("Фильм с таким названием уже есть");
                    }

                    else
                    {
                        string updateQuery = "UPDATE films SET film_name=@film_name, genre=@genre, " +
                            "start_time=@start_time, film_time=@film_time " +
                            "WHERE film_name=@old_film_name";
                        SqlCommand upd_command = new SqlCommand(updateQuery, connection);

                        upd_command.Parameters.AddWithValue("@film_name", film_name);
                        upd_command.Parameters.AddWithValue("@genre", genre_id);
                        upd_command.Parameters.AddWithValue("@start_time", start_time);
                        upd_command.Parameters.AddWithValue("@film_time", film_time);
                        upd_command.Parameters.AddWithValue("@old_film_name", old_film_name);

                        reader.Close();
                        upd_command.ExecuteNonQuery().ToString();
                        MessageBox.Show("Фильм изменён");
                    }

                    _form1.updateTable();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
