using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class customTextbox : UserControl
    {
        public customTextbox()
        {
            InitializeComponent();
        }

        private string _text = "Text";
        public string CustomText
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                this.Invalidate();
            }
        }
        public string GetText()
        {
            return textBox1.Text;
        }
        public void SetText(string text)
        {
            textBox1.Text = text;
        }
        private void customTextbox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = _text;
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;

            if (textBox1.Focused)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);

                if (y <= 2)
                {
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 8);
                    y = 0;
                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 18)
                {
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 10);
                    y = 22;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }
    }
}
