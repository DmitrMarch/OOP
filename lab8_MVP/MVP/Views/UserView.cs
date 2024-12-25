using MVP.Models;
using MVP.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UserView : Form, IUserView
    {
        public UserView()
        {
            InitializeComponent();

            var model = new UserModel();
            var presenter = new UserPresenter(this, model);
        }

        public string UserName
        {
            get { return tbName.GetText(); }
            set { tbName.SetText(value); }
        }
        public int UserId { get; set; }

        public event EventHandler AddUser;
        public event EventHandler UpdateUser;
        public event EventHandler DeleteUser;
        public event EventHandler ViewUsers;

        public void DisplayUsers(DataTable users)
        {
            dataGridView1.DataSource = users;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.GetText().Length < 1)
            {
                MessageBox.Show("Нужно заполнить поле имени");
                return;
            }

            AddUser.Invoke(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UserId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateUser.Invoke(sender, e);
                return;
            }

            MessageBox.Show("Выберите строку в таблице для обновления данных");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UserId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                DeleteUser.Invoke(sender, e);
                return;
            }

            MessageBox.Show("Выберите строку в таблице для удаления данных");
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            ViewUsers.Invoke(sender, e);
        }
    }
}
