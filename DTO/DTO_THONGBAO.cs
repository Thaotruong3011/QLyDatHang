using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_THONGBAO
    {  public DTO_THONGBAO(int matb1, string mttb1)
        {
            matb = matb1;
            motatb = mttb1;
        }
        public DTO_THONGBAO()
        {
            matb = 0;
            motatb = " ";
        }
        public int matb;
        public string motatb;

    }
}
