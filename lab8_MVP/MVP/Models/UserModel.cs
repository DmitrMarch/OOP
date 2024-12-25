using lab8.Other;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MVP.Models
{
    public class UserModel
    {
        public void CreateUser(string name)
        {
            string insertQuery = """
                INSERT INTO users([name])
                VALUES(@name);
                """;

            try
            {
                using SqlConnection connection = new SqlConnection(DataInformation.connectionString);
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", name);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось выполнить создание пользователя");
            }
        }

        public DataTable ReadUsers()
        {
            string selectQuery = """
                SELECT
                	*
                FROM users
                """;

            try
            {
                using SqlConnection connection = new SqlConnection(DataInformation.connectionString);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось выполнить чтение данных");
                return null!;
            }
        }

        public void UpdateUser(int user_id, string name) {
            try
            {
                using SqlConnection connection = new SqlConnection(DataInformation.connectionString);

                string query = "UPDATE users SET [name] = @name WHERE [user_id] = @user_id";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@user_id", user_id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить данные пользовтеля");
            }
        }

        public void DeleteUser(int user_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataInformation.connectionString))
                {
                    string query = "DELETE FROM users WHERE [user_id] = @user_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить пользователя");
            }
        }
    }
}
