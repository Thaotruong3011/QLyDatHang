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
        //List<DTO_SANPHAM_DOITAC> listSP_DT;
        //List<DTO_DOITAC> list_DT;
        DataTable DSSP_DT = new DataTable();
        DataTable DS_DT = new DataTable();
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
           
            //listSP_DT = BUS.SANPHAM_DOITAC.getdsSPDoiTac(kh.email, kh.pass);
           // DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoTen("tdhuy@gmailcom", "123456", " ");
            DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoTen(kh.email, kh.pass, " ");
            lst_SanPham.DataSource = DSSP_DT;

            // list_DT=BUS.DOITAC.getdsDoiTac(kh.email, kh.pass);
            //DS_DT = BUS.DOITAC.getdsDoiTac("tdhuy@gmailcom", "123456");
            DS_DT = BUS.DOITAC.getdsDoiTac(kh.email, kh.pass);
            lst_DoiTac.DataSource= DS_DT;
            MessageBox.Show(kh.email + "  " + kh.pass);
           // MessageBox.Show(listSP_DT.Count()+ " ");
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
                    //DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoTen("tdhuy@gmailcom", "123456", textSearch);
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
               // DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoDT("tdhuy@gmailcom", "123456",maDT);
                DSSP_DT = BUS.SANPHAM_DOITAC.TimKiemSPTheoDT(kh.email,kh.pass, maDT);
                lst_SanPham.DataSource = DSSP_DT;
            }

        }
    }
}
