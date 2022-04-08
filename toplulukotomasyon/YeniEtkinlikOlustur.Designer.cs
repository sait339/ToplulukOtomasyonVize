
namespace toplulukotomasyon
{
    partial class YeniEtkinlikOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniEtkinlikOlustur));
            this.adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yer = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adi
            // 
            resources.ApplyResources(this.adi, "adi");
            this.adi.Name = "adi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // yer
            // 
            resources.ApplyResources(this.yer, "yer");
            this.yer.Name = "yer";
            // 
            // aciklama
            // 
            resources.ApplyResources(this.aciklama, "aciklama");
            this.aciklama.Name = "aciklama";
            // 
            // tarih
            // 
            resources.ApplyResources(this.tarih, "tarih");
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.MinDate = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            this.tarih.Name = "tarih";
            this.tarih.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            this.tarih.ValueChanged += new System.EventHandler(this.tarih_ValueChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YeniEtkinlikOlustur
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.Name = "YeniEtkinlikOlustur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yer;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Button button1;
    }
}