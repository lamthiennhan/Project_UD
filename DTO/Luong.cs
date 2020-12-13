using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Luong
    {
        private string ma;
        private string ten;
        private int luongCB;
        private int luongPC;

        public Luong(string ma, string ten, int luongCB, int luongPC)
        {
            this.ma = ma;
            this.ten = ten;
            this.luongCB = luongCB;
            this.luongPC = luongPC;
        }

        public string getMa
        {
            get { return this.ma; }
            set { this.ma = value; }
        }

        public string getTen
        {
            get { return this.ten; }
            set { this.ten = value; }
        }

        public int getluongCB
        {
            get { return this.luongCB; }
            set { this.luongCB = value; }
        }

        public int getLuongPC
        {
            get { return this.luongPC; }
            set { this.luongPC = value; }
        }
    }
}
