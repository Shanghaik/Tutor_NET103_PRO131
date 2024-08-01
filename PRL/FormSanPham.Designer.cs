namespace PRL
{
    partial class FormSanPham
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
            this.components = new System.ComponentModel.Container();
            this.tlp_SanPham = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ShowSP = new System.Windows.Forms.Button();
            this.lb_back = new System.Windows.Forms.Label();
            this.lb_next = new System.Windows.Forms.Label();
            this.lb_page = new System.Windows.Forms.Label();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.grb_Hoadon = new System.Windows.Forms.GroupBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.lb_idHD = new System.Windows.Forms.Label();
            this.btn_TaoHD = new System.Windows.Forms.Button();
            this.dtg_HoaDon = new System.Windows.Forms.DataGridView();
            this.grb_HDCT = new System.Windows.Forms.GroupBox();
            this.dtg_HDCT = new System.Windows.Forms.DataGridView();
            this.lb_IdNV = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grb_Hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).BeginInit();
            this.grb_HDCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HDCT)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_SanPham
            // 
            this.tlp_SanPham.ColumnCount = 2;
            this.tlp_SanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_SanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_SanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tlp_SanPham.Location = new System.Drawing.Point(160, 17);
            this.tlp_SanPham.Name = "tlp_SanPham";
            this.tlp_SanPham.RowCount = 2;
            this.tlp_SanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_SanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_SanPham.Size = new System.Drawing.Size(1110, 720);
            this.tlp_SanPham.TabIndex = 0;
            // 
            // btn_ShowSP
            // 
            this.btn_ShowSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowSP.Location = new System.Drawing.Point(12, 17);
            this.btn_ShowSP.Name = "btn_ShowSP";
            this.btn_ShowSP.Size = new System.Drawing.Size(139, 65);
            this.btn_ShowSP.TabIndex = 1;
            this.btn_ShowSP.Text = "Hiển thị SP";
            this.btn_ShowSP.UseVisualStyleBackColor = true;
            this.btn_ShowSP.Click += new System.EventHandler(this.btn_ShowSP_Click);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Location = new System.Drawing.Point(687, 749);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(39, 20);
            this.lb_back.TabIndex = 2;
            this.lb_back.Text = "<<<";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // lb_next
            // 
            this.lb_next.AutoSize = true;
            this.lb_next.Location = new System.Drawing.Point(829, 751);
            this.lb_next.Name = "lb_next";
            this.lb_next.Size = new System.Drawing.Size(39, 20);
            this.lb_next.TabIndex = 3;
            this.lb_next.Text = ">>>";
            this.lb_next.Click += new System.EventHandler(this.lb_next_Click);
            // 
            // lb_page
            // 
            this.lb_page.AutoSize = true;
            this.lb_page.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_page.Location = new System.Drawing.Point(767, 745);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(27, 31);
            this.lb_page.TabIndex = 4;
            this.lb_page.Text = "1";
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLSP.Location = new System.Drawing.Point(12, 100);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(139, 66);
            this.btn_QLSP.TabIndex = 5;
            this.btn_QLSP.Text = "Quản lý SP";
            this.btn_QLSP.UseVisualStyleBackColor = true;
            this.btn_QLSP.Click += new System.EventHandler(this.btn_QLSP_Click);
            // 
            // grb_Hoadon
            // 
            this.grb_Hoadon.Controls.Add(this.btn_ThanhToan);
            this.grb_Hoadon.Controls.Add(this.lb_idHD);
            this.grb_Hoadon.Controls.Add(this.btn_TaoHD);
            this.grb_Hoadon.Controls.Add(this.dtg_HoaDon);
            this.grb_Hoadon.Location = new System.Drawing.Point(1291, 18);
            this.grb_Hoadon.Name = "grb_Hoadon";
            this.grb_Hoadon.Size = new System.Drawing.Size(466, 322);
            this.grb_Hoadon.TabIndex = 6;
            this.grb_Hoadon.TabStop = false;
            this.grb_Hoadon.Text = "Hóa đơn";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.Location = new System.Drawing.Point(265, 30);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(183, 46);
            this.btn_ThanhToan.TabIndex = 3;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // lb_idHD
            // 
            this.lb_idHD.AutoSize = true;
            this.lb_idHD.Location = new System.Drawing.Point(223, 44);
            this.lb_idHD.Name = "lb_idHD";
            this.lb_idHD.Size = new System.Drawing.Size(18, 20);
            this.lb_idHD.TabIndex = 2;
            this.lb_idHD.Text = "...";
            // 
            // btn_TaoHD
            // 
            this.btn_TaoHD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TaoHD.Location = new System.Drawing.Point(19, 30);
            this.btn_TaoHD.Name = "btn_TaoHD";
            this.btn_TaoHD.Size = new System.Drawing.Size(188, 46);
            this.btn_TaoHD.TabIndex = 1;
            this.btn_TaoHD.Text = "Tạo hóa đơn";
            this.btn_TaoHD.UseVisualStyleBackColor = true;
            this.btn_TaoHD.Click += new System.EventHandler(this.btn_TaoHD_Click);
            // 
            // dtg_HoaDon
            // 
            this.dtg_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HoaDon.Location = new System.Drawing.Point(19, 82);
            this.dtg_HoaDon.Name = "dtg_HoaDon";
            this.dtg_HoaDon.RowHeadersWidth = 51;
            this.dtg_HoaDon.RowTemplate.Height = 29;
            this.dtg_HoaDon.Size = new System.Drawing.Size(429, 221);
            this.dtg_HoaDon.TabIndex = 0;
            this.dtg_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_HoaDon_CellClick);
            // 
            // grb_HDCT
            // 
            this.grb_HDCT.Controls.Add(this.dtg_HDCT);
            this.grb_HDCT.Location = new System.Drawing.Point(1295, 368);
            this.grb_HDCT.Name = "grb_HDCT";
            this.grb_HDCT.Size = new System.Drawing.Size(462, 369);
            this.grb_HDCT.TabIndex = 7;
            this.grb_HDCT.TabStop = false;
            this.grb_HDCT.Text = "Sản phẩm trong hóa đơn";
            // 
            // dtg_HDCT
            // 
            this.dtg_HDCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HDCT.Location = new System.Drawing.Point(17, 26);
            this.dtg_HDCT.Name = "dtg_HDCT";
            this.dtg_HDCT.RowHeadersWidth = 51;
            this.dtg_HDCT.RowTemplate.Height = 29;
            this.dtg_HDCT.Size = new System.Drawing.Size(427, 326);
            this.dtg_HDCT.TabIndex = 0;
            // 
            // lb_IdNV
            // 
            this.lb_IdNV.AutoSize = true;
            this.lb_IdNV.Location = new System.Drawing.Point(12, 754);
            this.lb_IdNV.Name = "lb_IdNV";
            this.lb_IdNV.Size = new System.Drawing.Size(18, 20);
            this.lb_IdNV.TabIndex = 8;
            this.lb_IdNV.Text = "...";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Time.Location = new System.Drawing.Point(1296, 754);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(72, 31);
            this.lb_Time.TabIndex = 9;
            this.lb_Time.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 786);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lb_IdNV);
            this.Controls.Add(this.grb_HDCT);
            this.Controls.Add(this.grb_Hoadon);
            this.Controls.Add(this.btn_QLSP);
            this.Controls.Add(this.lb_page);
            this.Controls.Add(this.lb_next);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.btn_ShowSP);
            this.Controls.Add(this.tlp_SanPham);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.grb_Hoadon.ResumeLayout(false);
            this.grb_Hoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).EndInit();
            this.grb_HDCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HDCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tlp_SanPham;
        private Button btn_ShowSP;
        private Label lb_back;
        private Label lb_next;
        private Label lb_page;
        private Button btn_QLSP;
        private GroupBox grb_Hoadon;
        private Button btn_TaoHD;
        private DataGridView dtg_HoaDon;
        private GroupBox grb_HDCT;
        private DataGridView dtg_HDCT;
        private Label lb_IdNV;
        private Label lb_idHD;
        private Button btn_ThanhToan;
        private Label lb_Time;
        private System.Windows.Forms.Timer timer1;
    }
}