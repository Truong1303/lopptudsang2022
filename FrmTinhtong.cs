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
    public partial class FrmTinhtong : Form
    {
        int i, N, T;
        public FrmTinhtong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LBLKQ_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt16(TXTN.Text);
            T = 0;
            while (i<=N)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
              
                }i++;
            }LBLKQ.Text = "ket qua tinh theo while la: " + Convert.ToString(T);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt16(TXTN.Text);
            T = 0;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }i++;
            } while (i <= N);
            LBLKQ.Text = "ket qua tinh theo do-while la: " + Convert.ToString(T);
        }

        private void kt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt16(TXTN.Text);
            T = 0;
            for (i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
            }LBLKQ.Text = "ket qua tinh theo for la: " + Convert.ToString(T);
        }
    }
}
