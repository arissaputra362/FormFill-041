using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formekspedisi
{
    /* Mohammad Aris Saputra
     * 18051204041
       TI 2018*/
    public partial class Resi : Form
    {
        public Resi()
        {
            InitializeComponent();
        }

        private void Resi_Load(object sender, EventArgs e)
        {
            hitung hasil = new hitung();
            int panjang, lebar, tinggi, berat;
            panjang = int.Parse(Form1.report_panjangbarang);
            lebar = int.Parse(Form1.report_lebarbarang);
            tinggi = int.Parse(Form1.report_tinggibarang);
            berat = int.Parse(Form1.report_beratbarang);

            data_pengirim.Text = Form1.report_namapengirim + ", " + Form1.report_nopengirim;
            data_penerima.Text = Form1.report_namapenerima + ", " + Form1.report_nopenerima;
            alamat_penerima.Text = Form1.report_kodepospenerima + ", " + Form1.report_kecamatanpenerima + ", " + Form1.report_kotapenerima + ", " + Form1.report_provinsipenerima + ", " + Form1.report_alamatpenerima;
            jenis_pengiriman.Text = hasil.kode(Form1.report_jenispengiriman);
            berat_barang.Text = Form1.report_beratbarang + " KG";
            txt_deskripsi.Text = Form1.report_desbarang + " " + Form1.report_is_pecahbelah;
            ongkir.Text = (hasil.ongkir(panjang, lebar, tinggi, berat, Form1.report_kotapenerima)).ToString("C") + ",00";
            b_asuransi.Text = (hasil.asuransi(Form1.report_jenispengiriman)).ToString("C") + ",00";
            total.Text = ((hasil.ongkir(panjang, lebar, tinggi, berat, Form1.report_kotapenerima)) + (hasil.asuransi(Form1.report_jenispengiriman))).ToString("C") + ",00";

            Zen.Barcode.Code128BarcodeDraw Barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            barcode_img.Image = Barcode.Draw(resi_id.Text, 4000);

            Zen.Barcode.CodeQrBarcodeDraw Qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            qrcode_img.Image = Qrcode.Draw(resi_id.Text, 1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
