using lab8.Other;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Models
{
    public class OrderModel
    {
        public void CreateOrder(string title, int user_id, int department_id)
        {
            string insertQuery = """
                INSERT INTO orders(title, [user_id], [department_id])
                VALUES(@title, @user_id, @department_id);
                """;

            try
            {
                using SqlConnection connection = new SqlConnection(DataInformation.connectionString);
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@user_id", user_id);
                    command.Parameters.AddWithValue("@department_id", department_id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось выполнить создание заказа");
            }
        }

        public DataTable ReadOrders()
        {
            string selectQuery = """
                SELECT
                	*
                FROM orders
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

        public void UpdateOrder(int user_id, int department_id, int order_id, string title)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(DataInformation.connectionString);

                string query = "UPDATE orders SET title, user_id, department_id = @title, user_id = @user_id, department_id = @department_id WHERE [order_id] = @order_id";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@department_id", department_id);
                cmd.Parameters.AddWithValue("@order_id", order_id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить данные заказа");
            }
        }

        public void DeleteUser(int order_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataInformation.connectionString))
                {
                    string query = "DELETE FROM orders WHERE [order_id] = @order_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@order_id", order_id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить заказ");
            }
        }
    }
}
