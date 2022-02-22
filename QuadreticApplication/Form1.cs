using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibrary;

namespace QuadreticApplication
{
    public partial class Form1 : Form
    {
        Quadratic q = new Quadratic();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            q.a = Convert.ToSingle(textBox1.Text);
            q.b = Convert.ToSingle(textBox2.Text);
            q.c = Convert.ToSingle(textBox3.Text);
            textBoxItog.Text = Convert.ToString(q.Solve(out float[] x));
        }
    }
}
