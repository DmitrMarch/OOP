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
    public partial class Login : Form
    {
        private Form1 _form1;

        public Login(Form1 form1)
        {
            InitializeComponent();

            _form1 = form1;
            _form1.Hide();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            _form1.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(_form1, this);
            registration.Show();
        }
    }
}
