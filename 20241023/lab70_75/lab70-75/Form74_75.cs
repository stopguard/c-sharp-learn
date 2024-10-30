using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab70_75
{
    public partial class Form74_75 : Form
    {
        public Form74_75()
        {
            InitializeComponent();
        }

        private void Form74_75_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text += e.KeyValue.ToString() + " ";
            label2.Text += e.KeyData.ToString() + " ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
