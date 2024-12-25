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
    public partial class OrderView : Form, IOrderView
    {
        public OrderView()
        {
            InitializeComponent();
            var model = new OrderModel();
            var presenter = new OrderPresenter(this, model);
        }

        public string OrderTitle
        {
            get { return tbTitle.GetText(); }
            set { tbTitle.SetText(value); }
        }
        public int OrderId
        {
            get;
            set;
        }
        public int UserId
        {
            get { return Convert.ToInt32(numericUpDown1.Value); }
            set { numericUpDown1.Value = value; }
        }
        public int DepartmentId
        {
            get { return Convert.ToInt32(numericUpDown2.Value); }
            set { numericUpDown2.Value = value; }
        }

        public event EventHandler AddOrder;
        public event EventHandler UpdateOrder;
        public event EventHandler DeleteOrder;
        public event EventHandler ViewOrders;

        public void DisplayOrders(DataTable orders)
        {
            dataGridView1.DataSource = orders;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTitle.GetText().Length < 1)
            {
                MessageBox.Show("Нужно заполнить поле названия");
                return;
            }

            AddOrder.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrderId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                DeleteOrder.Invoke(sender, e);
                return;
            }

            MessageBox.Show("Выберите строку в таблице для удаления данных");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrderId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateOrder.Invoke(sender, e);
                return;
            }

            MessageBox.Show("Выберите строку в таблице для обновления данных");
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            ViewOrders.Invoke(sender, e);
        }
    }
}
