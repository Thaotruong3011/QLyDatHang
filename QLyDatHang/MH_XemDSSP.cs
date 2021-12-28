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
        List<DTO_SANPHAM_DOITAC> listSP_DTChon= new List<DTO_SANPHAM_DOITAC>();
        //List<DTO_DOITAC> list_DT;
        DataTable DSSP_DT = new DataTable();
        DataTable DS_DT = new DataTable();
        DTO_SANPHAM_DOITAC sp_them=new DTO_SANPHAM_DOITAC();
        int sospchon = 0;
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
           
            
           
           DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoTen(kh.email, kh.pass, " ");
            lst_SanPham.DataSource = DSSP_DT;

           
            DS_DT = BUS.DOITAC.getdsDoiTac(kh.email, kh.pass);
            DS_DT = BUS.DOITAC.getdsDoiTac(kh.email, kh.pass);
            lst_DoiTac.DataSource= DS_DT;
            MessageBox.Show(kh.email + "  " + kh.pass);
         
        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            searchProduct.Enabled = true; 
            searchDT.BackColor = System.Drawing.Color.White;
            searchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
        }

        private void searchDT_Click(object sender, EventArgs e)
        {
            searchDT.Enabled = true;
            searchProduct.BackColor = System.Drawing.Color.White;
            searchDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm!");
            else
            { string textSearch = txtSearch.Text.Trim();
                if (searchProduct.BackColor ==System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(186)))), ((int)(((byte)(0))))))
                {
                    MessageBox.Show(" " + 0);
                    //Tim theo ten san pham
                    DataTable dt = new DataTable();
                    
                    DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoTen(kh.email,kh.pass, textSearch);
                    lst_SanPham.DataSource = DSSP_DT;
                    
                }
                else if(searchDT.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(186)))), ((int)(((byte)(0))))))
                {
                   
                    DS_DT = BUS.DOITAC.TimKiemDTTheoMa(kh.email, kh.pass, textSearch);
                    lst_DoiTac.DataSource = DS_DT;
                }
            }
        }

        private void XemSPTheoDT_Click(object sender, EventArgs e)
        {
            int indexChon = lst_DoiTac.CurrentCell.RowIndex;
            //MessageBox.Show(indexChon);
            if (indexChon != -1)
            {
                string maDT = DS_DT.Rows[indexChon][0].ToString();
               
                DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoDT(kh.email,kh.pass, maDT);
                lst_SanPham.DataSource = DSSP_DT;
            }

        }
       
        private void add_product_Click(object sender, EventArgs e)
        {
            int indexChon = lst_SanPham.CurrentCell.RowIndex;

            if (indexChon != -1)
            {
                DTO_SANPHAM_DOITAC sp_them = new DTO_SANPHAM_DOITAC();
                sp_them.madt = DSSP_DT.Rows[indexChon][1].ToString();
                sp_them.masp = Int32.Parse(DSSP_DT.Rows[indexChon][0].ToString());

                int flag = 0;
                for (int i = 0; i < listSP_DTChon.Count; i++)
                {
                    MessageBox.Show(listSP_DTChon[i].madt + "  " + listSP_DTChon[i].masp);
                    if (listSP_DTChon[i].madt == sp_them.madt)
                    {
                        if (listSP_DTChon[i].masp == sp_them.masp)
                        {
                            listSP_DTChon[i].soluong++;
                            flag = 1;
                            sospchon++;
                            sosp.Text = sospchon + " sản phẩm";
                        }
                    }
                }
                if (flag == 0)
                {
                    sp_them.mota = DSSP_DT.Rows[indexChon][2].ToString();
                    sp_them.sldh = Int32.Parse( DSSP_DT.Rows[indexChon][3].ToString());
                    sp_them.gia = float.Parse(DSSP_DT.Rows[indexChon][4].ToString());
                    sp_them.slton = Int32.Parse(DSSP_DT.Rows[indexChon][5].ToString());
                    sp_them.tensp = DSSP_DT.Rows[indexChon][6].ToString();
                    sp_them.soluong = 1;
                    listSP_DTChon.Add(sp_them);
                    sospchon++;
                    sosp.Text = sospchon + " sản phẩm";
                }
            }
           
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            MH_ThanhToan mhtt = new MH_ThanhToan(kh.email, kh.pass, listSP_DTChon);
            mhtt.Show();
        }

        private void DSDH_Click(object sender, EventArgs e)
        {
            
            MH_XemDSDH mhdsdh = new MH_XemDSDH(kh.email,kh.pass);
            mhdsdh.Show();
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
