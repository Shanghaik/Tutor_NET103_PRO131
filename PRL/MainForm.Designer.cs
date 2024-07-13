namespace PRL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_Show = new System.Windows.Forms.Panel();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_ShowTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pn_Show
            // 
            this.pn_Show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Show.Location = new System.Drawing.Point(212, 18);
            this.pn_Show.Name = "pn_Show";
            this.pn_Show.Size = new System.Drawing.Size(731, 514);
            this.pn_Show.TabIndex = 0;
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Show.Location = new System.Drawing.Point(16, 19);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(176, 70);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_ShowTest
            // 
            this.btn_ShowTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowTest.Location = new System.Drawing.Point(20, 118);
            this.btn_ShowTest.Name = "btn_ShowTest";
            this.btn_ShowTest.Size = new System.Drawing.Size(172, 63);
            this.btn_ShowTest.TabIndex = 2;
            this.btn_ShowTest.Text = "ShowTest";
            this.btn_ShowTest.UseVisualStyleBackColor = true;
            this.btn_ShowTest.Click += new System.EventHandler(this.btn_ShowTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 580);
            this.Controls.Add(this.btn_ShowTest);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.pn_Show);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_Show;
        private Button btn_Show;
        private Button btn_ShowTest;
    }
}