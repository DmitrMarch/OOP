using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Login : Form
    {
        private static string _connectionString = "Server=localhost\\" +
            "SQLEXPRESS; Database=users_films_db; TrustServerCertificate=True; " +
            "User Id=sa; Password=123;";
        private Form1 _form1;

        public Login(Form1 form1)
        {
            InitializeComponent();

            _form1 = form1;
            _form1.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string input_pass_hash = Form1.getSha1Hash(passField.Text);

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

                    string selectQuery1 = "SELECT username, role, password FROM users " +
                        "WHERE username=@login";

                    SqlCommand command1 = new SqlCommand(selectQuery1, connection);
                    command1.Parameters.AddWithValue("@login", login);

                    SqlDataReader reader1 = command1.ExecuteReader();

                    if (!reader1.Read())
                    {
                        reader1.Close();
                        MessageBox.Show("Пользователя с таким именем нету в системе :(");
                        return;
                    }

                    int role_id = (int)reader1[1];
                    string original_pass_hash = (string)reader1[2];

                    reader1.Close();

                    if (input_pass_hash != original_pass_hash)
                    {
                        MessageBox.Show("Вы ввели неправильный логин или пароль :(");
                        return;
                    }

                    string selectQuery2 = "SELECT role_id, role_name FROM roles WHERE " +
                        "role_id=@role_id";
                    SqlCommand command2 = new SqlCommand(selectQuery2, connection);
                    command2.Parameters.AddWithValue("@role_id", role_id);
                    SqlDataReader reader2 = command2.ExecuteReader();

                    reader2.Read();
                    _form1.UserName = login;
                    _form1.RoleName = (string)reader2[1];
                    reader2.Close();

                    Hide();
                    _form1.Show();

                    MessageBox.Show("Успешный вход!");
                    _form1.updateLog("вход в систему");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(_form1, this);
            registration.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Close();
        }
    }
}
