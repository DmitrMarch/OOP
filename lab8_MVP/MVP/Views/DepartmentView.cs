using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace MVP.Views
{
    public partial class DepartmentView : Form, IDepartmentView
    {
        public DepartmentView()
        {
            InitializeComponent();

            var model = new DepartmentModel();
            var presenter = new DepartmentPresenter(this, model);
        }

        public string DepartmentTitle
        {
            get { return tbTitle.GetText(); }
            set { tbTitle.SetText(value); }
        }
        public int DepartmentId { get; set; }

        public event EventHandler AddDepartment;
        public event EventHandler UpdateDepartment;
        public event EventHandler DeleteDepartment;
        public event EventHandler ViewDepartments;

        public void DisplayDepartments(DataTable departments)
        {
            dataGridView1.DataSource = departments;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTitle.GetText().Length < 1)
            {
                MessageBox.Show("Нужно заполнить поле названия");
                return;
            }

            AddDepartment.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DepartmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                DeleteDepartment.Invoke(sender, e);
                return;
            }

            MessageBox.Show("Выберите строку в таблице для удаления данных");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DepartmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateDepartment.Invoke(sender, e);
                return;
            }

            MessageBox.Show("Выберите строку в таблице для обновления данных");
        }

        private void DepartmentView_Load(object sender, EventArgs e)
        {
            ViewDepartments.Invoke(sender, e);
        }
    }
}
