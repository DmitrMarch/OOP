using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Registration : Form
    {
        private static string _connectionString = "Server=localhost\\" +
            "SQLEXPRESS; Database=users_films_db; TrustServerCertificate=True; " +
            "User Id=sa; Password=123;";
        private Form1 _form1;

        public Registration(Form1 form1, Login login)
        {
            InitializeComponent();

            _form1 = form1;
            login.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string input_pass_hash = Form1.getSha1Hash(passField.Text);
            int role = 2;

            if (login == "" || input_pass_hash == "")
            {
                MessageBox.Show("Заполниите пустые поля");
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT username FROM users WHERE " +
                        "username=@login";

                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@login", login);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Пользователь с таким именем уже есть в системе :(");
                        return;
                    }

                    string insertQuery = "INSERT INTO users " +
                        "(username, role, password) VALUES " +
                        "(@login, @role, @input_pass_hash)";
                    SqlCommand ins_command = new SqlCommand(insertQuery, connection);
                    ins_command.Parameters.AddWithValue("@login", login);
                    ins_command.Parameters.AddWithValue("@role", role);
                    ins_command.Parameters.AddWithValue("@input_pass_hash", input_pass_hash);

                    reader.Close();
                    ins_command.ExecuteNonQuery().ToString();

                    Hide();
                    _form1.Show();

                    _form1.UserName = login;
                    _form1.RoleName = "гость";

                    MessageBox.Show("Успешная регистрация!");
                    _form1.updateLog("регистрация в системе");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Close();
        }
    }
}
