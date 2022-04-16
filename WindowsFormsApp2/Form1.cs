using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            {
                b.Parent = this;
                b.Size = new Size(300, 300);
                b.Location = new Point(250,30);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Height *= 2;
            button2.Height *= 2;
        }
    }
}
