using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class BUS_Luong
    {
        private static BUS_Luong instance;

        public static BUS_Luong Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_Luong();
                return instance;
            }
        }

        private BUS_Luong() { }
        public void Xem(DataGridView data)
        {
            //data.DataSource = DAL_Luong.Instance.Xem();
        }
    }
}
