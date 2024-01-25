using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FGiangVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiangVienDao gvDao = new GiangVienDao();
        DBConnection dbC = new DBConnection();
        string sql = string.Format("SELECT *FROM GiangVien");
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHocSinh form1 = new FHocSinh();
            form1.ShowDialog();
        }

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM GiangVien");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtGiangVien = new DataTable();
                adapter.Fill(dtGiangVien);
                gv2.DataSource = dtGiangVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVien gvien = new GiangVien(txtTen.Text, txtDiachi.Text, txtCMND.Text, dtpnamSinh.Value);
            gvDao.SuaGV(gvien);
            gv2.DataSource = dbC.Load_Form(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gvien = new GiangVien(txtTen.Text, txtDiachi.Text, txtCMND.Text, dtpnamSinh.Value);
            gvDao.ThemGV(gvien);
            gv2.DataSource = dbC.Load_Form(sql);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gvDao.XoaGV(txtCMND.Text);
            gv2.DataSource = dbC.Load_Form(sql);
        }

        private void gv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.gv2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtTen.Text = row.Cells[0].Value.ToString();
                txtDiachi.Text = row.Cells[1].Value.ToString();
                txtCMND.Text = row.Cells[2].Value.ToString();
                dtpnamSinh.Value = (DateTime)row.Cells[3].Value;
            }
        }
    }
}
