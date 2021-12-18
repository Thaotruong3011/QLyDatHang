using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DTO;
using BUS;
namespace QuanLy_BanHang
{
    public partial class ThemHoaDon : Form
    {
        //List<DTO_SanPham> lstSanPham;
        //List<DTO_SanPham> lstSanPhamChon=new List<DTO_SanPham>();
        public ThemHoaDon()
        {
            InitializeComponent();
            //ThemHD_load();
        }
        //private void ThemHD_load()
        //{   lstSanPham= SanPham.getDSSanPham();
        //    dsSanPham.DataSource = lstSanPham;
        //    ds_SPChon.Columns.Add("MaSP", "MaSP");
        //    ds_SPChon.Columns[0].ReadOnly = true;
        //    ds_SPChon.Columns.Add("TenSP", "Ten SP");
        //    ds_SPChon.Columns[1].ReadOnly = true;
        //    ds_SPChon.Columns.Add("GiaBan", "Gia Ban");
        //    ds_SPChon.Columns[2].ReadOnly = true;
        //    ds_SPChon.Columns.Add("SLMua", "SL Mua");
        //    ds_SPChon.Columns.Add("GiaGiam", "Gia Giam Tung SP");
        //    ds_SPChon.Columns[4].ReadOnly = true;

        //    ds_SPChon.Visible = false;

        //}
        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void dsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void statistics_Button_Click(object sender, EventArgs e)
        //{
        //    var formTKDT = new XemTKDoanhThu();
        //    formTKDT.Show();
        //}

        //private void invoice_Click(object sender, EventArgs e)
        //{
        //    var formDSHD = new XemDSHoaDon();
        //    formDSHD.Show();
        //}

        //private void exit_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void ThemSP_Click(object sender, EventArgs e)
        //{
        //    int slSP = 0;
        //    ds_SPChon.Visible = true;
        //    DTO_SanPham SPChon = lstSanPham[dsSanPham.CurrentCell.RowIndex];
        //    lstSanPhamChon.Add(SPChon);
        //    for(int i = 0; i < lstSanPhamChon.Count(); i++)
        //    {
        //        if (SPChon.MaSP == lstSanPhamChon[i].MaSP)
        //        {
        //            slSP++;
        //        }
        //    }
        //    if (slSP==1) {
        //        DataGridViewRow row = (DataGridViewRow)ds_SPChon.Rows[0].Clone();
        //        row.Cells[3].Value = 1;
        //        row.Cells[0].Value = SPChon.MaSP;
        //        row.Cells[1].Value = SPChon.TenSP;
        //        row.Cells[2].Value = SPChon.Gia;
        //        if (SPChon.MoTa == "Giam gia")
        //        {
        //            row.Cells[4].Value = SPChon.Gia * 0.1;
        //        }
        //        else row.Cells[4].Value = 0;
        //        ds_SPChon.Rows.Add(row);

        //    }
        //    else
        //    {


        //        //string oldSL = ds_SPChon[3, rowIndex].Value.ToString();
        //        //int oldSLInt;
        //        //Int32.TryParse(oldSL, out oldSLInt);
        //        //MessageBox.Show(oldSL);
        //        //ds_SPChon[3, rowIndex].Value = oldSLInt+1;
        //    }
        //}

        //private void saveButton_Click(object sender, EventArgs e)
        //{
        //    if (lstSanPhamChon.Count > 0)
        //    {
        //        if (validateTTHoaDon())
        //        {   
        //            DialogResult dialogResult = MessageBox.Show("Chắc chắn lưu thông tin?", "Thông báo", MessageBoxButtons.YesNo);
        //            if (dialogResult == DialogResult.Yes)
        //            {
        //                taoHoaDon();
        //                taoCTHoaDon();
        //                MessageBox.Show("Thêm hóa đơn thành công!");
        //            }

        //        }

        //    }
        //    else MessageBox.Show("Chưa có dữ liệu sản phẩm");

        //}
        //private void taoHoaDon()
        //{
        //    HoaDon.TaoHD(txtMaDH.Text, txtMaKH.Text, dateTime.Value);
        //}
        //private void taoCTHoaDon()
        //{
        //    string maHD = txtMaDH.Text;
        //    foreach (DataGridViewRow row in ds_SPChon.Rows)
        //    {
        //        if (row.Cells["MaSP"].Value != null&& row.Cells["GiaBan"].Value!=null&& row.Cells["GiaGiam"].Value != null&& row.Cells["SLMua"].Value != null)
        //        {
        //            string maSP = row.Cells["MaSP"].Value.ToString();
        //            string giaBan = row.Cells["GiaBan"].Value.ToString();
        //            string giaGiam = row.Cells["GiaGiam"].Value.ToString();
        //            string SLMua = row.Cells["SLMua"].Value.ToString();
        //            int SLMuaInt;
        //            Int32.TryParse(SLMua.Trim(), out SLMuaInt);
        //            float giaBanFloat = float.Parse(giaBan, CultureInfo.InvariantCulture.NumberFormat);
        //            float giaGiamFloat = float.Parse(giaGiam, CultureInfo.InvariantCulture.NumberFormat);

        //            CTHoaDon.TaoCTHoaDon(maHD, maSP, SLMuaInt, giaBanFloat, giaGiamFloat);


        //            //    if (row.Cells["MaSP"].Value.ToString().Equals(maSP))
        //            //    {
        //            //        rowIndex = row.Index;
        //            //        break;
        //            //    }
        //            //}
        //        }
        //    }
        //}
        //private bool validateTTHoaDon()
        //{
        //    TenKH.Visible = false;
        //    if (txtMaKH.Text.Trim().Length == 0 || txtMaDH.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Có ô trống dữ liệu, mời điền đầy đủ!");
        //        return false ;
        //    }
        //    else
        //    {
        //        List<DTO_KhachHang> KH = KhachHang.getDSKhachHangTheoMa(txtMaKH.Text.Trim());
        //        List<DTO_HoaDon> HD = HoaDon.getDSHoaDonTheoMa(txtMaDH.Text.Trim());
        //        if (KH.Count() == 0) MessageBox.Show("Mã khách hàng không tồn tại!");
        //        else if (HD.Count() != 0) MessageBox.Show("Mã hóa đơn đã tồn tại!");
        //        else
        //        {
        //            TenKH.Visible = true;
        //            TenKH.Text = KH[0].Ho + KH[0].Ten;
        //            MessageBox.Show("Hiển thị tên khách hàng thành công!");
        //            return true;
        //        }
        //        return false;

        //    }

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(ds_SPChon[3, 0].Value.ToString());
        //}
        ////KH70072 HD99999


        ////private int findRowIndexInSPChon(string maSP)
        ////{     

        ////    int rowIndex = -1;
        ////        foreach (DataGridViewRow row in ds_SPChon.Rows)
        ////        {
        ////            if (row.Cells["MaSP"].Value != null) 
        ////            {
        ////                if (row.Cells["MaSP"].Value.ToString().Equals(maSP))
        ////                {
        ////                    rowIndex = row.Index;
        ////                    break;
        ////                }
        ////            }
        ////        }

        ////    return rowIndex;
        ////}


    }
}
