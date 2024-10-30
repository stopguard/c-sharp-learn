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
    public partial class Form70_71 : Form
    {
        public Form70_71()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form70_71 newForm1 = new Form70_71();
            newForm1.Show();

            Form2 newForm2 = new Form2(newForm1);
            newForm2.Show();

        }

        private void Form70_71_Load(object sender, EventArgs e)
        {

        }
    }
}
