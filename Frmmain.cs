using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lopptudsang2022
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Hello world";
            Form1 f = new Form1();
            f.ShowDialog();
            status1.Text = "San sang nhan lenh";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {   
            FrmTinhtong f = new FrmTinhtong();
            f.Show();
        }

        private void đăngKíTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {   frmDangnhap f = new frmDangnhap();
            f.Show();

        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {   frmDangnhap f = new frmDangnhap();
            f.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmDangnhap f = new frmDangnhap();
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status2.Text = System.DateTime.Now.ToString();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHanghoa2 f = new frmDMHanghoa2();
            f.Show();
        }

        private void danhMụcTừĐiểnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
