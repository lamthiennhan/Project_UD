using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Luong
    {
        private static DAL_Luong instance;

        public static DAL_Luong Instance
        {
            get {
                if (instance == null)
                    instance = new DAL_Luong();
                return instance;
            }
        }

        private DAL_Luong() { }

        public List<Luong> Xem()
        {
            List<Luong> Luong = new List<Luong>();
            
            return Luong;
        }
    }
}
