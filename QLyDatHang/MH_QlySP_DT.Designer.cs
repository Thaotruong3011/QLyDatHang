
namespace QLyDatHang
{
    partial class MH_QlySP_DT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.DataGridView();
            this.gia = new System.Windows.Forms.TextBox();
            this.mota = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slton2 = new System.Windows.Forms.TextBox();
            this.slton = new System.Windows.Forms.Label();
            this.masp = new System.Windows.Forms.TextBox();
            this.ten = new System.Windows.Forms.Label();
            this.sldh2 = new System.Windows.Forms.TextBox();
            this.sldh = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.suattsp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doitac = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 67);
            this.panel1.TabIndex = 24;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(545, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 29);
            this.exit.TabIndex = 20;
            this.exit.Text = "Đăng xuất";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "ShipForU";
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(94, 278);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(578, 124);
            this.list.TabIndex = 28;
            this.list.SelectionChanged += new System.EventHandler(this.list_SelectionChanged);
            // 
            // gia
            // 
            this.gia.Location = new System.Drawing.Point(323, 224);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(111, 20);
            this.gia.TabIndex = 62;
            // 
            // mota
            // 
            this.mota.Location = new System.Drawing.Point(323, 192);
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(111, 20);
            this.mota.TabIndex = 60;
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(323, 153);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(57, 20);
            this.ma.TabIndex = 59;
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sdt.Location = new System.Drawing.Point(281, 224);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(23, 13);
            this.sdt.TabIndex = 58;
            this.sdt.Text = "Giá";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.email.Location = new System.Drawing.Point(281, 192);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(34, 13);
            this.email.TabIndex = 56;
            this.email.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(273, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mã DT";
            // 
            // slton2
            // 
            this.slton2.Location = new System.Drawing.Point(545, 230);
            this.slton2.Name = "slton2";
            this.slton2.Size = new System.Drawing.Size(40, 20);
            this.slton2.TabIndex = 70;
            // 
            // slton
            // 
            this.slton.AutoSize = true;
            this.slton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.slton.Location = new System.Drawing.Point(463, 230);
            this.slton.Name = "slton";
            this.slton.Size = new System.Drawing.Size(67, 13);
            this.slton.TabIndex = 69;
            this.slton.Text = "Số lượng tồn";
            // 
            // masp
            // 
            this.masp.Location = new System.Drawing.Point(545, 154);
            this.masp.Name = "masp";
            this.masp.Size = new System.Drawing.Size(166, 20);
            this.masp.TabIndex = 68;
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ten.Location = new System.Drawing.Point(472, 157);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(39, 13);
            this.ten.TabIndex = 67;
            this.ten.Text = "Mã SP";
            // 
            // sldh2
            // 
            this.sldh2.Location = new System.Drawing.Point(545, 195);
            this.sldh2.Name = "sldh2";
            this.sldh2.Size = new System.Drawing.Size(166, 20);
            this.sldh2.TabIndex = 66;
            // 
            // sldh
            // 
            this.sldh.AutoSize = true;
            this.sldh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sldh.Location = new System.Drawing.Point(444, 198);
            this.sldh.Name = "sldh";
            this.sldh.Size = new System.Drawing.Size(96, 13);
            this.sldh.TabIndex = 65;
            this.sldh.Text = "Số lượng DH/ngày";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(111, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Tìm theo mã";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.Window;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(94, 220);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 23);
            this.button10.TabIndex = 77;
            this.button10.Text = "Thêm sản phẩm";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // suattsp
            // 
            this.suattsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(168)))));
            this.suattsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suattsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suattsp.ForeColor = System.Drawing.SystemColors.Window;
            this.suattsp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.suattsp.Location = new System.Drawing.Point(94, 180);
            this.suattsp.Name = "suattsp";
            this.suattsp.Size = new System.Drawing.Size(126, 23);
            this.suattsp.TabIndex = 76;
            this.suattsp.Text = "Sửa thông tin SP";
            this.suattsp.UseVisualStyleBackColor = false;
            this.suattsp.Click += new System.EventHandler(this.suattsp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "DS cung cấp SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Đối tác";
            // 
            // doitac
            // 
            this.doitac.AutoSize = true;
            this.doitac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doitac.Location = new System.Drawing.Point(566, 84);
            this.doitac.Name = "doitac";
            this.doitac.Size = new System.Drawing.Size(48, 13);
            this.doitac.TabIndex = 80;
            this.doitac.Text = "Đối tác";
            // 
            // MH_QlySP_DT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doitac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.suattsp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slton2);
            this.Controls.Add(this.slton);
            this.Controls.Add(this.masp);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.sldh2);
            this.Controls.Add(this.sldh);
            this.Controls.Add(this.gia);
            this.Controls.Add(this.mota);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list);
            this.Controls.Add(this.panel1);
            this.Name = "MH_QlySP_DT";
            this.Text = "Quản Lý Sản phẩm- Đối tác";
            this.Load += new System.EventHandler(this.MH_QlySP_DT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.TextBox gia;
        private System.Windows.Forms.TextBox mota;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox slton2;
        private System.Windows.Forms.Label slton;
        private System.Windows.Forms.TextBox masp;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.TextBox sldh2;
        private System.Windows.Forms.Label sldh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button suattsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label doitac;
    }
}