using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLyDatHang
{
    public partial class MH_XemDSSP : Form
    {
        List<DTO_SANPHAM_DOITAC> listSP_DT;
        List<DTO_DOITAC> list_DT;
        public MH_XemDSSP()
        {
            InitializeComponent();
        }
        public MH_XemDSSP(string username,string password)
        {
            InitializeComponent();
            kh.email = username;
            kh.pass = password;
            
        }
        public DTO_KHACHHANG kh = new DTO_KHACHHANG();

        private void MH_XemDSSP_Load(object sender, EventArgs e)
        {
            listSP_DT = BUS.SANPHAM_DOITAC.getdsSPDoiTac(kh.email, kh.pass);
            lst_SanPham.DataSource = listSP_DT;
           
             list_DT=BUS.DOITAC.getdsDoiTac(kh.email, kh.pass);
            lst_DoiTac.DataSource= list_DT;
            MessageBox.Show(kh.email + "  " + kh.pass);
            MessageBox.Show(listSP_DT.Count()+ " ");
        }
    }
}
