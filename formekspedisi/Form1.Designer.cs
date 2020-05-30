namespace formekspedisi
{
    partial class Form1
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
            this.jenis_pengiriman = new System.Windows.Forms.ComboBox();
            this.berat_barang = new System.Windows.Forms.TextBox();
            this.is_bisapecah = new System.Windows.Forms.CheckBox();
            this.jenis_barang = new System.Windows.Forms.ComboBox();
            this.deskripsi_barang = new System.Windows.Forms.TextBox();
            this.no_pengirim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nama_pengirim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panjang_barang = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lebar_barang = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tinggi_barang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kecematan_penerima = new System.Windows.Forms.ComboBox();
            this.kota_penerima = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.provinsi_penerima = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.alamat_penerima = new System.Windows.Forms.TextBox();
            this.no_teleponpenerima = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nama_penerima = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panelBatas = new System.Windows.Forms.Panel();
            this.dangernamapengirim = new System.Windows.Forms.Label();
            this.dangernopengirim = new System.Windows.Forms.Label();
            this.dangerjenisbarang = new System.Windows.Forms.Label();
            this.dangerjenispengiriman = new System.Windows.Forms.Label();
            this.dangerberat = new System.Windows.Forms.Label();
            this.dangerpanjang = new System.Windows.Forms.Label();
            this.dangerlebar = new System.Windows.Forms.Label();
            this.dangertinggi = new System.Windows.Forms.Label();
            this.dangernamapenerima = new System.Windows.Forms.Label();
            this.dangernoteleponpenerima = new System.Windows.Forms.Label();
            this.dangerprovinsi = new System.Windows.Forms.Label();
            this.dangerkota = new System.Windows.Forms.Label();
            this.dangerkecamatan = new System.Windows.Forms.Label();
            this.dangeralamat = new System.Windows.Forms.Label();
            this.caution = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.kodepos_penerima = new System.Windows.Forms.ComboBox();
            this.dangerkodepos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jenis_pengiriman
            // 
            this.jenis_pengiriman.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis_pengiriman.ForeColor = System.Drawing.SystemColors.WindowText;
            this.jenis_pengiriman.FormattingEnabled = true;
            this.jenis_pengiriman.Items.AddRange(new object[] {
            "REGULER",
            "EXPRESS"});
            this.jenis_pengiriman.Location = new System.Drawing.Point(35, 357);
            this.jenis_pengiriman.Name = "jenis_pengiriman";
            this.jenis_pengiriman.Size = new System.Drawing.Size(182, 25);
            this.jenis_pengiriman.TabIndex = 6;
            this.jenis_pengiriman.TextChanged += new System.EventHandler(this.simpan_text);
            this.jenis_pengiriman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jpengiriman_keypress);
            // 
            // berat_barang
            // 
            this.berat_barang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berat_barang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.berat_barang.Location = new System.Drawing.Point(35, 415);
            this.berat_barang.Name = "berat_barang";
            this.berat_barang.Size = new System.Drawing.Size(40, 25);
            this.berat_barang.TabIndex = 7;
            this.berat_barang.TextChanged += new System.EventHandler(this.simpan_text);
            this.berat_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.berat_keypress);
            // 
            // is_bisapecah
            // 
            this.is_bisapecah.AutoSize = true;
            this.is_bisapecah.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_bisapecah.ForeColor = System.Drawing.Color.Gainsboro;
            this.is_bisapecah.Location = new System.Drawing.Point(247, 208);
            this.is_bisapecah.Name = "is_bisapecah";
            this.is_bisapecah.Size = new System.Drawing.Size(107, 21);
            this.is_bisapecah.TabIndex = 4;
            this.is_bisapecah.Text = "Pecah belah ?";
            this.is_bisapecah.UseVisualStyleBackColor = true;
            this.is_bisapecah.CheckedChanged += new System.EventHandler(this.is_bisapecah_CheckedChanged);
            this.is_bisapecah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ispecah_keypress);
            // 
            // jenis_barang
            // 
            this.jenis_barang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis_barang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.jenis_barang.FormattingEnabled = true;
            this.jenis_barang.Items.AddRange(new object[] {
            "Sepatu",
            "Baju",
            "Elektronik",
            "Kaca"});
            this.jenis_barang.Location = new System.Drawing.Point(32, 206);
            this.jenis_barang.Name = "jenis_barang";
            this.jenis_barang.Size = new System.Drawing.Size(182, 25);
            this.jenis_barang.TabIndex = 3;
            this.jenis_barang.SelectedIndexChanged += new System.EventHandler(this.jenis_barang_SelectedIndexChanged);
            this.jenis_barang.TextChanged += new System.EventHandler(this.simpan_text);
            this.jenis_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jbarang_keypress);
            // 
            // deskripsi_barang
            // 
            this.deskripsi_barang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskripsi_barang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deskripsi_barang.Location = new System.Drawing.Point(32, 265);
            this.deskripsi_barang.Multiline = true;
            this.deskripsi_barang.Name = "deskripsi_barang";
            this.deskripsi_barang.Size = new System.Drawing.Size(376, 61);
            this.deskripsi_barang.TabIndex = 5;
            this.deskripsi_barang.TextChanged += new System.EventHandler(this.simpan_text);
            this.deskripsi_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deskripsi_keypress);
            // 
            // no_pengirim
            // 
            this.no_pengirim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_pengirim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.no_pengirim.Location = new System.Drawing.Point(34, 115);
            this.no_pengirim.Name = "no_pengirim";
            this.no_pengirim.Size = new System.Drawing.Size(220, 25);
            this.no_pengirim.TabIndex = 2;
            this.no_pengirim.TextChanged += new System.EventHandler(this.simpan_text);
            this.no_pengirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notelepon_keypress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(27, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Barang";
            // 
            // nama_pengirim
            // 
            this.nama_pengirim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_pengirim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nama_pengirim.Location = new System.Drawing.Point(33, 60);
            this.nama_pengirim.Name = "nama_pengirim";
            this.nama_pengirim.Size = new System.Drawing.Size(375, 25);
            this.nama_pengirim.TabIndex = 1;
            this.nama_pengirim.TextChanged += new System.EventHandler(this.simpan_text);
            this.nama_pengirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nama_keypress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(75, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pengirim";
            // 
            // simpan
            // 
            this.simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(14)))), ((int)(((byte)(82)))));
            this.simpan.FlatAppearance.BorderSize = 0;
            this.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpan.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.ForeColor = System.Drawing.Color.Gainsboro;
            this.simpan.Location = new System.Drawing.Point(784, 466);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(90, 40);
            this.simpan.TabIndex = 17;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = false;
            this.simpan.Click += new System.EventHandler(this.button1_Click);
            this.simpan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.next_keypress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(25, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = " Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = " Jenis Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(26, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = " No. Telepon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(29, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Deskripsi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(31, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Jenis Pengiriman";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(31, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Berat";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(183, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "cm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(139, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Panjang";
            // 
            // panjang_barang
            // 
            this.panjang_barang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panjang_barang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panjang_barang.Location = new System.Drawing.Point(143, 415);
            this.panjang_barang.Name = "panjang_barang";
            this.panjang_barang.Size = new System.Drawing.Size(40, 25);
            this.panjang_barang.TabIndex = 8;
            this.panjang_barang.TextChanged += new System.EventHandler(this.simpan_text);
            this.panjang_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.panjang_keypress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(250, 418);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "cm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(207, 391);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Lebar";
            // 
            // lebar_barang
            // 
            this.lebar_barang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebar_barang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lebar_barang.Location = new System.Drawing.Point(211, 415);
            this.lebar_barang.Name = "lebar_barang";
            this.lebar_barang.Size = new System.Drawing.Size(40, 25);
            this.lebar_barang.TabIndex = 9;
            this.lebar_barang.TextChanged += new System.EventHandler(this.simpan_text);
            this.lebar_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lebar_keypress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(325, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "cm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(277, 391);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tinggi";
            // 
            // tinggi_barang
            // 
            this.tinggi_barang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinggi_barang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tinggi_barang.Location = new System.Drawing.Point(281, 415);
            this.tinggi_barang.Name = "tinggi_barang";
            this.tinggi_barang.Size = new System.Drawing.Size(40, 25);
            this.tinggi_barang.TabIndex = 10;
            this.tinggi_barang.TextChanged += new System.EventHandler(this.simpan_text);
            this.tinggi_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tinggi_keypress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumPurple;
            this.label10.Location = new System.Drawing.Point(463, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Data Penerima";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumPurple;
            this.label11.Location = new System.Drawing.Point(463, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Alamat Tujuan";
            // 
            // kecematan_penerima
            // 
            this.kecematan_penerima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kecematan_penerima.FormattingEnabled = true;
            this.kecematan_penerima.Location = new System.Drawing.Point(467, 265);
            this.kecematan_penerima.Name = "kecematan_penerima";
            this.kecematan_penerima.Size = new System.Drawing.Size(180, 25);
            this.kecematan_penerima.TabIndex = 15;
            this.kecematan_penerima.SelectedIndexChanged += new System.EventHandler(this.kecematan_penerima_SelectedIndexChanged);
            this.kecematan_penerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kecematan_penerima_KeyPress);
            // 
            // kota_penerima
            // 
            this.kota_penerima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kota_penerima.FormattingEnabled = true;
            this.kota_penerima.Location = new System.Drawing.Point(662, 206);
            this.kota_penerima.Name = "kota_penerima";
            this.kota_penerima.Size = new System.Drawing.Size(180, 25);
            this.kota_penerima.TabIndex = 14;
            this.kota_penerima.SelectedIndexChanged += new System.EventHandler(this.kota_penerima_SelectedIndexChanged);
            this.kota_penerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kota_penerima_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(464, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Alamat Lengkap";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(464, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Kecamatan";
            // 
            // provinsi_penerima
            // 
            this.provinsi_penerima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinsi_penerima.FormattingEnabled = true;
            this.provinsi_penerima.Items.AddRange(new object[] {
            "DKI JAKARTA",
            "JAWA BARAT",
            "JAWA TENGAH",
            "JAWA TIMUR"});
            this.provinsi_penerima.Location = new System.Drawing.Point(467, 206);
            this.provinsi_penerima.Name = "provinsi_penerima";
            this.provinsi_penerima.Size = new System.Drawing.Size(180, 25);
            this.provinsi_penerima.TabIndex = 13;
            this.provinsi_penerima.SelectedIndexChanged += new System.EventHandler(this.provinsi_penerima_SelectedIndexChanged);
            this.provinsi_penerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.provinsi_penerima_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(659, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Kota/Kabupaten";
            // 
            // alamat_penerima
            // 
            this.alamat_penerima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_penerima.Location = new System.Drawing.Point(467, 333);
            this.alamat_penerima.Multiline = true;
            this.alamat_penerima.Name = "alamat_penerima";
            this.alamat_penerima.Size = new System.Drawing.Size(375, 85);
            this.alamat_penerima.TabIndex = 16;
            this.alamat_penerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alamat_penerima_KeyPress);
            // 
            // no_teleponpenerima
            // 
            this.no_teleponpenerima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_teleponpenerima.Location = new System.Drawing.Point(467, 115);
            this.no_teleponpenerima.Name = "no_teleponpenerima";
            this.no_teleponpenerima.Size = new System.Drawing.Size(220, 25);
            this.no_teleponpenerima.TabIndex = 12;
            this.no_teleponpenerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.no_teleponpenerima_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(464, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 17);
            this.label21.TabIndex = 17;
            this.label21.Text = "Provinsi";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(464, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 17);
            this.label22.TabIndex = 18;
            this.label22.Text = "No. Telepon";
            // 
            // nama_penerima
            // 
            this.nama_penerima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_penerima.Location = new System.Drawing.Point(467, 60);
            this.nama_penerima.Name = "nama_penerima";
            this.nama_penerima.Size = new System.Drawing.Size(375, 25);
            this.nama_penerima.TabIndex = 11;
            this.nama_penerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nama_penerima_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Gainsboro;
            this.label23.Location = new System.Drawing.Point(464, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 17);
            this.label23.TabIndex = 19;
            this.label23.Text = "Nama";
            // 
            // panelBatas
            // 
            this.panelBatas.BackColor = System.Drawing.Color.MediumPurple;
            this.panelBatas.Location = new System.Drawing.Point(438, 21);
            this.panelBatas.Name = "panelBatas";
            this.panelBatas.Size = new System.Drawing.Size(3, 414);
            this.panelBatas.TabIndex = 26;
            // 
            // dangernamapengirim
            // 
            this.dangernamapengirim.AutoSize = true;
            this.dangernamapengirim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangernamapengirim.ForeColor = System.Drawing.Color.Red;
            this.dangernamapengirim.Location = new System.Drawing.Point(73, 34);
            this.dangernamapengirim.Name = "dangernamapengirim";
            this.dangernamapengirim.Size = new System.Drawing.Size(17, 21);
            this.dangernamapengirim.TabIndex = 27;
            this.dangernamapengirim.Text = "*";
            this.dangernamapengirim.Visible = false;
            // 
            // dangernopengirim
            // 
            this.dangernopengirim.AutoSize = true;
            this.dangernopengirim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangernopengirim.ForeColor = System.Drawing.Color.Red;
            this.dangernopengirim.Location = new System.Drawing.Point(108, 88);
            this.dangernopengirim.Name = "dangernopengirim";
            this.dangernopengirim.Size = new System.Drawing.Size(17, 21);
            this.dangernopengirim.TabIndex = 27;
            this.dangernopengirim.Text = "*";
            this.dangernopengirim.Visible = false;
            // 
            // dangerjenisbarang
            // 
            this.dangerjenisbarang.AutoSize = true;
            this.dangerjenisbarang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerjenisbarang.ForeColor = System.Drawing.Color.Red;
            this.dangerjenisbarang.Location = new System.Drawing.Point(108, 179);
            this.dangerjenisbarang.Name = "dangerjenisbarang";
            this.dangerjenisbarang.Size = new System.Drawing.Size(17, 21);
            this.dangerjenisbarang.TabIndex = 27;
            this.dangerjenisbarang.Text = "*";
            this.dangerjenisbarang.Visible = false;
            // 
            // dangerjenispengiriman
            // 
            this.dangerjenispengiriman.AutoSize = true;
            this.dangerjenispengiriman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerjenispengiriman.ForeColor = System.Drawing.Color.Red;
            this.dangerjenispengiriman.Location = new System.Drawing.Point(138, 330);
            this.dangerjenispengiriman.Name = "dangerjenispengiriman";
            this.dangerjenispengiriman.Size = new System.Drawing.Size(17, 21);
            this.dangerjenispengiriman.TabIndex = 27;
            this.dangerjenispengiriman.Text = "*";
            this.dangerjenispengiriman.Visible = false;
            // 
            // dangerberat
            // 
            this.dangerberat.AutoSize = true;
            this.dangerberat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerberat.ForeColor = System.Drawing.Color.Red;
            this.dangerberat.Location = new System.Drawing.Point(73, 388);
            this.dangerberat.Name = "dangerberat";
            this.dangerberat.Size = new System.Drawing.Size(17, 21);
            this.dangerberat.TabIndex = 27;
            this.dangerberat.Text = "*";
            this.dangerberat.Visible = false;
            // 
            // dangerpanjang
            // 
            this.dangerpanjang.AutoSize = true;
            this.dangerpanjang.BackColor = System.Drawing.Color.Transparent;
            this.dangerpanjang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerpanjang.ForeColor = System.Drawing.Color.Red;
            this.dangerpanjang.Location = new System.Drawing.Point(188, 388);
            this.dangerpanjang.Name = "dangerpanjang";
            this.dangerpanjang.Size = new System.Drawing.Size(17, 21);
            this.dangerpanjang.TabIndex = 27;
            this.dangerpanjang.Text = "*";
            this.dangerpanjang.Visible = false;
            // 
            // dangerlebar
            // 
            this.dangerlebar.AutoSize = true;
            this.dangerlebar.BackColor = System.Drawing.Color.Transparent;
            this.dangerlebar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerlebar.ForeColor = System.Drawing.Color.Red;
            this.dangerlebar.Location = new System.Drawing.Point(249, 387);
            this.dangerlebar.Name = "dangerlebar";
            this.dangerlebar.Size = new System.Drawing.Size(17, 21);
            this.dangerlebar.TabIndex = 27;
            this.dangerlebar.Text = "*";
            this.dangerlebar.Visible = false;
            // 
            // dangertinggi
            // 
            this.dangertinggi.AutoSize = true;
            this.dangertinggi.BackColor = System.Drawing.Color.Transparent;
            this.dangertinggi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangertinggi.ForeColor = System.Drawing.Color.Red;
            this.dangertinggi.Location = new System.Drawing.Point(324, 388);
            this.dangertinggi.Name = "dangertinggi";
            this.dangertinggi.Size = new System.Drawing.Size(17, 21);
            this.dangertinggi.TabIndex = 27;
            this.dangertinggi.Text = "*";
            this.dangertinggi.Visible = false;
            // 
            // dangernamapenerima
            // 
            this.dangernamapenerima.AutoSize = true;
            this.dangernamapenerima.BackColor = System.Drawing.Color.Transparent;
            this.dangernamapenerima.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangernamapenerima.ForeColor = System.Drawing.Color.Red;
            this.dangernamapenerima.Location = new System.Drawing.Point(515, 35);
            this.dangernamapenerima.Name = "dangernamapenerima";
            this.dangernamapenerima.Size = new System.Drawing.Size(17, 21);
            this.dangernamapenerima.TabIndex = 27;
            this.dangernamapenerima.Text = "*";
            this.dangernamapenerima.Visible = false;
            // 
            // dangernoteleponpenerima
            // 
            this.dangernoteleponpenerima.AutoSize = true;
            this.dangernoteleponpenerima.BackColor = System.Drawing.Color.Transparent;
            this.dangernoteleponpenerima.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangernoteleponpenerima.ForeColor = System.Drawing.Color.Red;
            this.dangernoteleponpenerima.Location = new System.Drawing.Point(539, 88);
            this.dangernoteleponpenerima.Name = "dangernoteleponpenerima";
            this.dangernoteleponpenerima.Size = new System.Drawing.Size(17, 21);
            this.dangernoteleponpenerima.TabIndex = 27;
            this.dangernoteleponpenerima.Text = "*";
            this.dangernoteleponpenerima.Visible = false;
            // 
            // dangerprovinsi
            // 
            this.dangerprovinsi.AutoSize = true;
            this.dangerprovinsi.BackColor = System.Drawing.Color.Transparent;
            this.dangerprovinsi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerprovinsi.ForeColor = System.Drawing.Color.Red;
            this.dangerprovinsi.Location = new System.Drawing.Point(515, 178);
            this.dangerprovinsi.Name = "dangerprovinsi";
            this.dangerprovinsi.Size = new System.Drawing.Size(17, 21);
            this.dangerprovinsi.TabIndex = 27;
            this.dangerprovinsi.Text = "*";
            this.dangerprovinsi.Visible = false;
            // 
            // dangerkota
            // 
            this.dangerkota.AutoSize = true;
            this.dangerkota.BackColor = System.Drawing.Color.Transparent;
            this.dangerkota.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerkota.ForeColor = System.Drawing.Color.Red;
            this.dangerkota.Location = new System.Drawing.Point(758, 178);
            this.dangerkota.Name = "dangerkota";
            this.dangerkota.Size = new System.Drawing.Size(17, 21);
            this.dangerkota.TabIndex = 27;
            this.dangerkota.Text = "*";
            this.dangerkota.Visible = false;
            // 
            // dangerkecamatan
            // 
            this.dangerkecamatan.AutoSize = true;
            this.dangerkecamatan.BackColor = System.Drawing.Color.Transparent;
            this.dangerkecamatan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerkecamatan.ForeColor = System.Drawing.Color.Red;
            this.dangerkecamatan.Location = new System.Drawing.Point(533, 238);
            this.dangerkecamatan.Name = "dangerkecamatan";
            this.dangerkecamatan.Size = new System.Drawing.Size(17, 21);
            this.dangerkecamatan.TabIndex = 27;
            this.dangerkecamatan.Text = "*";
            this.dangerkecamatan.Visible = false;
            // 
            // dangeralamat
            // 
            this.dangeralamat.AutoSize = true;
            this.dangeralamat.BackColor = System.Drawing.Color.Transparent;
            this.dangeralamat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangeralamat.ForeColor = System.Drawing.Color.Red;
            this.dangeralamat.Location = new System.Drawing.Point(562, 305);
            this.dangeralamat.Name = "dangeralamat";
            this.dangeralamat.Size = new System.Drawing.Size(17, 21);
            this.dangeralamat.TabIndex = 27;
            this.dangeralamat.Text = "*";
            this.dangeralamat.Visible = false;
            // 
            // caution
            // 
            this.caution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.caution.AutoSize = true;
            this.caution.BackColor = System.Drawing.Color.Transparent;
            this.caution.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caution.ForeColor = System.Drawing.Color.MediumPurple;
            this.caution.Location = new System.Drawing.Point(533, 475);
            this.caution.Name = "caution";
            this.caution.Size = new System.Drawing.Size(0, 19);
            this.caution.TabIndex = 28;
            this.caution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(659, 241);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 17);
            this.label24.TabIndex = 15;
            this.label24.Text = "Kode Pos";
            // 
            // kodepos_penerima
            // 
            this.kodepos_penerima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodepos_penerima.FormattingEnabled = true;
            this.kodepos_penerima.Location = new System.Drawing.Point(662, 265);
            this.kodepos_penerima.Name = "kodepos_penerima";
            this.kodepos_penerima.Size = new System.Drawing.Size(180, 25);
            this.kodepos_penerima.TabIndex = 14;
            this.kodepos_penerima.SelectedIndexChanged += new System.EventHandler(this.kota_penerima_SelectedIndexChanged);
            this.kodepos_penerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kota_penerima_KeyPress);
            // 
            // dangerkodepos
            // 
            this.dangerkodepos.AutoSize = true;
            this.dangerkodepos.BackColor = System.Drawing.Color.Transparent;
            this.dangerkodepos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangerkodepos.ForeColor = System.Drawing.Color.Red;
            this.dangerkodepos.Location = new System.Drawing.Point(720, 237);
            this.dangerkodepos.Name = "dangerkodepos";
            this.dangerkodepos.Size = new System.Drawing.Size(17, 21);
            this.dangerkodepos.TabIndex = 27;
            this.dangerkodepos.Text = "*";
            this.dangerkodepos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(897, 525);
            this.Controls.Add(this.caution);
            this.Controls.Add(this.dangeralamat);
            this.Controls.Add(this.dangerkecamatan);
            this.Controls.Add(this.dangerkodepos);
            this.Controls.Add(this.dangerkota);
            this.Controls.Add(this.dangerprovinsi);
            this.Controls.Add(this.dangernoteleponpenerima);
            this.Controls.Add(this.dangernamapenerima);
            this.Controls.Add(this.dangertinggi);
            this.Controls.Add(this.dangerlebar);
            this.Controls.Add(this.dangerpanjang);
            this.Controls.Add(this.dangerberat);
            this.Controls.Add(this.dangerjenispengiriman);
            this.Controls.Add(this.dangerjenisbarang);
            this.Controls.Add(this.dangernopengirim);
            this.Controls.Add(this.dangernamapengirim);
            this.Controls.Add(this.panelBatas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kecematan_penerima);
            this.Controls.Add(this.kodepos_penerima);
            this.Controls.Add(this.kota_penerima);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.provinsi_penerima);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.alamat_penerima);
            this.Controls.Add(this.no_teleponpenerima);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.nama_penerima);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.jenis_pengiriman);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.tinggi_barang);
            this.Controls.Add(this.lebar_barang);
            this.Controls.Add(this.panjang_barang);
            this.Controls.Add(this.berat_barang);
            this.Controls.Add(this.is_bisapecah);
            this.Controls.Add(this.nama_pengirim);
            this.Controls.Add(this.jenis_barang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.deskripsi_barang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no_pengirim);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pengiriman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jenis_pengiriman;
        private System.Windows.Forms.TextBox berat_barang;
        private System.Windows.Forms.CheckBox is_bisapecah;
        private System.Windows.Forms.ComboBox jenis_barang;
        private System.Windows.Forms.TextBox deskripsi_barang;
        private System.Windows.Forms.TextBox no_pengirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama_pengirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox panjang_barang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox lebar_barang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tinggi_barang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox kecematan_penerima;
        private System.Windows.Forms.ComboBox kota_penerima;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox provinsi_penerima;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox alamat_penerima;
        private System.Windows.Forms.TextBox no_teleponpenerima;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox nama_penerima;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panelBatas;
        private System.Windows.Forms.Label dangernamapengirim;
        private System.Windows.Forms.Label dangernopengirim;
        private System.Windows.Forms.Label dangerjenisbarang;
        private System.Windows.Forms.Label dangerjenispengiriman;
        private System.Windows.Forms.Label dangerberat;
        private System.Windows.Forms.Label dangerpanjang;
        private System.Windows.Forms.Label dangerlebar;
        private System.Windows.Forms.Label dangertinggi;
        private System.Windows.Forms.Label dangernamapenerima;
        private System.Windows.Forms.Label dangernoteleponpenerima;
        private System.Windows.Forms.Label dangerprovinsi;
        private System.Windows.Forms.Label dangerkota;
        private System.Windows.Forms.Label dangerkecamatan;
        private System.Windows.Forms.Label dangeralamat;
        private System.Windows.Forms.Label caution;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox kodepos_penerima;
        private System.Windows.Forms.Label dangerkodepos;
    }
}

