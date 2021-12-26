using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CHINHANH
    {   public DTO_CHINHANH(int macn1,string tencn1,string diachi1)
        {
            macn = macn1;
            tencn = tencn1;
            diachi = diachi1;
        }
        public DTO_CHINHANH()
        {
            macn = 1;
            tencn = " ";
            diachi = " ";
        }
        public int macn;
        public string tencn;
        public string diachi;
    }
}
