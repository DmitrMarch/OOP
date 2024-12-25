using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FilmsAdd : Form
    {
        private List<List<string>> _filmGenres = new List<List<string>>();
        private Form1 _form1;
        private DataGridView _filmsTable;
        private static string _connectionString = "Server=localhost\\" +
            "SQLEXPRESS; Database=exam_db; TrustServerCertificate=True; " +
            "User Id=sa; Password=123;";

        public FilmsAdd(Form1 form1, DataGridView table)
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
                        _filmGenres.Add(new List<string> { reader[0].ToString(),
                            (string)reader[1]});
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
            }
        }

        private void appendFilm_Click(object sender, EventArgs e)
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

                    if (reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Фильм с таким названием уже есть");
                    }

                    else
                    {
                        string insertQuery = "INSERT INTO films " +
                            "(film_name, genre, start_time, film_time) VALUES " +
                            "(@film_name, @genre, @start_time, @film_time)";
                        SqlCommand ins_command = new SqlCommand(insertQuery, connection);
                        ins_command.Parameters.AddWithValue("@film_name", film_name);
                        ins_command.Parameters.AddWithValue("@genre", genre_id);
                        ins_command.Parameters.AddWithValue("@start_time", start_time);
                        ins_command.Parameters.AddWithValue("@film_time", film_time);

                        reader.Close();
                        ins_command.ExecuteNonQuery().ToString();
                        MessageBox.Show("Фильм добавлен");
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
