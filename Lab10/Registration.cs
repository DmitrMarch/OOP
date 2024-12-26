using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Registration : Form
    {
        private Form1 _form1;

        public Registration(Form1 form1, Login login)
        {
            InitializeComponent();

            _form1 = form1;
            login.Hide();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
