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
namespace QLyDatHang
{
    public partial class MH_XemDSDH : Form
    {
        DTO_KHACHHANG kh = new DTO_KHACHHANG();
        DataTable LstDH = new DataTable();
        DataTable LstCTDH = new DataTable();
        public MH_XemDSDH()
        {
            InitializeComponent();
        }
        public MH_XemDSDH(string username,string password)
        {
            InitializeComponent();
            kh.email = username;
             kh.pass = password;
        }

        private void MH_XemDSDH_Load(object sender, EventArgs e)
        {
             LstDH= BUS.DONHANG.XemDSDH_KH(kh.email, kh.pass);
            lstDonHang.DataSource = LstDH;
            LstCTDH = BUS.CT_DONHANG.XemDSCTDH_KH(kh.email, kh.pass);
            lstCTDH.DataSource = LstCTDH;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MH_XemDSSP xemDSSP = new MH_XemDSSP(kh.email, kh.pass);
            xemDSSP.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MH_DangNhap mhDN = new MH_DangNhap();
            mhDN.Show();
            this.Hide();
        }
    }
}
