namespace Kuafor_Salonu
{
    partial class Hizmetler
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
            txtHizmetAdi = new TextBox();
            txtFiyat = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAnaSayfa = new Button();
            txtID = new TextBox();
            label3 = new Label();
            btnListele = new Button();
            dgvHizmetler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHizmetler).BeginInit();
            SuspendLayout();
            // 
            // txtHizmetAdi
            // 
            txtHizmetAdi.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtHizmetAdi.Location = new Point(1115, 200);
            txtHizmetAdi.Multiline = true;
            txtHizmetAdi.Name = "txtHizmetAdi";
            txtHizmetAdi.Size = new Size(326, 52);
            txtHizmetAdi.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtFiyat.Location = new Point(1115, 296);
            txtFiyat.Multiline = true;
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(326, 52);
            txtFiyat.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnEkle.Location = new Point(793, 467);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(152, 70);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnGuncelle.Location = new Point(1017, 467);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(163, 70);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Transparent;
            btnSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSil.Location = new Point(1244, 467);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(160, 70);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(904, 228);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 9;
            label1.Text = "HİZMET ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(914, 324);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 10;
            label2.Text = "FİYAT:";
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnAnaSayfa.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnaSayfa.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnAnaSayfa.Location = new Point(1455, 755);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(233, 94);
            btnAnaSayfa.TabIndex = 11;
            btnAnaSayfa.Text = "ANASAYFA";
            btnAnaSayfa.UseVisualStyleBackColor = true;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(1110, 101);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(331, 56);
            txtID.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(904, 133);
            label3.Name = "label3";
            label3.Size = new Size(137, 24);
            label3.TabIndex = 13;
            label3.Text = "HİZMET İD:";
            // 
            // btnListele
            // 
            btnListele.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnListele.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnListele.Location = new Point(1455, 467);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(166, 70);
            btnListele.TabIndex = 14;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // dgvHizmetler
            // 
            dgvHizmetler.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHizmetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHizmetler.Location = new Point(12, 12);
            dgvHizmetler.Name = "dgvHizmetler";
            dgvHizmetler.RowHeadersWidth = 51;
            dgvHizmetler.Size = new Size(733, 837);
            dgvHizmetler.TabIndex = 15;
            dgvHizmetler.CellClick += dgvHizmetler_CellClick;
            // 
            // Hizmetler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arka_plan_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1700, 876);
            Controls.Add(dgvHizmetler);
            Controls.Add(btnListele);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(btnAnaSayfa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtFiyat);
            Controls.Add(txtHizmetAdi);
            Name = "Hizmetler";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHizmetler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHizmetAdi;
        private TextBox txtFiyat;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label1;
        private Label label2;
        private Button btnAnaSayfa;
        private TextBox txtID;
        private Label label3;
        private Button btnListele;
        private DataGridView dgvHizmetler;
    }
}