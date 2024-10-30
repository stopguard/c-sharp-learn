using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lab70_75
{
    public partial class Form72_73 : Form
    {
        public Form72_73()
        {
            InitializeComponent();
        }

        private void Form72_73_Load(object sender, EventArgs e)
        {

        }

        private Int16 formNum = 1;

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form newmdichild = new Form72_73form2(formNum.ToString());
            formNum += 1;
            newmdichild.MdiParent = this;
            newmdichild.Show();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
                formNum = 1;
            }

        }

        private void buttonVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void buttonHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void buttonCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

    }
}
