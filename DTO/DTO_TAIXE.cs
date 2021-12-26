using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TAIXE
    {   public DTO_TAIXE(string matx1, string biensoxe1, string kvhd1)
        {
            matx = matx1;
            biensoxe = biensoxe1;
            kvhd = kvhd1;
        }
        public DTO_TAIXE()
        {
            matx = " ";
            biensoxe = " ";
            kvhd = " ";
        }
        public string matx;
        public string biensoxe;
        public string kvhd;

    }
}
