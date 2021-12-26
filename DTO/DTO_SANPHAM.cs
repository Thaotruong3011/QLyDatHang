using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SANPHAM
    {
        public DTO_SANPHAM(int masp1, string tensp1, int tongsl1, string loaihang1,int sldt1)
        {
            masp = masp1;
            tensp = tensp1;
            tongsl = tongsl1;
            loaihang = loaihang1;
            sldoitac = sldt1;
        }
        public DTO_SANPHAM()
        {
            masp = 0;
            tensp = " ";
            tongsl = 0;
            loaihang = " ";
            sldoitac = 0;
        }
        public int masp;
        public string tensp;
        public int tongsl;
        public string loaihang;
        public int sldoitac ;

    }
}
