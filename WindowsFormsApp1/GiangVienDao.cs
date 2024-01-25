using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class GiangVienDao
    {
        DBConnection dbC = new DBConnection();
        public void ThemGV(GiangVien gvien)
        {
            string sql = string.Format("INSERT INTO GiangVien(Ten , Diachi, CMND,DoB) VALUES ('{0}', '{1}', '{2}','{3}')", gvien.Ten, gvien.DiaChi, gvien.Cmnd, gvien.Dob);
            dbC.ThucThi(sql);
        }
        public void XoaGV(string cmnd)
        {
            string sql = string.Format("DELETE FROM GiangVien WHERE CMND = {0}", cmnd);
            dbC.ThucThi(sql);
        }
        public void SuaGV(GiangVien gvien)
        {
            string sql = string.Format("UPDATE GiangVien SET Ten = '{0}', DiaChi ='{1}', DoB = '{2}' WHERE CMND = {3}", gvien.Ten, gvien.DiaChi, gvien.Dob, gvien.Cmnd);
            dbC.ThucThi(sql);
        }
        public DataTable Load_Form()
        {
            string sqlStr = string.Format("SELECT *FROM GiangVien");
            return dbC.Load_Form(sqlStr);
        }
    }
}