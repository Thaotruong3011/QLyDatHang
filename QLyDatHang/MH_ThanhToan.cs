using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QLyDatHang
{
    public partial class MH_ThanhToan : Form
    {  DTO_KHACHHANG kh = new DTO_KHACHHANG();
        List<DTO_SANPHAM_DOITAC> lstSP_DTChon = new List<DTO_SANPHAM_DOITAC>();
        float TongTien = 0;
        double TongTB = 0;
        
        
        public MH_ThanhToan()
        {
            InitializeComponent();
        }
        public MH_ThanhToan(string username, string password, List<DTO_SANPHAM_DOITAC> lstsp)
        {
            InitializeComponent();
            kh.email = username;
            kh.pass = password;
            kh.email = "tdhuy@gmailcom";
            kh.pass = "123456";
            lstSP_DTChon = lstsp;
        }

        private void MH_ThanhToan_Load(object sender, EventArgs e)
        {
            lstSP.DataSource = lstSP_DTChon;
            tinhTongTien();
            tongdh.Text = TongTien.ToString();
            double phitienvc = TongTien * 0.1;
             phivc.Text = phitienvc.ToString();
            TongTB = TongTien + phitienvc;
            giatong.Text = TongTB.ToString();
            makh.Text = kh.email;
        }
        private void tinhTongTien()
        {
            for(int i = 0; i < lstSP_DTChon.Count; i++)
            {
                TongTien += lstSP_DTChon[i].gia * lstSP_DTChon[i].soluong;
               
            }
        }

        private void DatHang_Click(object sender, EventArgs e)
        {
            string dchigiao = dcgiao.Text;
            DateTime ngaygiao = ngay.Value;
            string ngaygiao2 = ngaygiao.Date.ToString();
            MessageBox.Show(ngaygiao2);
            string httt = hinhthuctt.Text;
            string tinhtrang=" ";
            if(httt== "Thanh toán tiền mặt")
            {
                tinhtrang = "Đã thanh toán";
            }
            else if(httt == "Thanh toán bằng thẻ")
            {
                tinhtrang = "Đã thanh toán";
            }
            else if(httt== "COD")
            {
                tinhtrang = "Chưa thanh toán";
            }
           BUS.DONHANG.ThemDH(kh.email,kh.pass,ngaygiao, TongTB, dchigiao, httt, tinhtrang,lstSP_DTChon);
            MH_XemDSDH xemdsdh = new MH_XemDSDH(kh.email,kh.pass);
            xemdsdh.Show();
            this.Close();
        }
    }
}
