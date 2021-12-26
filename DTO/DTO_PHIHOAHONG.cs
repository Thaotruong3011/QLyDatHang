using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PHIHOAHONG
    {   public DTO_PHIHOAHONG(int mahd1,int thang1, float sotien1,string nguoinhan1)
        {
            mahd = mahd1;
            thang = thang1;
            sotien = sotien1;
            nguoinhan = nguoinhan1;
        }
        public DTO_PHIHOAHONG()
        {
            mahd = 0;
            thang = 0;
            sotien = 0;
            nguoinhan = " ";
        }
        public int mahd;
        public int thang;
        public float sotien;
        public string nguoinhan;
    }
}
