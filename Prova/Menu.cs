using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prova
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert tt = new Insert();
            tt.MdiParent = this;
            tt.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update tt = new Update();
            tt.MdiParent = this;
            tt.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete tt = new Delete();
            tt.MdiParent = this;
            tt.Show();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTudo tt = new SelectTudo();
            tt.MdiParent = this;
            tt.Show();
        }
    }
}
