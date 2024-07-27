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
    public partial class FormSanPham : Form
    {
        //List<SanPham> sanphams = new List<SanPham>() // List này có thể lấy từu file/db
        //{
        //    new SanPham {Ten = "SP1", Gia = 15000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP2", Gia = 21000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Logo XLDL.png"},
        //    new SanPham {Ten = "SP3", Gia = 1000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP4", Gia = 10300, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP5", Gia = 41000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Logo XLDL.png"},
        //    new SanPham {Ten = "SP6", Gia = 13000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP7", Gia = 1000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP8", Gia = 130400, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Logo XLDL.png"},
        //    new SanPham {Ten = "SP9", Gia = 1000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP10", Gia = 1000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP11", Gia = 103300, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"},
        //    new SanPham {Ten = "SP12", Gia = 10300, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\SK1_GENAI.png"},
        //    new SanPham {Ten = "SP13", Gia = 331000, Soluong = 10, ImgURL = @"C:\Users\Acer\Desktop\Hello.png"}
        //};
        Guid idNV; // Gán 1 thuộc tính để chứa id nhân viên đăng nhập
        List<SanPham> sanphams; // Tạo ra list SP
        SanPhamServices _services; // Gọi services
        HoaDonServices _hoaDonServices;
        HDCTServices _hdctServices = new HDCTServices();
        public int currentBillId = -1;
        public FormSanPham(Guid idNV)
        {
            _hoaDonServices = new HoaDonServices();
            _services = new SanPhamServices(); // Thêm cái này
            sanphams = _services.GetAll(); // thêm cả cái này
            InitializeComponent();
            this.idNV = idNV;
        }
        public void LoadSPToPanel(int page) // Load từng trang sản phẩm vào TableLayoutPanel
        {
            tlp_SanPham.Controls.Clear();
            int numberOfPage = (int)Math.Ceiling((decimal)sanphams.Count / 4);// số trang ứng theo số lượng sản phẩm
            // Phương thức Ceiling sẽ lấy số nguyên nhỏ nhất lớn hơn hoặc = số thập phân chia ra từ kết quả, vd 13/4 = 3.33333 => 4
            if (page < 1 || page > numberOfPage) return; // nếu số trang vượt quá số trang có => bỏ qua
            else
            { // Lấy số sản phẩm theo số trang 
                if (page * 4 - 4 < sanphams.Count)
                {
                    Panel s1 = CreatePanelSP(sanphams[page * 4 - 4]);
                    tlp_SanPham.Controls.Add(s1, 0, 0);
                }// Check sản phẩm thêm vào Panel không bị lớn hơn sản phẩm cuối vd đang ở trang số 4 
                // các sp sẽ là 12 13 14 15 nhưng ta chỉ có 13 sản phẩm thôi thì những sản phẩm nào vượt quá sẽ không được gen ra
                if (page * 4 - 3 < sanphams.Count)
                {
                    Panel s2 = CreatePanelSP(sanphams[page * 4 - 3]);
                    tlp_SanPham.Controls.Add(s2, 0, 1);
                }
                if (page * 4 - 2 < sanphams.Count)
                {
                    Panel s3 = CreatePanelSP(sanphams[page * 4 - 2]);
                    tlp_SanPham.Controls.Add(s3, 1, 0);
                }
                if (page * 4 - 1 < sanphams.Count)
                {
                    Panel s4 = CreatePanelSP(sanphams[page * 4 - 1]);
                    tlp_SanPham.Controls.Add(s4, 1, 1);
                }
            }
        }
        private void btn_ShowSP_Click(object sender, EventArgs e)
        {

            //// Khi click vào đây sẽ load ra 1 sản phẩm với các thuộc tính y như form Gen
            //// Tạo ra 1 đối tượng Sản phẩm mới
            //SanPham sp = new SanPham
            //{
            //    Ten = "Bimbim",
            //    Gia = 10000,
            //    Soluong = 100,
            //    ImgURL = @"C:\Users\Acer\Desktop\Hello.png"
            //};
            //// Tạo panel dựa trên đối tượng đó
            //Panel x = CreatePanelSP(sp);
            //Panel y = CreatePanelSP(sp);
            //Panel z = CreatePanelSP(sp);
            //Panel t = CreatePanelSP(sp);
            //// Thêm sản phẩm vào trong tableLayoutPanel
            //tlp_SanPham.Controls.Add(x, 0, 0);
            //tlp_SanPham.Controls.Add(y, 0, 1);
            //tlp_SanPham.Controls.Add(z, 1, 0);
            //tlp_SanPham.Controls.Add(t, 1, 1);
            tlp_SanPham.Controls.Clear();
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.RowCount = 2;
            LoadSPToPanel(Convert.ToInt32(lb_page.Text));
        }
        public Panel CreatePanelSP(SanPham sp) // Mỗi sản phẩm sẽ được tạo ra và nằm trong 1 panel,
                                               // panel này sẽ được thêm vào tablelayoutpanel, // Phương thức này trả về cả 1 Panel
        {
            Panel p = new Panel(); p.Size = new Size(555, 360);
            p.Name = sp.Id.ToString(); // gán ID thành tên panel để khi chọn 1 nút trên panel sẽ lấy được ID
            PictureBox ptb = new PictureBox(); ptb.Size = new Size(297, 287);
            ptb.Image = Image.FromFile(sp.Mota); // gán hình ảnh của picturebox = URL ảnh của sản phẩm
            ptb.Location = new Point(14, 12);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            Label lbTen = new Label(); lbTen.Text = "Tên sản phẩm";
            lbTen.Location = new Point(331, 14);
            Label lbTenValue = new Label(); lbTenValue.Text = sp.Ten; // Gán tên sản phẩm cho label này
            lbTenValue.Location = new Point(332, 47);
            Label lbGia = new Label(); lbGia.Text = "Gia sản phẩm";
            lbGia.Location = new Point(331, 87);
            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.Gia + "";
            lbGiaValue.Name = "giaban"; //Đặt tên để lát nữa còn lấy ra
            lbGiaValue.Location = new Point(332, 123);
            Label lbSL = new Label(); lbSL.Text = "Số lượng sản phẩm";
            lbSL.Location = new Point(332, 165);
            Label lbSLValue = new Label(); lbSLValue.Text = sp.Soluong + "";
            lbSLValue.Name = "Soluong"; // Gán tên để lát lấy data
            lbSLValue.Location = new Point(332, 198);
            Label lbMua = new Label(); lbMua.Text = "Số lượng mua";
            lbMua.Location = new Point(332, 232);
            Button btnMua = new Button();
            btnMua.Location = new Point(442, 263);
            btnMua.Size = new Size(83, 39); btnMua.Text = "MUA";
            btnMua.MouseClick += BtnMua_MouseClick; // Tạo sự kiện cho nó khi ấn vào nút mua
            // Tạo thêm 1 textbox để nhập số lượng
            TextBox tbSoLuong = new TextBox(); tbSoLuong.PlaceholderText = "Nhập";
            tbSoLuong.Location = new Point(332, 268); tbSoLuong.Size = new Size(83, 34);
            tbSoLuong.Name = "tbSoLuong";
            p.Controls.Add(ptb); p.Controls.Add(lbTen); p.Controls.Add(lbTenValue); p.Controls.Add(lbGia);
            p.Controls.Add(lbGiaValue); p.Controls.Add(lbSL); p.Controls.Add(lbSLValue); p.Controls.Add(lbMua);
            p.Controls.Add(btnMua); p.Controls.Add(tbSoLuong);
            return p;
        }

        private void BtnMua_MouseClick(object? sender, MouseEventArgs e)
        {
            // Bước 1 => Xác định đối tượng được tác động là gì?
            Button b = (Button)sender;  // sender là đối tượng áp dụng cho sự kiện
            // Bước 2: Xác định Parent (Chính là Panel mà Button đó nằm trên)
            // Ở đoạn code trên ta đã gán tên panel = id của sản phẩm
            // => Để lấy được id của sản phẩm cần mua, ta chỉ cần lấy name của panel
            Panel p = (Panel)b.Parent; // p là panel chứa nút đó
            TextBox t = p.Controls["tbSoLuong"] as TextBox;
            Label gia = p.Controls["giaban"] as Label;
            int soluongmua = Convert.ToInt32(t.Text); // Số lượng nhập vào
            int giaban = Convert.ToInt32(gia.Text);
            Label soluong = p.Controls["Soluong"] as Label;
            int soluongcon = Convert.ToInt32(soluong.Text); // Số lượng 
            if (soluongmua > soluongcon) MessageBox.Show($"Không thể mua {soluongmua} vì quá {soluongcon} sản phẩm");
            else if (currentBillId == -1) MessageBox.Show($"Chưa chọn hóa đơn để mua");
            else
            {
                MessageBox.Show("Bạn vừa chọn mua sản phẩm có id là " + p.Name + "Với số lượng là: " + t.Text
                + "Vào hóa đơn " + currentBillId); // Hiển thị tạm ID ra
                                                   // Tạo ra 1 hóa đơn chi tiết tương ứng
                int Idhd = currentBillId;
                int Idsp = Convert.ToInt32(p.Name);
                int Soluong = soluongmua;
                int Gia = giaban;
                int Trangthai = 1;
                _hdctServices.Create(Soluong, Idsp, Idhd, Gia);
                dtg_HDCT.DataSource = _hdctServices.GetAllByHD(currentBillId);
            }
        }

        private void lb_next_Click(object sender, EventArgs e) // tăng trang lên
        {
            if (Convert.ToInt32(lb_page.Text) < (int)Math.Ceiling((decimal)sanphams.Count / 4))
            { // Nếu trang hiện tại vẫn nhỏ hơn tổ số trang có thể thì ta mới cho Next trang
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) > 1)
            { // Nếu trang hiện tại vẫn nhỏ hơn tổ số trang có thể thì ta mới cho Next trang
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            tlp_SanPham.Controls.Clear();
            // Khi click vào đây thì sẽ hiện ra form Quản lý SP trên tableLayoutpanel
            FormQLSP qlsp = new FormQLSP();
            qlsp.TopLevel = false;
            // Thay đổi kích thước TableLayoutPanel thành 1*1 để có thể add cả form QUản lý SP vào
            tlp_SanPham.ColumnCount = 1;
            tlp_SanPham.RowCount = 1;
            tlp_SanPham.Controls.Add(qlsp);
            qlsp.Show();
            qlsp.FormBorderStyle = FormBorderStyle.None;
        }
        public void LoadHD()
        {
            var allHD = _hoaDonServices.GetAll();
            dtg_HoaDon.DataSource = allHD;

        }
        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            _hoaDonServices.Create(idNV, "0987654321");
            LoadHD();
        }

        private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_HoaDon.Rows[e.RowIndex];
            currentBillId = (int)row.Cells[0].Value;
            MessageBox.Show(currentBillId.ToString());
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadHD();
        }
    }
    // Bài tập: Thực hiện thêm nhiều sản phẩm khác nhau vào trong tableLayoutPanel => Phân ra nhiều trang khác nhau
    //public class SanPham
    //{
    //    public string Ten { get; set; }
    //    public int Gia { get; set; }
    //    public int Soluong { get; set; }
    //    public string ImgURL { get; set; }
    //}
}
