namespace PRL
{
    partial class FormQLSP
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
            this.dtg_AllSP = new System.Windows.Forms.DataGridView();
            this.ptb_Mota = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.tb_Soluong = new System.Windows.Forms.TextBox();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.cbb_Trangthai = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.tbt_Timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AllSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Mota)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_AllSP
            // 
            this.dtg_AllSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_AllSP.Location = new System.Drawing.Point(12, 398);
            this.dtg_AllSP.Name = "dtg_AllSP";
            this.dtg_AllSP.RowHeadersWidth = 51;
            this.dtg_AllSP.RowTemplate.Height = 29;
            this.dtg_AllSP.Size = new System.Drawing.Size(947, 293);
            this.dtg_AllSP.TabIndex = 0;
            this.dtg_AllSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AllSP_CellClick);
            // 
            // ptb_Mota
            // 
            this.ptb_Mota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ptb_Mota.Location = new System.Drawing.Point(12, 24);
            this.ptb_Mota.Name = "ptb_Mota";
            this.ptb_Mota.Size = new System.Drawing.Size(261, 269);
            this.ptb_Mota.TabIndex = 1;
            this.ptb_Mota.TabStop = false;
            this.ptb_Mota.Click += new System.EventHandler(this.ptb_Mota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(293, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(291, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(290, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(290, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(289, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Trạng thái";
            // 
            // tb_Ten
            // 
            this.tb_Ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Ten.Location = new System.Drawing.Point(415, 20);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.PlaceholderText = "Nhập tên";
            this.tb_Ten.Size = new System.Drawing.Size(544, 34);
            this.tb_Ten.TabIndex = 4;
            // 
            // tb_Soluong
            // 
            this.tb_Soluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Soluong.Location = new System.Drawing.Point(415, 85);
            this.tb_Soluong.Name = "tb_Soluong";
            this.tb_Soluong.PlaceholderText = "Nhập số lượng";
            this.tb_Soluong.Size = new System.Drawing.Size(544, 34);
            this.tb_Soluong.TabIndex = 5;
            // 
            // tb_Gia
            // 
            this.tb_Gia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Gia.Location = new System.Drawing.Point(416, 150);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.PlaceholderText = "Nhập giá";
            this.tb_Gia.Size = new System.Drawing.Size(542, 34);
            this.tb_Gia.TabIndex = 6;
            // 
            // cbb_Trangthai
            // 
            this.cbb_Trangthai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Trangthai.FormattingEnabled = true;
            this.cbb_Trangthai.Location = new System.Drawing.Point(416, 225);
            this.cbb_Trangthai.Name = "cbb_Trangthai";
            this.cbb_Trangthai.Size = new System.Drawing.Size(542, 36);
            this.cbb_Trangthai.TabIndex = 7;
            this.cbb_Trangthai.Text = "Chọn trạng thái";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Location = new System.Drawing.Point(293, 273);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(202, 51);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sua.Location = new System.Drawing.Point(529, 273);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(196, 51);
            this.Btn_Sua.TabIndex = 9;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Location = new System.Drawing.Point(761, 273);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(197, 51);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // tbt_Timkiem
            // 
            this.tbt_Timkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Timkiem.Location = new System.Drawing.Point(12, 346);
            this.tbt_Timkiem.Name = "tbt_Timkiem";
            this.tbt_Timkiem.PlaceholderText = "Nhập vào để tìm kiếm";
            this.tbt_Timkiem.Size = new System.Drawing.Size(947, 34);
            this.tbt_Timkiem.TabIndex = 11;
            // 
            // FormQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(967, 703);
            this.Controls.Add(this.tbt_Timkiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cbb_Trangthai);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.tb_Soluong);
            this.Controls.Add(this.tb_Ten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_Mota);
            this.Controls.Add(this.dtg_AllSP);
            this.Name = "FormQLSP";
            this.Text = "FormQLSP";
            this.Load += new System.EventHandler(this.FormQLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AllSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Mota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_AllSP;
        private PictureBox ptb_Mota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_Ten;
        private TextBox tb_Soluong;
        private TextBox tb_Gia;
        private ComboBox cbb_Trangthai;
        private Button btn_Them;
        private Button Btn_Sua;
        private Button btn_Xoa;
        private TextBox tbt_Timkiem;
    }
}