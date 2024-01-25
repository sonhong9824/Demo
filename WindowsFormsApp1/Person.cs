using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Person
    {
        private string ten;
        private string diaChi;
        private string cmnd;
        private DateTime dob;

        public Person(string ten, string diaChi, string cmnd, DateTime dob)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.cmnd = cmnd;
            this.dob = dob;
        }

        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}
