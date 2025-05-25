namespace Kuafor_Salonu
{
    partial class musteriler
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
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            dtpKayitTarihi = new DateTimePicker();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnEkle.Location = new Point(1016, 552);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(127, 55);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGuncelle.Location = new Point(810, 552);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(121, 55);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.TabStop = false;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSil.Location = new Point(1450, 552);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(131, 55);
            btnSil.TabIndex = 3;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnListele.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnListele.Location = new Point(1235, 552);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(131, 55);
            btnListele.TabIndex = 4;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtAd.Location = new Point(1016, 112);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(293, 37);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtSoyad.Location = new Point(1016, 183);
            txtSoyad.Multiline = true;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(293, 38);
            txtSoyad.TabIndex = 6;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtTelefon.Location = new Point(1016, 259);
            txtTelefon.Multiline = true;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(293, 41);
            txtTelefon.TabIndex = 7;
            // 
            // dtpKayitTarihi
            // 
            dtpKayitTarihi.CalendarMonthBackground = Color.Transparent;
            dtpKayitTarihi.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            dtpKayitTarihi.Location = new Point(821, 22);
            dtpKayitTarihi.Name = "dtpKayitTarihi";
            dtpKayitTarihi.Size = new Size(333, 28);
            dtpKayitTarihi.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtID.Location = new Point(1016, 331);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(293, 40);
            txtID.TabIndex = 9;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(654, 839);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(749, 125);
            label1.Name = "label1";
            label1.Size = new Size(49, 24);
            label1.TabIndex = 11;
            label1.Text = "AD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(743, 197);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 12;
            label2.Text = "SOYAD:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(743, 276);
            label3.Name = "label3";
            label3.Size = new Size(157, 24);
            label3.TabIndex = 13;
            label3.Text = "TELEFON NO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(749, 347);
            label4.Name = "label4";
            label4.Size = new Size(151, 24);
            label4.TabIndex = 14;
            label4.Text = "MÜŞTERİ İD:";
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            button1.Location = new Point(1474, 782);
            button1.Name = "button1";
            button1.Size = new Size(191, 90);
            button1.TabIndex = 15;
            button1.Text = "ANASAYFA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // musteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arka_plan_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1689, 884);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtID);
            Controls.Add(dtpKayitTarihi);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Name = "musteriler";
            Text = "musteriler";
            Load += musteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private DateTimePicker dtpKayitTarihi;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}