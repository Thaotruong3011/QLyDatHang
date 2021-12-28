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
    public partial class MH_QLySanPhamQTV : Form
    {
        DataTable DSSP_DT = new DataTable();
        DataTable DS_SP = new DataTable();
        public MH_QLySanPhamQTV()
        {
            InitializeComponent();
        }
        public MH_QLySanPhamQTV(string username, string password)
        {
            InitializeComponent();
            qtv.manv = username;
            qtv.pass = password;
           
        }
        public DTO_NHANVIEN qtv = new DTO_NHANVIEN();

        private void MH_QLySanPhamQTV_Load(object sender, EventArgs e)
        {
           DS_SP=BUS.SANPHAM.getdsSP(qtv.manv,qtv.pass);
            LstSP.DataSource = DS_SP;
            DSSP_DT = BUS.SANPHAM_DOITAC.getdsSPDoiTac(qtv.manv, qtv.pass);
            lstSPDT.DataSource = DSSP_DT;
        }

        private void LstSP_SelectionChanged(object sender, EventArgs e)
        {
            int indexChon = LstSP.CurrentCell.RowIndex;
            if (indexChon != -1)
            {
                masp.Text = DS_SP.Rows[indexChon][0].ToString();
                tensp.Text= DS_SP.Rows[indexChon][1].ToString();
                tongsl.Text= DS_SP.Rows[indexChon][2].ToString();
                loaihang.Text = DS_SP.Rows[indexChon][3].ToString();
                sldoitac.Text= DS_SP.Rows[indexChon][4].ToString();
            }
        }

        private void suaSP_Click(object sender, EventArgs e)
        {
            string tenSua = tensp.Text;
            int maSP = Int32.Parse(masp.Text);
            BUS.SANPHAM.updateTenSP(qtv.manv, qtv.pass, maSP, tenSua);
            MessageBox.Show("Đã thay đổi thông tin sản phẩm");
            DS_SP = BUS.SANPHAM.getdsSP(qtv.manv, qtv.pass);
            LstSP.DataSource = DS_SP;
        }

        private void QTND_Click(object sender, EventArgs e)
        {
            MH_QtriND QTND = new MH_QtriND(qtv.manv,qtv.pass);
            QTND.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MH_DangNhap mhDN = new MH_DangNhap();
            mhDN.Show();
            this.Hide();
        }
    }
}
