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
    public partial class MH_QlySP_DT : Form
    {
        DTO_DOITAC dt = new DTO_DOITAC();
        DataTable listSP_DT = new DataTable();
        
        public MH_QlySP_DT()
        {
            InitializeComponent();
        }
        public MH_QlySP_DT(string username,string password)
        {
            InitializeComponent();
            dt.madt = username;
            dt.pass = password;
            
        }

        private void MH_QlySP_DT_Load(object sender, EventArgs e)
        {
           
            listSP_DT = BUS.SANPHAM_DOITAC.getdsSPDoiTac_DT(dt.madt, dt.pass);
            list.DataSource = listSP_DT;
            doitac.Text = dt.madt;
        }
        public void Hienthi()
        {
            dt.madt = "DT001";
            dt.pass = "123456";
            listSP_DT = BUS.SANPHAM_DOITAC.getdsSPDoiTac_DT(dt.madt, dt.pass);
            list.DataSource = listSP_DT;
            doitac.Text = dt.madt;
        }

        private void list_SelectionChanged(object sender, EventArgs e)
        {
            int indexChon = list.CurrentCell.RowIndex;
            if (indexChon != -1)
            {
                ma.Text = listSP_DT.Rows[indexChon][1].ToString();
                mota.Text = listSP_DT.Rows[indexChon][2].ToString();
                gia.Text = listSP_DT.Rows[indexChon][4].ToString();
                masp.Text = listSP_DT.Rows[indexChon][0].ToString();
                sldh2.Text = listSP_DT.Rows[indexChon][3].ToString();
                slton2.Text = listSP_DT.Rows[indexChon][5].ToString();
                
            }
        }

        private void suattsp_Click(object sender, EventArgs e)
        {
            int indexChon = list.CurrentCell.RowIndex;
            if (indexChon != -1)
            {
                if (sldh2.Text != listSP_DT.Rows[indexChon][3].ToString())
                {
                    int sldh3 = Int32.Parse(sldh2.Text);
                    int masp2 = Int32.Parse(masp.Text);
                    BUS.SANPHAM_DOITAC.UpdateSLDH(dt.madt, dt.pass, sldh3, masp2, dt.madt);
                    Hienthi();
                }
                else if(slton2.Text != listSP_DT.Rows[indexChon][5].ToString())
                { int slton3 = Int32.Parse(slton2.Text);
                    int masp2 = Int32.Parse(masp.Text);
                    BUS.SANPHAM_DOITAC.UpdateSLTon(dt.madt, dt.pass, slton3,masp2 , dt.madt);
                    Hienthi();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MH_DangNhap mhDN = new MH_DangNhap();
            mhDN.Show();
            this.Hide();
        }
    }
}
