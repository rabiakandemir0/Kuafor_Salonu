namespace Kuafor_Salonu
{
    partial class Randevular
    {
        private const bool V = true;

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
            dgvRandevular = new DataGridView();
            cmbCalisan = new ComboBox();
            cmbHizmet = new ComboBox();
            dtpRandevuTarihi = new DateTimePicker();
            cmbDurum = new ComboBox();
            btnRandevuEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAnaSayfa = new Button();
            RandevulSil = new Button();
            RandevuGuncelle = new Button();
            txtRandevuId = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).BeginInit();
            SuspendLayout();
            // 
            // dgvRandevular
            // 
            dgvRandevular.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRandevular.Location = new Point(12, 12);
            dgvRandevular.Name = "dgvRandevular";
            dgvRandevular.RowHeadersWidth = 51;
            dgvRandevular.Size = new Size(774, 847);
            dgvRandevular.TabIndex = 0;
            // 
            // cmbCalisan
            // 
            cmbCalisan.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            cmbCalisan.FormattingEnabled = true;
            cmbCalisan.Location = new Point(1189, 94);
            cmbCalisan.Name = "cmbCalisan";
            cmbCalisan.Size = new Size(341, 28);
            cmbCalisan.TabIndex = 1;
            // 
            // cmbHizmet
            // 
            cmbHizmet.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            cmbHizmet.FormattingEnabled = true;
            cmbHizmet.Location = new Point(1189, 175);
            cmbHizmet.Name = "cmbHizmet";
            cmbHizmet.Size = new Size(341, 28);
            cmbHizmet.TabIndex = 2;
            // 
            // dtpRandevuTarihi
            // 
            dtpRandevuTarihi.CalendarForeColor = Color.Black;
            dtpRandevuTarihi.CalendarMonthBackground = Color.Transparent;
            dtpRandevuTarihi.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            dtpRandevuTarihi.Location = new Point(913, 22);
            dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            dtpRandevuTarihi.Size = new Size(464, 27);
            dtpRandevuTarihi.TabIndex = 3;
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(1189, 251);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(341, 28);
            cmbDurum.TabIndex = 4;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // btnRandevuEkle
            // 
            btnRandevuEkle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnRandevuEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnRandevuEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnRandevuEkle.Location = new Point(1364, 473);
            btnRandevuEkle.Name = "btnRandevuEkle";
            btnRandevuEkle.Size = new Size(152, 53);
            btnRandevuEkle.TabIndex = 5;
            btnRandevuEkle.Text = "RANDEVU EKLE";
            btnRandevuEkle.UseVisualStyleBackColor = true;
            btnRandevuEkle.Click += btnRandevuEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(825, 98);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 9;
            label1.Text = "ÇALIŞAN ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(824, 179);
            label2.Name = "label2";
            label2.Size = new Size(152, 24);
            label2.TabIndex = 10;
            label2.Text = "HİZMET ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(824, 255);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 11;
            label3.Text = "DURUM:";
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnAnaSayfa.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnaSayfa.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnAnaSayfa.Location = new Point(1476, 764);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(204, 95);
            btnAnaSayfa.TabIndex = 12;
            btnAnaSayfa.Text = "ANASAYFA";
            btnAnaSayfa.UseVisualStyleBackColor = true;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // RandevulSil
            // 
            RandevulSil.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            RandevulSil.BackgroundImageLayout = ImageLayout.Stretch;
            RandevulSil.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            RandevulSil.ImageAlign = ContentAlignment.BottomCenter;
            RandevulSil.Location = new Point(1042, 473);
            RandevulSil.Name = "RandevulSil";
            RandevulSil.Size = new Size(140, 53);
            RandevulSil.TabIndex = 13;
            RandevulSil.Text = "RANDEVU SİL";
            RandevulSil.Click += RandevularıYukle_Click;
            // 
            // RandevuGuncelle
            // 
            RandevuGuncelle.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            RandevuGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            RandevuGuncelle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            RandevuGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            RandevuGuncelle.Location = new Point(1205, 594);
            RandevuGuncelle.Name = "RandevuGuncelle";
            RandevuGuncelle.Size = new Size(153, 56);
            RandevuGuncelle.TabIndex = 14;
            RandevuGuncelle.Text = "RANDEVU GÜNCELLE";
            RandevuGuncelle.UseVisualStyleBackColor = true;
            RandevuGuncelle.Click += RandevuGuncelle_Click;
            // 
            // txtRandevuId
            // 
            txtRandevuId.Location = new Point(1189, 318);
            txtRandevuId.Multiline = true;
            txtRandevuId.Name = "txtRandevuId";
            txtRandevuId.Size = new Size(341, 27);
            txtRandevuId.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(825, 318);
            label4.Name = "label4";
            label4.Size = new Size(159, 24);
            label4.TabIndex = 16;
            label4.Text = "RANDEVU ID:";
            // 
            // Randevular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arka_plan_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1706, 887);
            Controls.Add(label4);
            Controls.Add(txtRandevuId);
            Controls.Add(RandevuGuncelle);
            Controls.Add(RandevulSil);
            Controls.Add(btnAnaSayfa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRandevuEkle);
            Controls.Add(cmbDurum);
            Controls.Add(dtpRandevuTarihi);
            Controls.Add(cmbHizmet);
            Controls.Add(cmbCalisan);
            Controls.Add(dgvRandevular);
            Name = "Randevular";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRandevular;
        private ComboBox cmbCalisan;
        private ComboBox cmbHizmet;
        private DateTimePicker dtpRandevuTarihi;
        private ComboBox cmbDurum;
        private Button btnRandevuEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAnaSayfa;
        private Button RandevulSil;
        private Button RandevuGuncelle;
        private TextBox txtRandevuId;
        private Label label4;
    }
}