using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnKi4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void lịchSửSửaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)   //cai nay la sua diem nha
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void xemĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lịchSửSửaĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void xemĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ýKiếnVềĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void thêmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void xoáHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
