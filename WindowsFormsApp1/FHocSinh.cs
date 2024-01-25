using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDao hsDao = new HocSinhDao();
        DBConnection dbC = new DBConnection();
        string sql = string.Format("SELECT *FROM HocSinh");
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM HocSinh");
               
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                gv1.DataSource = dtSinhVien; /// gvHsinh = name cua data gridview
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
            HocSinh hs = new HocSinh(txtTen.Text, txtDiachi.Text, txtCMND.Text, dtpnamSinh.Value);
            hsDao.SuaHS(txtCMND.Text,hs);
            gv1.DataSource = dbC.Load_Form(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtTen.Text, txtDiachi.Text, txtCMND.Text, dtpnamSinh.Value);
            hsDao.ThemHS(hs);
            gv1.DataSource = dbC.Load_Form(sql);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hsDao.XoaHS(txtCMND.Text);
            gv1.DataSource = dbC.Load_Form(sql);
        }

        private void gv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.gv1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtTen.Text = row.Cells[0].Value.ToString();
                txtDiachi.Text = row.Cells[1].Value.ToString();
                txtCMND.Text = row.Cells[2].Value.ToString();
                dtpnamSinh.Value = (DateTime)row.Cells[3].Value;
            }
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiangVien form2 = new FGiangVien();
            form2.ShowDialog();
        }
    }
}
