using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace formekspedisi
{
    /* Mohammad Aris Saputra
     * 18051204041
       TI 2018*/
    public partial class Home : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentChildForm;

        //constructor
        public Home()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //Struct
        private struct RGBcolors
        {
              public static Color color1 = Color.FromArgb(172, 126, 241);
              public static Color color2 = Color.FromArgb(249, 118, 176);
              public static Color color3 = Color.FromArgb(253, 138, 114);
              public static Color color4 = Color.FromArgb(95, 77, 221);
              public static Color color5 = Color.FromArgb(249, 88, 155);
              public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Method
        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 38, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(3, 5, 37);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void btnPengiriman_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color1);
            openChildForm(new Form1());
        }

        private void btnResi_Click(object sender, EventArgs e)
        {
            if(Form1.report_namapengirim != "" && Form1.report_nopengirim != "" && Form1.report_jenisbarang != "" && Form1.report_jenispengiriman != "" && Form1.report_beratbarang != "" && Form1.report_panjangbarang != "" && Form1.report_lebarbarang != "" && Form1.report_tinggibarang != "" && Form1.report_namapenerima != "" && Form1.report_nopenerima != "" && Form1.report_provinsipenerima != "" && Form1.report_kotapenerima != "" && Form1.report_kecamatanpenerima != "" && Form1.report_kodepospenerima != "" && Form1.report_alamatpenerima != "")
            {
                ActiveButton(sender, RGBcolors.color2);
                openChildForm(new Resi());
            }
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color4);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            titlePanel.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
     
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisableButton();
            Color color = RGBcolors.color1;
            //Button
            currentBtn = btnPengiriman;
            currentBtn.BackColor = Color.FromArgb(37, 38, 81);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;

            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            //left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            //Icon Current Child Form
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
            
            openChildForm(new Form1());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
