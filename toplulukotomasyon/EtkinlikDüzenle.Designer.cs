
namespace toplulukotomasyon
{
    partial class EtkinlikDüzenle
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
            this.button1 = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.yer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(533, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 63);
            this.button1.TabIndex = 18;
            this.button1.Text = "Etkinliği Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarih
            // 
            this.tarih.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(137, 113);
            this.tarih.MinDate = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 27);
            this.tarih.TabIndex = 17;
            this.tarih.Value = new System.DateTime(2021, 12, 15, 1, 15, 30, 0);
            this.tarih.ValueChanged += new System.EventHandler(this.tarih_ValueChanged);
            // 
            // aciklama
            // 
            this.aciklama.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.aciklama.Location = new System.Drawing.Point(137, 193);
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(390, 234);
            this.aciklama.TabIndex = 16;
            // 
            // yer
            // 
            this.yer.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.yer.Location = new System.Drawing.Point(137, 155);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(390, 27);
            this.yer.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(88, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(73, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Etkinlik Adı:";
            // 
            // adi
            // 
            this.adi.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.adi.Location = new System.Drawing.Point(137, 69);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(390, 27);
            this.adi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 14.25F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(22, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Etkinlik Seç:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(390, 27);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // EtkinlikDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(769, 443);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.yer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EtkinlikDüzenle";
            this.Text = "EtkinlikDüzenle";
            this.Load += new System.EventHandler(this.EtkinlikDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.TextBox yer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}