using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace lopptudsang2022
{
    public partial class frmDMHanghoa2 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string Sql, constr;
        int i;
        public frmDMHanghoa2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDMHanghoa2_Load(object sender, EventArgs e)
        {   constr = "Data Source=LAPTOP-CUA-TRUO\\SQLEXPRESS;Initial Catalog=QUANLYBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            Sql = "select * from tblDMHH";
            da = new SqlDataAdapter(Sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            NapCT();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void NapCT ()
        {
            i = dataGridView.CurrentRow.Index;
            txtManhom.Text = dataGridView.Rows[i].Cells["MaNhom"].Value.ToString();
            txtMahang.Text = dataGridView.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenhang.Text = dataGridView.Rows[i].Cells["TenHH"].Value.ToString();
            txtDvt.Text = dataGridView.Rows[i].Cells["dvt"].Value.ToString();
            txtDongia.Text =dataGridView.Rows[i].Cells["dgvnd"].Value.ToString();
            txtNuocsx.Text = dataGridView.Rows[i].Cells["sanxuat"].Value.ToString();
            

        }
    }
}
