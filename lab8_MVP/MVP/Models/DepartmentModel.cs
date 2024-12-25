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
    public class DepartmentModel
    {
        public void CreateDepartment(string title)
        {
            string insertQuery = """
                INSERT INTO departments(title)
                VALUES(@title);
                """;

            try
            {
                using SqlConnection connection = new SqlConnection(DataInformation.connectionString);
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@title", title);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось выполнить создание отдела");
            }
        }

        public DataTable ReadDepartments()
        {
            string selectQuery = """
                SELECT
                	*
                FROM departments
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

        public void UpdateDepartment(int department_id, string title)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(DataInformation.connectionString);

                string query = "UPDATE departments SET title = @title WHERE [department_id] = @department_id";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@department_id", department_id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить данные отдела");
            }
        }

        public void DeleteDepartment(int department_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataInformation.connectionString))
                {
                    string query = "DELETE FROM departments WHERE [department_id] = @department_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@department_id", department_id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить отдел");
            }
        }
    }
}
