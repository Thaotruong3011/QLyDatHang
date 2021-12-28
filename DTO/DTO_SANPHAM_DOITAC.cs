using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SANPHAM_DOITAC
    { 
        public DTO_SANPHAM_DOITAC(string madt1, int masp1, string mota1, int sldh1, int slton1, float gia1)
        {
            madt = madt1;
            masp = masp1;
            mota = mota1;
            sldh = sldh1;
            slton = slton1;
            gia = gia1;
        }
        public DTO_SANPHAM_DOITAC()
        {
            madt = " ";
            masp = 0;
            mota = " ";
            sldh = 0;
            slton = 0;
            gia = 0;
        }
        public string madt { get; set; }
        public int masp { get; set; }
        public string mota { get; set; }
        public int sldh { get; set; }
        public int slton { get; set; }
        public float gia { get; set; }
        //note: them tensp cho tien thoi, dung xoa
        public string tensp { get; set; }
        public int soluong { get; set; }
    }
}
