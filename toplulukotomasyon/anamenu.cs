using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace toplulukotomasyon
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UyeOl f2 = new UyeOl();
            f2.Dock = DockStyle.Fill;
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cıkısbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uyegirisbutton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UyeGiris f3 = new UyeGiris(this);
            f3.Dock = DockStyle.Fill;
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();

        }

        private void yetkiligirisbutton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            YetkiliGiris f4 = new YetkiliGiris(this);
            f4.Dock = DockStyle.Fill;
            f4.TopLevel = false;
            panel1.Controls.Add(f4);
            f4.Show();
        }

        private void altbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
