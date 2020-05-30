using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formekspedisi
{
    /* Mohammad Aris Saputra
     * 18051204041
       TI 2018*/
    public class hitung
    {
        public int ongkir(int panjang, int lebar, int tinggi, int berat, string kotapenerima)
        {
            int hasil, jarak=0;
            if (berat < 1) berat = 1;
            switch (kotapenerima){
                case "SIDOARJO":
                case "SURABAYA":
                case "GRESIK":
                case "PASURUAN":
                case "LAMONGAN":
                    jarak = 6000;
                    break;
                case "SEMARANG":
                case "SOLO":
                case "PEKALONGAN":
                    jarak = 9000;
                    break;
                case "BANDUNG":
                case "TASIKMALAYA":
                case "MAJALENGKA":
                    jarak = 11000;
                    break;
                case "JAKARTA UTARA":
                case "JAKARTA BARAT":
                case "JAKARTA PUSAT":
                case "JAKARTA TIMUR":
                case "JAKARTA SELATAN":
                    jarak = 14000;
                    break;
                default:
                    jarak = 0;
                    break;
            }
            hasil = ((lebar * panjang * tinggi) * 1) + (berat * 500) + jarak;
            return hasil;
        }
        public int asuransi(string pengiriman)
        {
            int hasil;
            switch (pengiriman)
            {
                case "REGULER":
                    hasil = 0;
                    break;
                case "EXPRESS":
                    hasil = 1000;
                    break;
                default:
                    hasil = 0;
                    break;
            }
            return hasil;
        }

        public string kode (string pengiriman)
        {
            string hasil;
            switch (pengiriman)
            {
                case "REGULER":
                    hasil = "REG";
                    break;
                case "EXPRESS":
                    hasil = "EZ";
                    break;
                default:
                    hasil = "";
                    break;
            }
            return hasil;
        }
    }
}
