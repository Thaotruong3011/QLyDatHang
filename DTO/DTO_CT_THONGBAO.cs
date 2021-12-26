using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CT_THONGBAO
    {
        public DTO_CT_THONGBAO(int matb1, string madt1, string ngaylap1, int mahd1){
            matb = matb1;
            madt = madt1;
            ngaylap = ngaylap1;
            mahd = mahd1;
        }
        public DTO_CT_THONGBAO()
        {
            matb =1;
            madt = " ";
            ngaylap = " ";
            mahd = 1;
        }
        public int matb;
    public string madt;
    public string ngaylap;
    public int mahd;
 }
}