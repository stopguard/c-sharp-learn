using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab70_75
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lab70_71_Click(object sender, EventArgs e)
        {
            Form70_71 newForm = new Form70_71();
            newForm.Show();
        }

        private void lab72_73_Click(object sender, EventArgs e)
        {
            Form72_73 newForm = new Form72_73();
            newForm.Show();
        }

        private void lab74_75_Click(object sender, EventArgs e)
        {
            Form74_75 newForm = new Form74_75();
            newForm.Show();
        }
    }
}
