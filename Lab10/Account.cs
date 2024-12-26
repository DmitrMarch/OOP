using System;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Account : Form
    {
        private Form1 _form1;

        public Account(Form1 form1)
        {
            InitializeComponent();

            _form1 = form1;
            _form1.Hide();

            loginLabel.Text = _form1.UserName;
            roleLabel.Text = _form1.RoleName;

            if (_form1.RoleName == "админ")
            {
                noPower.Visible = false;

                string log_file = _form1.readLog();
                string[] events = log_file.Split(new string[] { "\n" }, StringSplitOptions.None);

                foreach (string e in events)
                {
                    string[] fields = e.Split(new string[] { "; " }, StringSplitOptions.None);

                    eventsTbl.Rows.Add(fields);
                }

                return;
            }

            eventsTbl.Visible = false;
        }

        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
    }
}
