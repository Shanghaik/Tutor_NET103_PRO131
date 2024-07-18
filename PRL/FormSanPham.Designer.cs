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
            this.tlp_SanPham = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ShowSP = new System.Windows.Forms.Button();
            this.lb_back = new System.Windows.Forms.Label();
            this.lb_next = new System.Windows.Forms.Label();
            this.lb_page = new System.Windows.Forms.Label();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlp_SanPham
            // 
            this.tlp_SanPham.ColumnCount = 2;
            this.tlp_SanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_SanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_SanPham.Location = new System.Drawing.Point(223, 17);
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
            this.btn_ShowSP.Size = new System.Drawing.Size(184, 65);
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
            this.btn_QLSP.Size = new System.Drawing.Size(184, 66);
            this.btn_QLSP.TabIndex = 5;
            this.btn_QLSP.Text = "Quản lý SP";
            this.btn_QLSP.UseVisualStyleBackColor = true;
            this.btn_QLSP.Click += new System.EventHandler(this.btn_QLSP_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 786);
            this.Controls.Add(this.btn_QLSP);
            this.Controls.Add(this.lb_page);
            this.Controls.Add(this.lb_next);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.btn_ShowSP);
            this.Controls.Add(this.tlp_SanPham);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
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
    }
}