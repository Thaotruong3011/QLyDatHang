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
    public partial class MH_QtriND : Form
    {
        DataTable DS_DT = new DataTable();
        public MH_QtriND()
        {
            InitializeComponent();
        }

        public MH_QtriND(string username, string password)
        {
            InitializeComponent();
            qtv.manv = username;
            qtv.pass = password;

        }
        public DTO_NHANVIEN qtv = new DTO_NHANVIEN();

        private void MH_QtriND_Load(object sender, EventArgs e)
        {
            DS_DT = BUS.DOITAC.getdsDoiTac_QTV(qtv.manv,qtv.pass);
            list.DataSource = DS_DT;
            QLyDoiTac.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void list_SelectionChanged(object sender, EventArgs e)
        {
            int indexChon = list.CurrentCell.RowIndex;
            if (indexChon != -1)
            {
                ma.Text = DS_DT.Rows[indexChon][0].ToString();
                pass2.Text = DS_DT.Rows[indexChon][1].ToString();
                soCN.Text = DS_DT.Rows[indexChon][2].ToString();
                ten2.Text = DS_DT.Rows[indexChon][3].ToString();
                nguoiDD.Text = DS_DT.Rows[indexChon][4].ToString();
                tp2.Text = DS_DT.Rows[indexChon][5].ToString();
                diachi.Text = DS_DT.Rows[indexChon][6].ToString();
                sdt2.Text = DS_DT.Rows[indexChon][7].ToString();
                email2.Text = DS_DT.Rows[indexChon][8].ToString();
            }
        }

        private void themdoitac_Click(object sender, EventArgs e)
        {
            string madt = ma.Text.Trim();
            string pass= pass2.Text.Trim();
            int  socn= Int32.Parse(soCN.Text.Trim());
            string tenDT= ten2.Text.Trim();
            string nguoiDDien= nguoiDD.Text.Trim();
            string thanhpho= tp2.Text.Trim();
            string diachikd= diachi.Text.Trim();
            string sdthoai= sdt2.Text.Trim();
            string emaill= email2.Text.Trim();

            BUS.DOITAC.ThemDT_QTV(qtv.manv, qtv.pass, madt, pass, socn, tenDT, nguoiDDien, thanhpho, diachikd, sdthoai, emaill);
            MessageBox.Show("Thêm đối tác mới thành công");
            
            DS_DT = BUS.DOITAC.getdsDoiTac_QTV(qtv.manv, qtv.pass);
            list.DataSource = DS_DT;
        }
    }
}
