
namespace toplulukotomasyon
{
    partial class anamenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anamenu));
            this.ustbilgi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uyeolbutton = new System.Windows.Forms.Button();
            this.uyegirisbutton = new System.Windows.Forms.Button();
            this.yetkiligirisbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.altbutton = new System.Windows.Forms.Button();
            this.ktologo = new System.Windows.Forms.PictureBox();
            this.cıkısbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ktologo)).BeginInit();
            this.SuspendLayout();
            // 
            // ustbilgi
            // 
            this.ustbilgi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ustbilgi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ustbilgi.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ustbilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ustbilgi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ustbilgi.Location = new System.Drawing.Point(309, 31);
            this.ustbilgi.Name = "ustbilgi";
            this.ustbilgi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ustbilgi.Size = new System.Drawing.Size(570, 67);
            this.ustbilgi.TabIndex = 2;
            this.ustbilgi.Text = "KTO KARATAY ÜNİVERSİTESİ\r\nÖĞRENCİ TOPLULUKLARI BİLGİ PROGRAMI\r\n\r\n";
            this.ustbilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 546);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(285, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 57);
            this.label1.TabIndex = 15;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyeolbutton
            // 
            this.uyeolbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uyeolbutton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.uyeolbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyeolbutton.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
            this.uyeolbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uyeolbutton.Location = new System.Drawing.Point(447, 126);
            this.uyeolbutton.Name = "uyeolbutton";
            this.uyeolbutton.Size = new System.Drawing.Size(184, 39);
            this.uyeolbutton.TabIndex = 4;
            this.uyeolbutton.Text = "Üye Ol";
            this.uyeolbutton.UseVisualStyleBackColor = false;
            this.uyeolbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyegirisbutton
            // 
            this.uyegirisbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uyegirisbutton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.uyegirisbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyegirisbutton.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
            this.uyegirisbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uyegirisbutton.Location = new System.Drawing.Point(637, 126);
            this.uyegirisbutton.Name = "uyegirisbutton";
            this.uyegirisbutton.Size = new System.Drawing.Size(184, 39);
            this.uyegirisbutton.TabIndex = 5;
            this.uyegirisbutton.Text = "Üye Giriş";
            this.uyegirisbutton.UseVisualStyleBackColor = false;
            this.uyegirisbutton.Click += new System.EventHandler(this.uyegirisbutton_Click);
            // 
            // yetkiligirisbutton
            // 
            this.yetkiligirisbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yetkiligirisbutton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.yetkiligirisbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yetkiligirisbutton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yetkiligirisbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yetkiligirisbutton.Location = new System.Drawing.Point(827, 126);
            this.yetkiligirisbutton.Name = "yetkiligirisbutton";
            this.yetkiligirisbutton.Size = new System.Drawing.Size(184, 39);
            this.yetkiligirisbutton.TabIndex = 6;
            this.yetkiligirisbutton.Text = "Yetkili Giriş";
            this.yetkiligirisbutton.UseVisualStyleBackColor = false;
            this.yetkiligirisbutton.Click += new System.EventHandler(this.yetkiligirisbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.altbutton);
            this.panel2.Controls.Add(this.uyeolbutton);
            this.panel2.Controls.Add(this.ustbilgi);
            this.panel2.Controls.Add(this.uyegirisbutton);
            this.panel2.Controls.Add(this.ktologo);
            this.panel2.Controls.Add(this.yetkiligirisbutton);
            this.panel2.Controls.Add(this.cıkısbutton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 171);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::toplulukotomasyon.Properties.Resources.icons8_maximize_window_48px;
            this.button1.Location = new System.Drawing.Point(935, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // altbutton
            // 
            this.altbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altbutton.FlatAppearance.BorderSize = 0;
            this.altbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altbutton.Image = global::toplulukotomasyon.Properties.Resources.icons8_horizontal_line_16px;
            this.altbutton.Location = new System.Drawing.Point(894, 12);
            this.altbutton.Name = "altbutton";
            this.altbutton.Size = new System.Drawing.Size(35, 25);
            this.altbutton.TabIndex = 8;
            this.altbutton.TabStop = false;
            this.altbutton.UseVisualStyleBackColor = false;
            this.altbutton.Click += new System.EventHandler(this.altbutton_Click);
            // 
            // ktologo
            // 
            this.ktologo.BackColor = System.Drawing.Color.White;
            this.ktologo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ktologo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ktologo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ktologo.Image = global::toplulukotomasyon.Properties.Resources.logo_2x1;
            this.ktologo.Location = new System.Drawing.Point(0, 0);
            this.ktologo.Margin = new System.Windows.Forms.Padding(0);
            this.ktologo.Name = "ktologo";
            this.ktologo.Padding = new System.Windows.Forms.Padding(30);
            this.ktologo.Size = new System.Drawing.Size(212, 172);
            this.ktologo.TabIndex = 1;
            this.ktologo.TabStop = false;
            // 
            // cıkısbutton
            // 
            this.cıkısbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cıkısbutton.BackColor = System.Drawing.Color.Red;
            this.cıkısbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cıkısbutton.FlatAppearance.BorderSize = 0;
            this.cıkısbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cıkısbutton.Image = global::toplulukotomasyon.Properties.Resources.çıkış;
            this.cıkısbutton.Location = new System.Drawing.Point(976, 12);
            this.cıkısbutton.Name = "cıkısbutton";
            this.cıkısbutton.Size = new System.Drawing.Size(35, 25);
            this.cıkısbutton.TabIndex = 7;
            this.cıkısbutton.TabStop = false;
            this.cıkısbutton.UseVisualStyleBackColor = false;
            this.cıkısbutton.Click += new System.EventHandler(this.cıkısbutton_Click);
            // 
            // anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1023, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anamenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ktologo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ktologo;
        private System.Windows.Forms.Label ustbilgi;
        private System.Windows.Forms.Button cıkısbutton;
        private System.Windows.Forms.Button altbutton;
        public System.Windows.Forms.Button uyeolbutton;
        public System.Windows.Forms.Button yetkiligirisbutton;
        public System.Windows.Forms.Button uyegirisbutton;
        public System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

