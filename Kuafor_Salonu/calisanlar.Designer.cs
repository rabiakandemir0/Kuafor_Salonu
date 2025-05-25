namespace Kuafor_Salonu
{
    partial class Çalışanlar
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtPozisyon = new TextBox();
            txtTelefon = new TextBox();
            dgvCalisanlar = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAnaSayfa = new Button();
            button1 = new Button();
            txtID = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnEkle.Location = new Point(815, 561);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(119, 57);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGuncelle.Location = new Point(1428, 559);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(119, 57);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSil.Location = new Point(1020, 562);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 54);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtAd.Location = new Point(1056, 128);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(279, 38);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtSoyad.Location = new Point(1056, 203);
            txtSoyad.Multiline = true;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(279, 37);
            txtSoyad.TabIndex = 4;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtPozisyon.Location = new Point(1056, 276);
            txtPozisyon.Multiline = true;
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(279, 39);
            txtPozisyon.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtTelefon.Location = new Point(1056, 351);
            txtTelefon.Multiline = true;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(279, 40);
            txtTelefon.TabIndex = 6;
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(12, 12);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.RowHeadersWidth = 51;
            dgvCalisanlar.Size = new Size(707, 865);
            dgvCalisanlar.TabIndex = 7;
            dgvCalisanlar.CellClick += dgvCalisanlar_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(789, 145);
            label1.Name = "label1";
            label1.Size = new Size(49, 24);
            label1.TabIndex = 8;
            label1.Text = "AD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(789, 220);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 9;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(789, 295);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 10;
            label3.Text = "POSİZYON:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(789, 371);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 11;
            label4.Text = "TELEFON NO:";
            label4.Click += label4_Click;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnAnaSayfa.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnaSayfa.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnAnaSayfa.Location = new Point(1490, 775);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(204, 92);
            btnAnaSayfa.TabIndex = 12;
            btnAnaSayfa.Text = "ANASAYFA";
            btnAnaSayfa.UseVisualStyleBackColor = true;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1229, 562);
            button1.Name = "button1";
            button1.Size = new Size(119, 54);
            button1.TabIndex = 13;
            button1.Text = "LİSTELE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(1056, 55);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(279, 36);
            txtID.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(789, 71);
            label5.Name = "label5";
            label5.Size = new Size(145, 24);
            label5.TabIndex = 15;
            label5.Text = "ÇALIŞAN ID:";
            // 
            // Çalışanlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arka_plan_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1706, 889);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(button1);
            Controls.Add(btnAnaSayfa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCalisanlar);
            Controls.Add(txtTelefon);
            Controls.Add(txtPozisyon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Name = "Çalışanlar";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtPozisyon;
        private TextBox txtTelefon;
        private DataGridView dgvCalisanlar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAnaSayfa;
        private Button button1;
        private TextBox txtID;
        private Label label5;
    }
}