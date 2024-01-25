using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class HocSinhDao
    {
        DBConnection dbC = new DBConnection();

        public void ThemHS(HocSinh hs)
        {
            string sql = string.Format("INSERT INTO HocSinh(Ten , Diachi, CMND, DoB) VALUES ('{0}', '{1}', '{2}','{3}')", hs.Ten, hs.DiaChi, hs.Cmnd, hs.Dob);
            dbC.ThucThi(sql);
        }
        public void XoaHS(string cmnd)
        {
            string sql = string.Format("DELETE FROM HocSinh WHERE CMND = {0}", cmnd);
            dbC.ThucThi(sql);
        }
        public void SuaHS(string cmnd, HocSinh hs)
        {
            string sql = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi ='{1}', DoB = '{2}' WHERE CMND = {3}", hs.Ten, hs.DiaChi, hs.Dob, cmnd);
            dbC.ThucThi(sql);
        }
        public DataTable Load_Form()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            return dbC.Load_Form(sqlStr);
        }
    }
}
