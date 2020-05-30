using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace formekspedisi
{
    /* Mohammad Aris Saputra
     * 18051204041
       TI 2018*/
    public partial class Form1 : Form
    {
        Home h1 = new Home();
        public static String report_namapengirim = "", 
                report_nopengirim = "",
                report_jenisbarang = "",
                report_desbarang = "",
                report_beratbarang = "",
                report_jenispengiriman = "",
                report_panjangbarang = "",
                report_lebarbarang = "",
                report_tinggibarang = "",
                report_is_pecahbelah = "",
                report_namapenerima = "",
                report_nopenerima = "",
                report_provinsipenerima = "",
                report_kotapenerima = "",
                report_kecamatanpenerima = "",
                report_kodepospenerima = "",
                report_alamatpenerima = "";

        private void jpengiriman_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) jenis_pengiriman.DroppedDown = true;
            //if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) berat_barang.Focus();
            else if (e.KeyChar == 37) deskripsi_barang.Focus();
        }

        private void berat_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) panjang_barang.Focus();
            else if (e.KeyChar == 37) jenis_pengiriman.Focus();
        }

        private void panjang_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) lebar_barang.Focus();
            else if (e.KeyChar == 37) berat_barang.Focus();
        }

        private void lebar_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) tinggi_barang.Focus();
            else if (e.KeyChar == 37) panjang_barang.Focus();
        }

        private void provinsi_penerima_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (provinsi_penerima.Text == "DKI JAKARTA")
            {
                kota_penerima.Items.Clear();
                kota_penerima.Items.AddRange(new object[]{
                    "JAKARTA UTARA",
                    "JAKARTA BARAT",
                    "JAKARTA PUSAT",
                    "JAKARTA TIMUR",
                    "JAKARTA SELATAN"
                });
            }
            else if (provinsi_penerima.Text == "JAWA BARAT")
            {
                kota_penerima.Items.Clear();
                kota_penerima.Items.AddRange(new object[]{
                    "BANDUNG",
                    "TASIKMALAYA",
                    "MAJALENGKA"
                });
            }
            else if (provinsi_penerima.Text == "JAWA TENGAH")
            {
                kota_penerima.Items.Clear();
                kota_penerima.Items.AddRange(new object[]{
                    "SEMARANG",
                    "SOLO",
                    "PEKALONGAN"
                });
            }
            else if (provinsi_penerima.Text == "JAWA TIMUR")
            {
                kota_penerima.Items.Clear();
                kota_penerima.Items.AddRange(new object[]{
                    "SURABAYA",
                    "SIDOARJO",
                    "PASURUAN",
                    "GRESIK",
                    "LAMONGAN"
                });
            }
        }

        private void kota_penerima_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kota_penerima.Text == "JAKARTA UTARA")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "KELAPA GADING"
                });
            }
            
            else if (kota_penerima.Text == "JAKARTA TIMUR")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "CAKUNG"
                });
            }
            
            else if (kota_penerima.Text == "JAKARTA BARAT")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "CENGKARENG"
                });
            }

            else if (kota_penerima.Text == "JAKARTA SELATAN")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "CILANDAK"
                });
            }

            else if (kota_penerima.Text == "JAKARTA PUSAT")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "GAMBIR"
                });
            }

            else if (kota_penerima.Text == "BANDUNG")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "ANDIR"
                });
            }

            else if (kota_penerima.Text == "TASIKMALAYA")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "BUNGURSARI"
                });
            }

            else if (kota_penerima.Text == "MAJALENGKA")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "MAJALENGKA"
                });
            }

            else if (kota_penerima.Text == "SEMARANG")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "GENUK"
                });
            }

            else if (kota_penerima.Text == "SOLO")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "BANJARSARI"
                });
            }

            else if (kota_penerima.Text == "PEKALONGAN")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "PEKALONGAN BARAT"
                });
            }

            else if (kota_penerima.Text == "SURABAYA")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "GUBENG"
                });
            }

            else if (kota_penerima.Text == "SIDOARJO")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "SIDOARJO",
                    "GEDANGAN",
                    "WARU",
                    "BUDURAN",
                    "PORONG",
                    "TANGGULANGIN"
                });
            }

            else if (kota_penerima.Text == "PASURUAN")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "GEMPOL"
                });
            }

            else if (kota_penerima.Text == "GRESIK")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "DRIYOREJO"
                });
            }

            else if (kota_penerima.Text == "LAMONGAN")
            {
                kecematan_penerima.Items.Clear();
                kecematan_penerima.Items.AddRange(new object[]
                {
                    "BABAT"
                });
            }
        }

        private void kecematan_penerima_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kecematan_penerima.Text == "KELAPA GADING")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "14240",
                    "14250"
                 });
            }

            else if (kecematan_penerima.Text == "CAKUNG")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "13910",
                    "13920",
                    "13930",
                    "13940",
                    "13950",
                    "13960"
                 });
            }

            else if (kecematan_penerima.Text == "CENGKARENG")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "11710",
                    "11720",
                    "11730",
                    "11740",
                    "11750"
                 });
            }

            else if (kecematan_penerima.Text == "CILANDAK")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "12410",
                    "12420",
                    "12430",
                    "12440",
                    "12450"
                 });
            }

            else if (kecematan_penerima.Text == "GAMBIR")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "10110",
                    "10120",
                    "10130",
                    "10140",
                    "10150",
                    "10160"
                 });
            }

            else if (kecematan_penerima.Text == "ANDIR")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "40181",
                    "40182",
                    "40183",
                    "40184"
                 });
            }

            else if (kecematan_penerima.Text == "BUNGURSARI")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "46151"
                 });
            }

            else if (kecematan_penerima.Text == "MAJALENGKA")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "45411",
                    "45412",
                    "45414",
                    "45415",
                    "45416",
                    "45417",
                    "45418",
                    "45419"
                 });
            }

            else if (kecematan_penerima.Text == "GENUK")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "50111",
                    "50112",
                    "50113",
                    "50115",
                    "50116",
                    "50117",
                    "50118",
                    "50231"
                 });
            }

            else if (kecematan_penerima.Text == "BANJARSARI")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "57130",
                    "57131",
                    "57132",
                    "57133",
                    "57134",
                    "57135",
                    "57136",
                    "57137",
                    "57138",
                    "57139"
                 });
            }

            else if (kecematan_penerima.Text == "PEKALONGAN BARAT")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "51111",
                    "51112",
                    "51113",
                    "51116",
                    "51117",
                    "51151"
                 });
            }

            else if (kecematan_penerima.Text == "GUBENG")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "60281",
                    "60282",
                    "60283",
                    "60285",
                    "60286"
                 });
            }

            else if (kecematan_penerima.Text == "SIDOARJO")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "61212",
                    "61213",
                    "61214",
                    "61215",
                    "61217",
                    "61218",
                    "61219",
                    "61223",
                    "61224",
                    "61225",
                    "61226",
                    "61228",
                    "61231",
                    "61233",
                    "61234"
                 });
            }
            
            else if (kecematan_penerima.Text == "GEDANGAN")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "61254"
                 });
            }
            
            else if (kecematan_penerima.Text == "WARU")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "61256"
                 });
            }
            
            else if (kecematan_penerima.Text == "BUDURAN")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "61252"
                 });
            }
            
            else if (kecematan_penerima.Text == "PORONG")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "61274"
                 });
            }
            
            else if (kecematan_penerima.Text == "TANGGULANGIN")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "61272"
                 });
            }

            else if (kecematan_penerima.Text == "GEMPOL")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "67155"
                 });
            }

            else if (kecematan_penerima.Text == "DRIYOREJO")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "61177"
                 });
            }

            else if (kecematan_penerima.Text == "BABAT")
            {
                kodepos_penerima.Items.Clear();
                kodepos_penerima.Items.AddRange(new object[]
                 {
                    "62271"
                 });
            }
        }

        private void nama_penerima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) no_teleponpenerima.Focus();
            else if (e.KeyChar == 37) this.Focus();
        }

        private void no_teleponpenerima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) provinsi_penerima.Focus();
            else if (e.KeyChar == 37) nama_penerima.Focus();
        }

        private void provinsi_penerima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) provinsi_penerima.DroppedDown = true;
            //if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) kota_penerima.Focus();
            else if (e.KeyChar == 37) no_teleponpenerima.Focus();
        }

        private void kota_penerima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) provinsi_penerima.DroppedDown = true;
            //if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) kota_penerima.Focus();
            else if (e.KeyChar == 37) no_teleponpenerima.Focus();
        }

        private void kecematan_penerima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) provinsi_penerima.DroppedDown = true;
            //if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) kota_penerima.Focus();
            else if (e.KeyChar == 37) no_teleponpenerima.Focus();
        }

        private void alamat_penerima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) simpan.Focus();
            else if (e.KeyChar == 37) kecematan_penerima.Focus();
        }

        private void tinggi_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) simpan.Focus();
            else if (e.KeyChar == 37) lebar_barang.Focus();
        }

        private void next_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                report_namapengirim = nama_pengirim.Text;
                report_nopengirim = no_pengirim.Text;
                report_jenisbarang = jenis_barang.Text;
                report_desbarang = deskripsi_barang.Text;
                report_panjangbarang = panjang_barang.Text;
                report_lebarbarang = lebar_barang.Text;
                report_tinggibarang = tinggi_barang.Text;
                report_beratbarang = berat_barang.Text;
                report_jenispengiriman = jenis_pengiriman.Text;
                report_namapenerima = nama_penerima.Text;
                report_nopenerima = no_teleponpenerima.Text;
                report_provinsipenerima = provinsi_penerima.Text;
                report_kotapenerima = kota_penerima.Text;
                report_kecamatanpenerima = kecematan_penerima.Text;
                report_kodepospenerima = kodepos_penerima.Text;
                report_alamatpenerima = alamat_penerima.Text;
                if (is_bisapecah.Checked == true)
                {
                    report_is_pecahbelah = "Pecah belah";
                }
                else
                {
                    report_is_pecahbelah = "Tidak pecah belah";
                }
                if (report_namapengirim == "" || report_nopengirim == "" || report_jenisbarang == "" || report_jenispengiriman == "" || report_beratbarang == "" || report_panjangbarang == "" || report_lebarbarang == "" || report_tinggibarang == "" || report_namapenerima == "" || report_nopenerima == "" || report_provinsipenerima == "" || report_kotapenerima == "" || report_kecamatanpenerima == "" || report_kodepospenerima == "" || report_alamatpenerima == "")
                {
                    if (report_namapengirim == "") dangernamapengirim.Visible = true;
                    if (report_nopengirim == "") dangernopengirim.Visible = true;
                    if (report_jenisbarang == "") dangerjenisbarang.Visible = true;
                    if (report_jenispengiriman == "") dangerjenispengiriman.Visible = true;
                    if (report_beratbarang == "") dangerberat.Visible = true;
                    if (report_panjangbarang == "") dangerpanjang.Visible = true;
                    if (report_lebarbarang == "") dangerlebar.Visible = true;
                    if (report_tinggibarang == "") dangertinggi.Visible = true;
                    if (report_namapenerima == "") dangernamapenerima.Visible = true;
                    if (report_nopenerima == "") dangernoteleponpenerima.Visible = true;
                    if (report_provinsipenerima == "") dangerprovinsi.Visible = true;
                    if (report_kotapenerima == "") dangerkota.Visible = true;
                    if (report_kecamatanpenerima == "") dangerkecamatan.Visible = true;
                    if (report_alamatpenerima == "") dangeralamat.Visible = true;
                    if (report_kodepospenerima == "") dangerkodepos.Visible = true;

                    caution.Location = new Point(533, 475);
                    caution.Text = "*) Maaf Field Tidak Boleh Kosong !";
                    caution.ForeColor = Color.Red;
                }
                else
                {
                    caution.Location = new Point(368, 475);
                    caution.Text = "Data Tersimpan, Silahkan Buka Menu Resi Untuk Melihat Resi";
                    caution.ForeColor = Color.MediumPurple;
                }
            }
            else if (e.KeyChar == 37) tinggi_barang.Focus();
        }

        private void is_bisapecah_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jenis_barang_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void deskripsi_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) jenis_pengiriman.Focus();
            else if (e.KeyChar == 37) is_bisapecah.Focus();
        }

        private void ispecah_keypress(object sender, KeyPressEventArgs e)
        {
            int enter = 0;
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39 && enter == 0)
            {
                is_bisapecah.Checked = true;
                enter = 1;
            }
            //if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39 && enter == 1) deskripsi_barang.Focus();
            else if (e.KeyChar == 37) jenis_barang.Focus();
        }

        private void jbarang_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) 
            {
                jenis_barang.Focus();
                jenis_barang.DroppedDown = true;
            } 

            else if (e.KeyChar == 37) no_pengirim.Focus();
        }

        private void notelepon_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) jenis_barang.Focus();
            else if (e.KeyChar == 37) nama_pengirim.Focus();
        }

        private void nama_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 39) no_pengirim.Focus();
            else if (e.KeyChar == 37) this.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }
       

        private void label_menu(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            report_namapengirim = nama_pengirim.Text;
            report_nopengirim = no_pengirim.Text;
            report_jenisbarang = jenis_barang.Text;
            report_desbarang = deskripsi_barang.Text;
            report_panjangbarang = panjang_barang.Text;
            report_lebarbarang = lebar_barang.Text;
            report_tinggibarang = tinggi_barang.Text;
            report_beratbarang = berat_barang.Text;
            report_jenispengiriman = jenis_pengiriman.Text;
            report_namapenerima = nama_penerima.Text;
            report_nopenerima = no_teleponpenerima.Text;
            report_provinsipenerima = provinsi_penerima.Text;
            report_kotapenerima = kota_penerima.Text;
            report_kecamatanpenerima = kecematan_penerima.Text;
            report_kodepospenerima = kodepos_penerima.Text;
            report_alamatpenerima = alamat_penerima.Text;
            if (is_bisapecah.Checked == true)
            {
                report_is_pecahbelah = "Pecah belah";
            }
            else
            {
                report_is_pecahbelah = "Tidak pecah belah";
            }
            if (report_namapengirim == "" || report_nopengirim == "" || report_jenisbarang == "" || report_jenispengiriman == "" || report_beratbarang == "" || report_panjangbarang == "" || report_lebarbarang == "" || report_tinggibarang == "" || report_namapenerima == "" || report_nopenerima == "" || report_provinsipenerima == "" || report_kotapenerima == "" || report_kecamatanpenerima == "" || report_kodepospenerima == "" || report_alamatpenerima == "")
            {
                if (report_namapengirim == "") dangernamapengirim.Visible = true;
                if (report_nopengirim == "") dangernopengirim.Visible = true;
                if (report_jenisbarang == "") dangerjenisbarang.Visible = true;
                if (report_jenispengiriman == "") dangerjenispengiriman.Visible = true;
                if (report_beratbarang == "") dangerberat.Visible = true;
                if (report_panjangbarang == "") dangerpanjang.Visible = true;
                if (report_lebarbarang == "") dangerlebar.Visible = true;
                if (report_tinggibarang == "") dangertinggi.Visible = true;
                if (report_namapenerima == "") dangernamapenerima.Visible = true;
                if (report_nopenerima == "") dangernoteleponpenerima.Visible = true;
                if (report_provinsipenerima == "") dangerprovinsi.Visible = true;
                if (report_kotapenerima == "") dangerkota.Visible = true;
                if (report_kecamatanpenerima == "") dangerkecamatan.Visible = true;
                if (report_alamatpenerima == "") dangeralamat.Visible = true;
                if (report_kodepospenerima == "") dangerkodepos.Visible = true;

                caution.Location = new Point(533, 475);
                caution.Text = "*) Maaf Field Tidak Boleh Kosong !";
                caution.ForeColor = Color.Red;      
            }
            else
            {
                caution.Location = new Point(368, 475);
                caution.Text = "Data Tersimpan, Silahkan Buka Menu Resi Untuk Melihat Resi";
                caution.ForeColor = Color.MediumPurple;
            }  
        }

        public void openChildForm(Form childForm)
        {
            if (h1.currentChildForm != null)
            {
                //open only form
                h1.currentChildForm.Close();
            }
            h1.currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            h1.panelDesktop.Controls.Add(childForm);
            h1.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void simpan_text(object sender, EventArgs e)
        {
            
        }

        
    }
}
