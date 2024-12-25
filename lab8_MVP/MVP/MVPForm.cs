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
    public partial class MVPForm : Form
    {
        public MVPForm()
        {
            InitializeComponent();
        }

        private void MVPForm_Load(object sender, EventArgs e)
        {
            loadform(new UserView());
        }

        private void loadform(object form)
        {
            if (this.panelmain.Controls.Count > 0)
            {
                this.panelmain.Controls.RemoveAt(0);
            }

            Form? f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelmain.Controls.Add(f);
            this.panelmain.Tag = f;
            f.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            loadform(new UserView());
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            loadform(new DepartmentView());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            loadform(new OrderView());
        }
    }
}
