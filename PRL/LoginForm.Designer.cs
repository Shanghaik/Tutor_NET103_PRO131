namespace PRL
{
    partial class LoginForm
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
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ShowPW = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbt_Username
            // 
            this.tbt_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Username.Location = new System.Drawing.Point(146, 37);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.Size = new System.Drawing.Size(651, 34);
            this.tbt_Username.TabIndex = 0;
            // 
            // tbt_Password
            // 
            this.tbt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Password.Location = new System.Drawing.Point(146, 110);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.PasswordChar = '*';
            this.tbt_Password.Size = new System.Drawing.Size(651, 34);
            this.tbt_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // cb_ShowPW
            // 
            this.cb_ShowPW.AutoSize = true;
            this.cb_ShowPW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_ShowPW.Location = new System.Drawing.Point(145, 174);
            this.cb_ShowPW.Name = "cb_ShowPW";
            this.cb_ShowPW.Size = new System.Drawing.Size(205, 32);
            this.cb_ShowPW.TabIndex = 4;
            this.cb_ShowPW.Text = "Hiển thị mật khẩu";
            this.cb_ShowPW.UseVisualStyleBackColor = true;
            this.cb_ShowPW.CheckedChanged += new System.EventHandler(this.cb_ShowPW_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(551, 166);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(246, 39);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 234);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.cb_ShowPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.tbt_Username);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_Username;
        private TextBox tbt_Password;
        private Label label1;
        private Label label2;
        private CheckBox cb_ShowPW;
        private Button btn_Login;
    }
}