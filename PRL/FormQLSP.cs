using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormQLSP : Form
    {
        SanPhamServices _services;
        public FormQLSP()
        {
            _services = new SanPhamServices();
            InitializeComponent();
            ptb_Mota.SizeMode = PictureBoxSizeMode.StretchImage; // Cấu hình cho picturebox tự fill
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ten = tb_Ten.Text; int gia = Convert.ToInt32(tb_Gia.Text);
            int soluong = Convert.ToInt32(tb_Soluong.Text);
            string mota = ptb_Mota.ImageLocation; // Lấy đường dẫn ảnh
            int trangthai = cbb_Trangthai.SelectedIndex;
            // Cách dùng này gọi là cách dùng Anonymous Type => Có thể bỏ qua đoạn dùng constructor
            SanPham sp = new SanPham() { Gia = gia, Ten = ten, Soluong = soluong, Mota = mota, Trangthai = trangthai };
            MessageBox.Show(_services.Create(sp));
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            dtg_AllSP.Rows.Clear();
            var allDatas = _services.GetAll();
            dtg_AllSP.ColumnCount = 6;
            dtg_AllSP.Columns[0].HeaderText = "Id";
            dtg_AllSP.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_AllSP.Columns[2].HeaderText = "Giá";
            dtg_AllSP.Columns[3].HeaderText = "Số lượng";
            dtg_AllSP.Columns[4].HeaderText = "Mô tả - img";
            dtg_AllSP.Columns[5].HeaderText = "Trạng thái";
            foreach (var data in allDatas)
            {
                dtg_AllSP.Rows.Add(data.Id, data.Ten, data.Gia, data.Soluong, data.Mota, data.Trangthai);
            }
        }
        private void FormQLSP_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void ptb_Mota_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            string imgURL = dialog.FileName;
            ptb_Mota.Image = Image.FromFile(imgURL); // Gán giá trị
            ptb_Mota.ImageLocation = imgURL; // Gán value cho đường dẫn
        }

        private void dtg_AllSP_CellClick(object sender, DataGridViewCellEventArgs e)
        { // Load data lên form
            DataGridViewRow row = dtg_AllSP.Rows[e.RowIndex]; // Lấy ra dòng mà mình được chọn
            tb_Ten.Text = row.Cells[1].Value.ToString();
            tb_Soluong.Text = row.Cells[2].Value.ToString();
            tb_Gia.Text = row.Cells[3].Value.ToString();
            cbb_Trangthai.Text = row.Cells[5].Value.ToString();
            ptb_Mota.Image = Image.FromFile(row.Cells[4].Value.ToString());

        }
    }
}
