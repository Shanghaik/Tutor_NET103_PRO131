namespace PRL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // Sự kiện này sẽ add 1 form mới vào trong panel
        private void btn_Show_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear(); // Xóa tất cả các control đang nằm trên panel
            // Bước 1: Tạo ra 1 đối tượng tương ứng với form cần add vào
            GenForm gf = new GenForm();
            // Bước 2: Tắt trạng thái TopLevel của form vì mặc định 1 form sẽ được
            // hiểu là 1 control lớn nhất mà chỉ chứa các control khác nên khi muốn thêm
            // nó vào trong 1 control khác thì nó phải tắt TopLevel
            gf.TopLevel = false;
            pn_Show.Controls.Add(gf);
            // Thêm thiết lập cơ bản cho form thêm vào
            gf.FormBorderStyle= FormBorderStyle.None; // kiểu border
            gf.BackColor = Color.Orange; // màu nền
            gf.Location = new Point(120, 100);
            // 120, 100 là vị trí trong panel (thành phần chứa nó) 
            // 120 là khoảng cách (pixel tính từ góc trái bên trên sang phía tay phải)
            // 100 là khoảng cách (pixel tính từ góc trái bên trên xuống phía dưới)
            gf.Show();
        }
        private void btn_ShowTest_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear(); // Xóa tất cả các control đang nằm trên panel
            TestForm tf = new TestForm();
            tf.TopLevel = false;
            pn_Show.Controls.Add(tf);
            tf.FormBorderStyle= FormBorderStyle.None;
            tf.BackColor = Color.White;
            tf.Show();
        }
    }
}