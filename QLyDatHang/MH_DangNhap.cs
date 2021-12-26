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
    public partial class MH_DangNhap : Form
    {
        public MH_DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS.LOGIN lg = new BUS.LOGIN();
            DataTable t = lg.con(txbUserName.Text.ToString(), txbPassword.Text.ToString());
            
            if (t.Rows.Count == 0)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu sai, vui lòng thử lại!");
               
            }
            else if (txbUserName.Text.ToString().IndexOf("@") != -1)
            {
                
                MH_XemDSSP xemdssp = new MH_XemDSSP(txbUserName.Text.ToString(),txbPassword.Text.ToString());
                //txbusername.text.tostring()
                xemdssp.Show();
                this.Hide();
            }
            //else if (t.rows[0][0].tostring().indexof("nv") != -1)
            //{
            //    //mh_xemdssp xemdssp = new mh_xemdssp();
            //    ////txbusername.text.tostring()
            //    //xemdssp.show();
            //    //this.hide();
            //}
            //else if (t.rows[0][0].tostring().indexof("DT") != -1)
            //{
            //    //mh_xemdssp xemdssp = new mh_xemdssp();
            //    ////txbusername.text.tostring()
            //    //xemdssp.show();
            //    //this.hide();
            //}



            //Application.Run(new MH_QLySanPhamQTV());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MH_QtriND qlnv= new MH_QtriND();
            qlnv.Show();
            this.Hide();
            //Application.Run(new MH_QtriND());
        }
    }
}
