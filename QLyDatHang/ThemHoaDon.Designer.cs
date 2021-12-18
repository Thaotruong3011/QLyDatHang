
namespace QuanLy_BanHang
{
    partial class ThemHoaDon
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
            this.dsSanPham = new System.Windows.Forms.DataGridView();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invoice = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.statistics_Button = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemSP = new System.Windows.Forms.Button();
            this.ds_SPChon = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SPChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSanPham
            // 
            this.dsSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dsSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSanPham.Location = new System.Drawing.Point(12, 147);
            this.dsSanPham.Name = "dsSanPham";
            this.dsSanPham.RowHeadersWidth = 51;
            this.dsSanPham.Size = new System.Drawing.Size(422, 238);
            this.dsSanPham.TabIndex = 41;
            //this.dsSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsSanPham_CellContentClick);
            // 
            // dateTime
            // 
            this.dateTime.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTime.Location = new System.Drawing.Point(592, 176);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(201, 22);
            this.dateTime.TabIndex = 38;
            //this.dateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkCyan;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(592, 388);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 28);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = false;
            //this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(725, 125);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(87, 22);
            this.txtMaDH.TabIndex = 34;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(541, 125);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(87, 22);
            this.txtMaKH.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã đơn hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(578, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thêm Hóa Đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Schedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 93);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::QuanLy_BanHang.Properties.Resources.invoice;
            this.pictureBox1.Location = new System.Drawing.Point(367, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invoice);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.statistics_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 28);
            this.panel2.TabIndex = 9;
            // 
            // invoice
            // 
            this.invoice.AutoEllipsis = true;
            this.invoice.BackColor = System.Drawing.Color.DarkCyan;
            this.invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.Location = new System.Drawing.Point(301, 0);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(199, 28);
            this.invoice.TabIndex = 10;
            this.invoice.Text = "Danh Sách Hóa Đơn";
            this.invoice.UseVisualStyleBackColor = false;
            //this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkCyan;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(635, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 28);
            this.exit.TabIndex = 9;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = false;
            //this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // statistics_Button
            // 
            this.statistics_Button.AutoEllipsis = true;
            this.statistics_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.statistics_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_Button.Location = new System.Drawing.Point(70, 1);
            this.statistics_Button.Name = "statistics_Button";
            this.statistics_Button.Size = new System.Drawing.Size(199, 28);
            this.statistics_Button.TabIndex = 4;
            this.statistics_Button.Text = "Thống kê doanh thu";
            this.statistics_Button.UseVisualStyleBackColor = false;
            //this.statistics_Button.Click += new System.EventHandler(this.statistics_Button_Click);
            // 
            // Schedule
            // 
            //this.Schedule.Image = global::QuanLy_BanHang.Properties.Resources.statistics;
            this.Schedule.Location = new System.Drawing.Point(130, 3);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(52, 57);
            this.Schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Schedule.TabIndex = 0;
            this.Schedule.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(111, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Danh Sách Sản Phẩm";
            // 
            // ThemSP
            // 
            this.ThemSP.AutoEllipsis = true;
            this.ThemSP.BackColor = System.Drawing.Color.DarkCyan;
            this.ThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemSP.Location = new System.Drawing.Point(289, 409);
            this.ThemSP.Name = "ThemSP";
            this.ThemSP.Size = new System.Drawing.Size(145, 29);
            this.ThemSP.TabIndex = 68;
            this.ThemSP.Text = "Chọn Sản Phẩm";
            this.ThemSP.UseVisualStyleBackColor = false;
            //this.ThemSP.Click += new System.EventHandler(this.ThemSP_Click);
            // 
            // ds_SPChon
            // 
            this.ds_SPChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ds_SPChon.ColumnHeadersHeight = 29;
            this.ds_SPChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ds_SPChon.Location = new System.Drawing.Point(452, 219);
            this.ds_SPChon.Name = "ds_SPChon";
            this.ds_SPChon.RowHeadersWidth = 51;
            this.ds_SPChon.Size = new System.Drawing.Size(393, 150);
            this.ds_SPChon.TabIndex = 69;
            // 
            // TenKH
            // 
            this.TenKH.AutoSize = true;
            this.TenKH.Location = new System.Drawing.Point(538, 147);
            this.TenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(103, 16);
            this.TenKH.TabIndex = 70;
            this.TenKH.Text = "Tên khách hàng";
            this.TenKH.Visible = false;
            // 
            // ThemHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(894, 475);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.ds_SPChon);
            this.Controls.Add(this.ThemSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dsSanPham);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.txtMaDH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemHoaDon";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SPChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dsSanPham;
        private System.Windows.Forms.PictureBox Schedule;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button statistics_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button invoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ThemSP;
        private System.Windows.Forms.DataGridView ds_SPChon;
        private System.Windows.Forms.Label TenKH;
    }
}

