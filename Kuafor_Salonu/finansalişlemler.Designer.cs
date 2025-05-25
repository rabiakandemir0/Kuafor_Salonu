namespace Kuafor_Salonu
{
    partial class finansalişlemler
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvSatislar = new DataGridView();
            btnSatisEkle = new Button();
            btnSatisGuncelle = new Button();
            btnSatisSil = new Button();
            dtpSatisTarihi = new DateTimePicker();
            btnAnaSayfa = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtRandevuID = new TextBox();
            txtMusteriıD = new TextBox();
            txtCalisanID = new TextBox();
            txthizmet = new TextBox();
            btnListele = new Button();
            tabPage2 = new TabPage();
            label15 = new Label();
            txtOdemeID = new TextBox();
            dtpRandevuTarihi_Odeme = new DateTimePicker();
            btnOdemeListele = new Button();
            btnOdemeGuncelle = new Button();
            btnOdemeSil = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnOdemeEkle = new Button();
            txtFiyat = new TextBox();
            txtMusteriID = new TextBox();
            dgvOdemeler = new DataGridView();
            tabPage3 = new TabPage();
            label16 = new Label();
            txtGelirID = new TextBox();
            dtpGelirTarihi = new DateTimePicker();
            btnGelirSil = new Button();
            btnGelirGuncelle = new Button();
            btnGelirListele = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dgvGelirler = new DataGridView();
            txtGelirTuru = new TextBox();
            txtMiktar = new TextBox();
            btnGelirEkle = new Button();
            tabPage4 = new TabPage();
            btnGiderEkle = new Button();
            txtGiderID = new TextBox();
            label17 = new Label();
            dtpGiderTarihi = new DateTimePicker();
            btnGiderListele = new Button();
            btnGiderSil = new Button();
            btnGiderGuncelle = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvGiderler = new DataGridView();
            txtMiktarr = new TextBox();
            txtGiderTürü = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGelirler).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiderler).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(102, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1441, 798);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources._3e13d79c25a0b8668bb7f2142f6906de;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(dgvSatislar);
            tabPage1.Controls.Add(btnSatisEkle);
            tabPage1.Controls.Add(btnSatisGuncelle);
            tabPage1.Controls.Add(btnSatisSil);
            tabPage1.Controls.Add(dtpSatisTarihi);
            tabPage1.Controls.Add(btnAnaSayfa);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtRandevuID);
            tabPage1.Controls.Add(txtMusteriıD);
            tabPage1.Controls.Add(txtCalisanID);
            tabPage1.Controls.Add(txthizmet);
            tabPage1.Controls.Add(btnListele);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1372, 772);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "satışlar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSatislar
            // 
            dgvSatislar.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSatislar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatislar.Location = new Point(6, 3);
            dgvSatislar.Name = "dgvSatislar";
            dgvSatislar.RowHeadersWidth = 51;
            dgvSatislar.Size = new Size(756, 766);
            dgvSatislar.TabIndex = 23;
            dgvSatislar.CellClick += dgvSatislar_CellClick;
            // 
            // btnSatisEkle
            // 
            btnSatisEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnSatisEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnSatisEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSatisEkle.Location = new Point(1071, 585);
            btnSatisEkle.Name = "btnSatisEkle";
            btnSatisEkle.Size = new Size(138, 53);
            btnSatisEkle.TabIndex = 22;
            btnSatisEkle.Text = "SATIŞ EKLE";
            btnSatisEkle.UseVisualStyleBackColor = true;
            btnSatisEkle.Click += btnEkle_Click;
            // 
            // btnSatisGuncelle
            // 
            btnSatisGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnSatisGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnSatisGuncelle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSatisGuncelle.Location = new Point(889, 585);
            btnSatisGuncelle.Name = "btnSatisGuncelle";
            btnSatisGuncelle.Size = new Size(132, 53);
            btnSatisGuncelle.TabIndex = 21;
            btnSatisGuncelle.Text = "SATIŞ GÜNCELLE";
            btnSatisGuncelle.UseVisualStyleBackColor = true;
            btnSatisGuncelle.Click += btnSatisGuncelle_Click;
            // 
            // btnSatisSil
            // 
            btnSatisSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnSatisSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSatisSil.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSatisSil.Location = new Point(889, 511);
            btnSatisSil.Name = "btnSatisSil";
            btnSatisSil.Size = new Size(132, 58);
            btnSatisSil.TabIndex = 20;
            btnSatisSil.Text = "SATIŞ SİL";
            btnSatisSil.UseVisualStyleBackColor = true;
            btnSatisSil.Click += btnSatisSil_Click;
            // 
            // dtpSatisTarihi
            // 
            dtpSatisTarihi.Location = new Point(1059, 74);
            dtpSatisTarihi.Name = "dtpSatisTarihi";
            dtpSatisTarihi.Size = new Size(280, 27);
            dtpSatisTarihi.TabIndex = 19;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnAnaSayfa.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnaSayfa.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnAnaSayfa.Location = new Point(1224, 687);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(142, 70);
            btnAnaSayfa.TabIndex = 1;
            btnAnaSayfa.Text = "ANASAYFA";
            btnAnaSayfa.UseVisualStyleBackColor = true;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(817, 77);
            label14.Name = "label14";
            label14.Size = new Size(214, 24);
            label14.TabIndex = 17;
            label14.Text = "RANDEVU TARİHİ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(823, 369);
            label13.Name = "label13";
            label13.Size = new Size(137, 24);
            label13.TabIndex = 16;
            label13.Text = "HİZMET ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(817, 300);
            label12.Name = "label12";
            label12.Size = new Size(145, 24);
            label12.TabIndex = 15;
            label12.Text = "ÇALIŞAN ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(817, 230);
            label11.Name = "label11";
            label11.Size = new Size(151, 24);
            label11.TabIndex = 14;
            label11.Text = "MÜŞTERİ ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(812, 160);
            label10.Name = "label10";
            label10.Size = new Size(159, 24);
            label10.TabIndex = 13;
            label10.Text = "RANDEVU ID:";
            // 
            // txtRandevuID
            // 
            txtRandevuID.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtRandevuID.Location = new Point(1059, 142);
            txtRandevuID.Multiline = true;
            txtRandevuID.Name = "txtRandevuID";
            txtRandevuID.Size = new Size(221, 38);
            txtRandevuID.TabIndex = 7;
            // 
            // txtMusteriıD
            // 
            txtMusteriıD.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtMusteriıD.Location = new Point(1059, 211);
            txtMusteriıD.Multiline = true;
            txtMusteriıD.Name = "txtMusteriıD";
            txtMusteriıD.Size = new Size(221, 39);
            txtMusteriıD.TabIndex = 8;
            // 
            // txtCalisanID
            // 
            txtCalisanID.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtCalisanID.Location = new Point(1059, 284);
            txtCalisanID.Multiline = true;
            txtCalisanID.Name = "txtCalisanID";
            txtCalisanID.Size = new Size(221, 36);
            txtCalisanID.TabIndex = 9;
            // 
            // txthizmet
            // 
            txthizmet.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txthizmet.Location = new Point(1059, 350);
            txthizmet.Multiline = true;
            txthizmet.Name = "txthizmet";
            txthizmet.Size = new Size(221, 39);
            txthizmet.TabIndex = 10;
            // 
            // btnListele
            // 
            btnListele.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnListele.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnListele.Location = new Point(1071, 511);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(138, 58);
            btnListele.TabIndex = 12;
            btnListele.Text = "SATIŞ LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnSatisEkle_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources._3e13d79c25a0b8668bb7f2142f6906de;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(txtOdemeID);
            tabPage2.Controls.Add(dtpRandevuTarihi_Odeme);
            tabPage2.Controls.Add(btnOdemeListele);
            tabPage2.Controls.Add(btnOdemeGuncelle);
            tabPage2.Controls.Add(btnOdemeSil);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnOdemeEkle);
            tabPage2.Controls.Add(txtFiyat);
            tabPage2.Controls.Add(txtMusteriID);
            tabPage2.Controls.Add(dgvOdemeler);
            tabPage2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1372, 772);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ödemeler";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(778, 267);
            label15.Name = "label15";
            label15.Size = new Size(129, 24);
            label15.TabIndex = 17;
            label15.Text = "ÖDEME ID:";
            // 
            // txtOdemeID
            // 
            txtOdemeID.Location = new Point(1016, 253);
            txtOdemeID.Multiline = true;
            txtOdemeID.Name = "txtOdemeID";
            txtOdemeID.Size = new Size(260, 38);
            txtOdemeID.TabIndex = 16;
            // 
            // dtpRandevuTarihi_Odeme
            // 
            dtpRandevuTarihi_Odeme.Location = new Point(1016, 95);
            dtpRandevuTarihi_Odeme.Name = "dtpRandevuTarihi_Odeme";
            dtpRandevuTarihi_Odeme.Size = new Size(250, 27);
            dtpRandevuTarihi_Odeme.TabIndex = 15;
            // 
            // btnOdemeListele
            // 
            btnOdemeListele.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnOdemeListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnOdemeListele.Location = new Point(1077, 583);
            btnOdemeListele.Name = "btnOdemeListele";
            btnOdemeListele.Size = new Size(157, 56);
            btnOdemeListele.TabIndex = 14;
            btnOdemeListele.Text = "ÖDEME LİSTELE";
            btnOdemeListele.UseVisualStyleBackColor = true;
            btnOdemeListele.Click += btnOdemeListele_Click;
            // 
            // btnOdemeGuncelle
            // 
            btnOdemeGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnOdemeGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnOdemeGuncelle.Location = new Point(832, 583);
            btnOdemeGuncelle.Name = "btnOdemeGuncelle";
            btnOdemeGuncelle.Size = new Size(156, 56);
            btnOdemeGuncelle.TabIndex = 13;
            btnOdemeGuncelle.Text = "ÖDEME GÜNCELLE";
            btnOdemeGuncelle.UseVisualStyleBackColor = true;
            btnOdemeGuncelle.Click += btnOdemeGuncelle_Click;
            // 
            // btnOdemeSil
            // 
            btnOdemeSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnOdemeSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnOdemeSil.Location = new Point(832, 484);
            btnOdemeSil.Name = "btnOdemeSil";
            btnOdemeSil.Size = new Size(156, 60);
            btnOdemeSil.TabIndex = 12;
            btnOdemeSil.Text = "ÖDEME SİL";
            btnOdemeSil.UseVisualStyleBackColor = true;
            btnOdemeSil.Click += btnOdemeSil_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(778, 98);
            label9.Name = "label9";
            label9.Size = new Size(214, 24);
            label9.TabIndex = 11;
            label9.Text = "RANDEVU TARİHİ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(778, 357);
            label8.Name = "label8";
            label8.Size = new Size(83, 24);
            label8.TabIndex = 10;
            label8.Text = "FİYAT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(778, 182);
            label7.Name = "label7";
            label7.Size = new Size(151, 24);
            label7.TabIndex = 9;
            label7.Text = "MÜŞTERİ ID:";
            // 
            // btnOdemeEkle
            // 
            btnOdemeEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnOdemeEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnOdemeEkle.Location = new Point(1077, 484);
            btnOdemeEkle.Name = "btnOdemeEkle";
            btnOdemeEkle.Size = new Size(157, 60);
            btnOdemeEkle.TabIndex = 2;
            btnOdemeEkle.Text = "ÖDEME EKLE";
            btnOdemeEkle.UseVisualStyleBackColor = true;
            btnOdemeEkle.Click += btnOdemeEkle_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(1016, 342);
            txtFiyat.Multiline = true;
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(260, 39);
            txtFiyat.TabIndex = 4;
            // 
            // txtMusteriID
            // 
            txtMusteriID.Location = new Point(1016, 168);
            txtMusteriID.Multiline = true;
            txtMusteriID.Name = "txtMusteriID";
            txtMusteriID.Size = new Size(260, 38);
            txtMusteriID.TabIndex = 3;
            // 
            // dgvOdemeler
            // 
            dgvOdemeler.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOdemeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdemeler.Location = new Point(6, 3);
            dgvOdemeler.Name = "dgvOdemeler";
            dgvOdemeler.RowHeadersWidth = 51;
            dgvOdemeler.Size = new Size(700, 773);
            dgvOdemeler.TabIndex = 1;
            dgvOdemeler.CellClick += dgvOdemeler_CellClick;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources._3e13d79c25a0b8668bb7f2142f6906de;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(txtGelirID);
            tabPage3.Controls.Add(dtpGelirTarihi);
            tabPage3.Controls.Add(btnGelirSil);
            tabPage3.Controls.Add(btnGelirGuncelle);
            tabPage3.Controls.Add(btnGelirListele);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dgvGelirler);
            tabPage3.Controls.Add(txtGelirTuru);
            tabPage3.Controls.Add(txtMiktar);
            tabPage3.Controls.Add(btnGelirEkle);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1372, 772);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "gelirler";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(772, 144);
            label16.Name = "label16";
            label16.Size = new Size(117, 24);
            label16.TabIndex = 26;
            label16.Text = "GELİR ID:";
            // 
            // txtGelirID
            // 
            txtGelirID.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtGelirID.Location = new Point(981, 134);
            txtGelirID.Multiline = true;
            txtGelirID.Name = "txtGelirID";
            txtGelirID.Size = new Size(250, 37);
            txtGelirID.TabIndex = 25;
            // 
            // dtpGelirTarihi
            // 
            dtpGelirTarihi.CalendarFont = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            dtpGelirTarihi.Location = new Point(981, 58);
            dtpGelirTarihi.Name = "dtpGelirTarihi";
            dtpGelirTarihi.Size = new Size(250, 27);
            dtpGelirTarihi.TabIndex = 24;
            // 
            // btnGelirSil
            // 
            btnGelirSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGelirSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnGelirSil.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGelirSil.Location = new Point(1071, 590);
            btnGelirSil.Name = "btnGelirSil";
            btnGelirSil.Size = new Size(160, 55);
            btnGelirSil.TabIndex = 23;
            btnGelirSil.Text = "GELİR SİL";
            btnGelirSil.UseVisualStyleBackColor = true;
            btnGelirSil.Click += btnGelirSil_Click;
            // 
            // btnGelirGuncelle
            // 
            btnGelirGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGelirGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGelirGuncelle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGelirGuncelle.Location = new Point(821, 471);
            btnGelirGuncelle.Name = "btnGelirGuncelle";
            btnGelirGuncelle.Size = new Size(160, 55);
            btnGelirGuncelle.TabIndex = 22;
            btnGelirGuncelle.Text = "GELİR GÜNCELLE";
            btnGelirGuncelle.UseVisualStyleBackColor = true;
            btnGelirGuncelle.Click += btnGelirGuncelle_Click;
            // 
            // btnGelirListele
            // 
            btnGelirListele.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGelirListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnGelirListele.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGelirListele.Location = new Point(821, 590);
            btnGelirListele.Name = "btnGelirListele";
            btnGelirListele.Size = new Size(160, 55);
            btnGelirListele.TabIndex = 21;
            btnGelirListele.Text = "GELİR LİSTELE";
            btnGelirListele.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(772, 63);
            label6.Name = "label6";
            label6.Size = new Size(172, 24);
            label6.TabIndex = 20;
            label6.Text = "GELİR TARİHİ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(781, 328);
            label5.Name = "label5";
            label5.Size = new Size(107, 24);
            label5.TabIndex = 19;
            label5.Text = "MİKTAR:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(772, 236);
            label4.Name = "label4";
            label4.Size = new Size(155, 24);
            label4.TabIndex = 18;
            label4.Text = "GELİR TÜRÜ:";
            label4.Click += label4_Click;
            // 
            // dgvGelirler
            // 
            dgvGelirler.BackgroundColor = SystemColors.ButtonHighlight;
            dgvGelirler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelirler.Location = new Point(3, 6);
            dgvGelirler.Name = "dgvGelirler";
            dgvGelirler.RowHeadersWidth = 51;
            dgvGelirler.Size = new Size(723, 770);
            dgvGelirler.TabIndex = 14;
            dgvGelirler.CellClick += dgvGelirler_CellClick;
            dgvGelirler.CellContentClick += dgvGelirler_CellContentClick;
            // 
            // txtGelirTuru
            // 
            txtGelirTuru.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtGelirTuru.Location = new Point(981, 215);
            txtGelirTuru.Multiline = true;
            txtGelirTuru.Name = "txtGelirTuru";
            txtGelirTuru.Size = new Size(250, 41);
            txtGelirTuru.TabIndex = 15;
            txtGelirTuru.TextChanged += txtGelirTuru_TextChanged;
            // 
            // txtMiktar
            // 
            txtMiktar.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtMiktar.Location = new Point(981, 305);
            txtMiktar.Multiline = true;
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(250, 43);
            txtMiktar.TabIndex = 16;
            // 
            // btnGelirEkle
            // 
            btnGelirEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGelirEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGelirEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGelirEkle.Location = new Point(1071, 471);
            btnGelirEkle.Name = "btnGelirEkle";
            btnGelirEkle.Size = new Size(160, 55);
            btnGelirEkle.TabIndex = 13;
            btnGelirEkle.Text = "GELİR EKLE";
            btnGelirEkle.UseVisualStyleBackColor = true;
            btnGelirEkle.Click += btnGelirEkle_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources._3e13d79c25a0b8668bb7f2142f6906de;
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(btnGiderEkle);
            tabPage4.Controls.Add(txtGiderID);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(dtpGiderTarihi);
            tabPage4.Controls.Add(btnGiderListele);
            tabPage4.Controls.Add(btnGiderSil);
            tabPage4.Controls.Add(btnGiderGuncelle);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(dgvGiderler);
            tabPage4.Controls.Add(txtMiktarr);
            tabPage4.Controls.Add(txtGiderTürü);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1433, 765);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "giderler";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGiderEkle
            // 
            btnGiderEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGiderEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiderEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGiderEkle.Location = new Point(1096, 500);
            btnGiderEkle.Name = "btnGiderEkle";
            btnGiderEkle.Size = new Size(160, 55);
            btnGiderEkle.TabIndex = 33;
            btnGiderEkle.Text = "GİDER EKLE";
            btnGiderEkle.UseVisualStyleBackColor = true;
            btnGiderEkle.Click += btnGiderEkle_Click;
            // 
            // txtGiderID
            // 
            txtGiderID.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtGiderID.Location = new Point(998, 179);
            txtGiderID.Multiline = true;
            txtGiderID.Name = "txtGiderID";
            txtGiderID.Size = new Size(258, 38);
            txtGiderID.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.Location = new Point(776, 197);
            label17.Name = "label17";
            label17.Size = new Size(120, 24);
            label17.TabIndex = 30;
            label17.Text = "GİDER ID:";
            // 
            // dtpGiderTarihi
            // 
            dtpGiderTarihi.CalendarFont = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtpGiderTarihi.Location = new Point(998, 123);
            dtpGiderTarihi.Name = "dtpGiderTarihi";
            dtpGiderTarihi.Size = new Size(258, 27);
            dtpGiderTarihi.TabIndex = 29;
            // 
            // btnGiderListele
            // 
            btnGiderListele.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGiderListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiderListele.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGiderListele.Location = new Point(1096, 602);
            btnGiderListele.Name = "btnGiderListele";
            btnGiderListele.Size = new Size(160, 55);
            btnGiderListele.TabIndex = 28;
            btnGiderListele.Text = "GİDER LİSTELE";
            btnGiderListele.UseVisualStyleBackColor = true;
            // 
            // btnGiderSil
            // 
            btnGiderSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGiderSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiderSil.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGiderSil.Location = new Point(840, 602);
            btnGiderSil.Name = "btnGiderSil";
            btnGiderSil.Size = new Size(160, 55);
            btnGiderSil.TabIndex = 27;
            btnGiderSil.Text = "GİDER SİL";
            btnGiderSil.UseVisualStyleBackColor = true;
            btnGiderSil.Click += btnGiderSil_Click;
            // 
            // btnGiderGuncelle
            // 
            btnGiderGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGiderGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiderGuncelle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGiderGuncelle.Location = new Point(840, 500);
            btnGiderGuncelle.Name = "btnGiderGuncelle";
            btnGiderGuncelle.Size = new Size(160, 55);
            btnGiderGuncelle.TabIndex = 26;
            btnGiderGuncelle.Text = "GİDER GÜNCELLE";
            btnGiderGuncelle.UseVisualStyleBackColor = true;
            btnGiderGuncelle.Click += btnGiderGuncelle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(776, 128);
            label3.Name = "label3";
            label3.Size = new Size(175, 24);
            label3.TabIndex = 25;
            label3.Text = "GİDER TARİHİ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(789, 356);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 24;
            label2.Text = "MİKTAR:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(776, 276);
            label1.Name = "label1";
            label1.Size = new Size(158, 24);
            label1.TabIndex = 23;
            label1.Text = "GİDER TÜRÜ:";
            // 
            // dgvGiderler
            // 
            dgvGiderler.BackgroundColor = SystemColors.ButtonHighlight;
            dgvGiderler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiderler.Location = new Point(6, 0);
            dgvGiderler.Name = "dgvGiderler";
            dgvGiderler.RowHeadersWidth = 51;
            dgvGiderler.Size = new Size(699, 776);
            dgvGiderler.TabIndex = 22;
            dgvGiderler.CellClick += dgvGiderler_CellClick;
            // 
            // txtMiktarr
            // 
            txtMiktarr.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtMiktarr.Location = new Point(998, 341);
            txtMiktarr.Multiline = true;
            txtMiktarr.Name = "txtMiktarr";
            txtMiktarr.Size = new Size(258, 39);
            txtMiktarr.TabIndex = 20;
            // 
            // txtGiderTürü
            // 
            txtGiderTürü.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtGiderTürü.Location = new Point(998, 262);
            txtGiderTürü.Multiline = true;
            txtGiderTürü.Name = "txtGiderTürü";
            txtGiderTürü.Size = new Size(258, 38);
            txtGiderTürü.TabIndex = 19;
            txtGiderTürü.TextChanged += txtGiderTürü_TextChanged;
            // 
            // finansalişlemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arka_plan_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1696, 889);
            Controls.Add(tabControl1);
            Name = "finansalişlemler";
            Text = "Form7";
            Load += Form7_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGelirler).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiderler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvOdemeler;
        private Button btnOdemeEkle;
        private TextBox txtMusteriID;
        private TextBox txtFiyat;
        private TextBox txtRandevuID;
        private TextBox txtMusteriıD;
        private TextBox txtCalisanID;
        private TextBox txthizmet;
        private Button btnListele;
        private Button btnGelirEkle;
        private DataGridView dgvGelirler;
        private TextBox txtGelirTuru;
        private TextBox txtMiktar;
        private TextBox txtGiderTürü;
        private TextBox txtMiktarr;
        private DataGridView dgvGiderler;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnAnaSayfa;
        private Button btnSatisEkle;
        private Button btnSatisGuncelle;
        private Button btnSatisSil;
        private DateTimePicker dtpSatisTarihi;
        private Button btnOdemeListele;
        private Button btnOdemeGuncelle;
        private Button btnOdemeSil;
        private Button btnGelirSil;
        private Button btnGelirGuncelle;
        private Button btnGelirListele;
        private Button btnGiderListele;
        private Button btnGiderSil;
        private Button btnGiderGuncelle;
        private DataGridView dgvSatislar;
        private DateTimePicker dtpRandevuTarihi_Odeme;
        private Label label15;
        private TextBox txtOdemeID;
        private Label label16;
        private TextBox txtGelirID;
        private DateTimePicker dtpGelirTarihi;
        private DateTimePicker dtpGiderTarihi;
        private TextBox txtGiderID;
        private Label label17;
        private Button btnGiderEkle;
    }
}