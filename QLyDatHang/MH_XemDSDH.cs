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
            
        }
    }
}
