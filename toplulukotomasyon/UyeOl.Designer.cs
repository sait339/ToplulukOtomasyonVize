
namespace toplulukotomasyon
{
    partial class UyeOl
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uyetc = new System.Windows.Forms.MaskedTextBox();
            this.uyecinsiyet = new System.Windows.Forms.ComboBox();
            this.uyedtarih = new System.Windows.Forms.DateTimePicker();
            this.uyesoyad = new System.Windows.Forms.TextBox();
            this.uyead = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sinift = new System.Windows.Forms.ComboBox();
            this.bolumt = new System.Windows.Forms.ComboBox();
            this.fakultet = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uyeogrencino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kpost = new System.Windows.Forms.ComboBox();
            this.ogpost = new System.Windows.Forms.ComboBox();
            this.uyetel = new System.Windows.Forms.MaskedTextBox();
            this.uyeadres = new System.Windows.Forms.TextBox();
            this.kisiselposta = new System.Windows.Forms.TextBox();
            this.ogrenciposta = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uyeolbuton = new System.Windows.Forms.Button();
            this.gerialmabutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(355, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Doldurulması Zorunlu Alan *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.uyetc);
            this.groupBox1.Controls.Add(this.uyecinsiyet);
            this.groupBox1.Controls.Add(this.uyedtarih);
            this.groupBox1.Controls.Add(this.uyesoyad);
            this.groupBox1.Controls.Add(this.uyead);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 325);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // uyetc
            // 
            this.uyetc.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyetc.ForeColor = System.Drawing.Color.Black;
            this.uyetc.Location = new System.Drawing.Point(20, 155);
            this.uyetc.Mask = "00000000000";
            this.uyetc.Name = "uyetc";
            this.uyetc.Size = new System.Drawing.Size(270, 27);
            this.uyetc.TabIndex = 24;
            // 
            // uyecinsiyet
            // 
            this.uyecinsiyet.FormattingEnabled = true;
            this.uyecinsiyet.Location = new System.Drawing.Point(20, 255);
            this.uyecinsiyet.Name = "uyecinsiyet";
            this.uyecinsiyet.Size = new System.Drawing.Size(270, 27);
            this.uyecinsiyet.TabIndex = 23;
            // 
            // uyedtarih
            // 
            this.uyedtarih.CustomFormat = "";
            this.uyedtarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uyedtarih.Location = new System.Drawing.Point(20, 205);
            this.uyedtarih.MaxDate = new System.DateTime(2021, 11, 4, 0, 0, 0, 0);
            this.uyedtarih.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.uyedtarih.Name = "uyedtarih";
            this.uyedtarih.Size = new System.Drawing.Size(270, 27);
            this.uyedtarih.TabIndex = 22;
            this.uyedtarih.Value = new System.DateTime(2021, 11, 4, 0, 0, 0, 0);
            this.uyedtarih.ValueChanged += new System.EventHandler(this.uyedtarih_ValueChanged);
            // 
            // uyesoyad
            // 
            this.uyesoyad.Location = new System.Drawing.Point(20, 105);
            this.uyesoyad.Name = "uyesoyad";
            this.uyesoyad.Size = new System.Drawing.Size(270, 27);
            this.uyesoyad.TabIndex = 20;
            this.uyesoyad.TextChanged += new System.EventHandler(this.uyesoyad_TextChanged);
            this.uyesoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyesoyad_KeyPress);
            // 
            // uyead
            // 
            this.uyead.Location = new System.Drawing.Point(20, 55);
            this.uyead.Name = "uyead";
            this.uyead.Size = new System.Drawing.Size(270, 27);
            this.uyead.TabIndex = 19;
            this.uyead.TextChanged += new System.EventHandler(this.uyead_TextChanged);
            this.uyead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyead_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cinsiyet :*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Doğum Tarihi :*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "T.C. No :*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Soyad :*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ad :*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.sinift);
            this.groupBox2.Controls.Add(this.bolumt);
            this.groupBox2.Controls.Add(this.fakultet);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.uyeogrencino);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(340, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 325);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgiler";
            // 
            // sinift
            // 
            this.sinift.FormattingEnabled = true;
            this.sinift.Location = new System.Drawing.Point(20, 205);
            this.sinift.Name = "sinift";
            this.sinift.Size = new System.Drawing.Size(304, 27);
            this.sinift.TabIndex = 26;
            this.sinift.Click += new System.EventHandler(this.sinift_Click);
            // 
            // bolumt
            // 
            this.bolumt.FormattingEnabled = true;
            this.bolumt.Location = new System.Drawing.Point(20, 155);
            this.bolumt.Name = "bolumt";
            this.bolumt.Size = new System.Drawing.Size(304, 27);
            this.bolumt.TabIndex = 25;
            this.bolumt.SelectedValueChanged += new System.EventHandler(this.bolumt_SelectedValueChanged);
            this.bolumt.Click += new System.EventHandler(this.bolumt_Click);
            // 
            // fakultet
            // 
            this.fakultet.FormattingEnabled = true;
            this.fakultet.Location = new System.Drawing.Point(20, 105);
            this.fakultet.Name = "fakultet";
            this.fakultet.Size = new System.Drawing.Size(304, 27);
            this.fakultet.TabIndex = 24;
            this.fakultet.SelectedValueChanged += new System.EventHandler(this.fakultet_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sınıf :*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bölüm :*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fakülte :*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyeogrencino
            // 
            this.uyeogrencino.Location = new System.Drawing.Point(20, 55);
            this.uyeogrencino.MaxLength = 11;
            this.uyeogrencino.Name = "uyeogrencino";
            this.uyeogrencino.Size = new System.Drawing.Size(304, 27);
            this.uyeogrencino.TabIndex = 20;
            this.uyeogrencino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyeogrencino_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Öğrenci No :*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.kpost);
            this.groupBox3.Controls.Add(this.ogpost);
            this.groupBox3.Controls.Add(this.uyetel);
            this.groupBox3.Controls.Add(this.uyeadres);
            this.groupBox3.Controls.Add(this.kisiselposta);
            this.groupBox3.Controls.Add(this.ogrenciposta);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(699, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 325);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgiler";
            // 
            // kpost
            // 
            this.kpost.FormattingEnabled = true;
            this.kpost.Items.AddRange(new object[] {
            "@hotmail.com",
            "@gmail.com",
            "@icloud.com",
            "@outlook.com",
            "@windowslive.com",
            "@yahoo.com",
            "@yandex.com"});
            this.kpost.Location = new System.Drawing.Point(191, 155);
            this.kpost.Name = "kpost";
            this.kpost.Size = new System.Drawing.Size(99, 27);
            this.kpost.TabIndex = 28;
            // 
            // ogpost
            // 
            this.ogpost.FormattingEnabled = true;
            this.ogpost.Items.AddRange(new object[] {
            "@ogrenci.karatay.edu.tr"});
            this.ogpost.Location = new System.Drawing.Point(191, 110);
            this.ogpost.Name = "ogpost";
            this.ogpost.Size = new System.Drawing.Size(99, 27);
            this.ogpost.TabIndex = 27;
            // 
            // uyetel
            // 
            this.uyetel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyetel.ForeColor = System.Drawing.Color.Black;
            this.uyetel.Location = new System.Drawing.Point(20, 55);
            this.uyetel.Mask = "(999) 000-0000";
            this.uyetel.Name = "uyetel";
            this.uyetel.Size = new System.Drawing.Size(270, 27);
            this.uyetel.TabIndex = 20;
            // 
            // uyeadres
            // 
            this.uyeadres.Location = new System.Drawing.Point(20, 205);
            this.uyeadres.Multiline = true;
            this.uyeadres.Name = "uyeadres";
            this.uyeadres.Size = new System.Drawing.Size(270, 77);
            this.uyeadres.TabIndex = 23;
            this.uyeadres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyesoyad_KeyPress);
            // 
            // kisiselposta
            // 
            this.kisiselposta.Location = new System.Drawing.Point(20, 155);
            this.kisiselposta.Name = "kisiselposta";
            this.kisiselposta.Size = new System.Drawing.Size(165, 27);
            this.kisiselposta.TabIndex = 22;
            this.kisiselposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyesoyad_KeyPress);
            // 
            // ogrenciposta
            // 
            this.ogrenciposta.Location = new System.Drawing.Point(20, 110);
            this.ogrenciposta.Name = "ogrenciposta";
            this.ogrenciposta.Size = new System.Drawing.Size(165, 27);
            this.ogrenciposta.TabIndex = 21;
            this.ogrenciposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uyesoyad_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkGray;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(20, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 22);
            this.label15.TabIndex = 19;
            this.label15.Text = "Adres :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(20, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 22);
            this.label14.TabIndex = 18;
            this.label14.Text = "Kişisel E-Posta :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGray;
            this.label13.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(20, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 22);
            this.label13.TabIndex = 17;
            this.label13.Text = "Öğrenci E-Posta :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGray;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Telefon No :*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyeolbuton
            // 
            this.uyeolbuton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uyeolbuton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.uyeolbuton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyeolbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyeolbuton.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeolbuton.ForeColor = System.Drawing.Color.Black;
            this.uyeolbuton.Location = new System.Drawing.Point(340, 466);
            this.uyeolbuton.Name = "uyeolbuton";
            this.uyeolbuton.Size = new System.Drawing.Size(344, 47);
            this.uyeolbuton.TabIndex = 17;
            this.uyeolbuton.Text = "Üye Ol";
            this.uyeolbuton.UseVisualStyleBackColor = false;
            this.uyeolbuton.Click += new System.EventHandler(this.uyeolbuton_Click);
            // 
            // gerialmabutton
            // 
            this.gerialmabutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gerialmabutton.FlatAppearance.BorderSize = 0;
            this.gerialmabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerialmabutton.Image = global::toplulukotomasyon.Properties.Resources.icons8_undo_24px;
            this.gerialmabutton.Location = new System.Drawing.Point(15, 12);
            this.gerialmabutton.Name = "gerialmabutton";
            this.gerialmabutton.Size = new System.Drawing.Size(55, 25);
            this.gerialmabutton.TabIndex = 19;
            this.gerialmabutton.TabStop = false;
            this.gerialmabutton.UseVisualStyleBackColor = false;
            this.gerialmabutton.Click += new System.EventHandler(this.gerialmabutton_Click);
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1025, 546);
            this.Controls.Add(this.gerialmabutton);
            this.Controls.Add(this.uyeolbuton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeOl";
            this.Load += new System.EventHandler(this.UyeOl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox uyecinsiyet;
        private System.Windows.Forms.DateTimePicker uyedtarih;
        private System.Windows.Forms.TextBox uyesoyad;
        private System.Windows.Forms.TextBox uyead;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sinift;
        private System.Windows.Forms.ComboBox bolumt;
        private System.Windows.Forms.ComboBox fakultet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uyeogrencino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uyeadres;
        private System.Windows.Forms.TextBox kisiselposta;
        private System.Windows.Forms.TextBox ogrenciposta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button uyeolbuton;
        private System.Windows.Forms.Button gerialmabutton;
        private System.Windows.Forms.MaskedTextBox uyetc;
        private System.Windows.Forms.MaskedTextBox uyetel;
        private System.Windows.Forms.ComboBox ogpost;
        private System.Windows.Forms.ComboBox kpost;
    }
}