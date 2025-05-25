namespace Kuafor_Salonu
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            btnMusteriler = new Button();
            btnRandevular = new Button();
            btnHizmetler = new Button();
            btnCalisanlar = new Button();
            btnFinansalIslemler = new Button();
            SuspendLayout();
            // 
            // btnMusteriler
            // 
            btnMusteriler.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnMusteriler.BackgroundImageLayout = ImageLayout.Stretch;
            btnMusteriler.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMusteriler.Location = new Point(287, 92);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(358, 230);
            btnMusteriler.TabIndex = 0;
            btnMusteriler.Text = "MÜŞTERİLER";
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // btnRandevular
            // 
            btnRandevular.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnRandevular.BackgroundImageLayout = ImageLayout.Stretch;
            btnRandevular.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRandevular.Location = new Point(287, 460);
            btnRandevular.Name = "btnRandevular";
            btnRandevular.Size = new Size(367, 245);
            btnRandevular.TabIndex = 1;
            btnRandevular.Text = "RANDEVULAR";
            btnRandevular.UseVisualStyleBackColor = true;
            btnRandevular.Click += btnRandevular_Click;
            // 
            // btnHizmetler
            // 
            btnHizmetler.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnHizmetler.BackgroundImageLayout = ImageLayout.Stretch;
            btnHizmetler.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHizmetler.Location = new Point(1118, 92);
            btnHizmetler.Name = "btnHizmetler";
            btnHizmetler.Size = new Size(342, 230);
            btnHizmetler.TabIndex = 2;
            btnHizmetler.Text = "HİZMETLER";
            btnHizmetler.UseVisualStyleBackColor = true;
            btnHizmetler.Click += btnHizmetler_Click;
            // 
            // btnCalisanlar
            // 
            btnCalisanlar.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnCalisanlar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalisanlar.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCalisanlar.Location = new Point(1094, 460);
            btnCalisanlar.Name = "btnCalisanlar";
            btnCalisanlar.Size = new Size(366, 255);
            btnCalisanlar.TabIndex = 3;
            btnCalisanlar.Text = "ÇALIŞANLAR";
            btnCalisanlar.UseVisualStyleBackColor = true;
            btnCalisanlar.Click += btnCalisanlar_Click;
            // 
            // btnFinansalIslemler
            // 
            btnFinansalIslemler.BackgroundImage = Properties.Resources._7fef84796d411b2c69e33fc3869898a2;
            btnFinansalIslemler.BackgroundImageLayout = ImageLayout.Stretch;
            btnFinansalIslemler.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFinansalIslemler.Location = new Point(732, 320);
            btnFinansalIslemler.Name = "btnFinansalIslemler";
            btnFinansalIslemler.Size = new Size(293, 175);
            btnFinansalIslemler.TabIndex = 4;
            btnFinansalIslemler.Text = "FİNANSAL İŞLEMLER";
            btnFinansalIslemler.UseVisualStyleBackColor = true;
            btnFinansalIslemler.Click += btnFinansalIslemler_Click;
            // 
            // anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1706, 858);
            Controls.Add(btnFinansalIslemler);
            Controls.Add(btnCalisanlar);
            Controls.Add(btnHizmetler);
            Controls.Add(btnRandevular);
            Controls.Add(btnMusteriler);
            Name = "anasayfa";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMusteriler;
        private Button btnRandevular;
        private Button btnHizmetler;
        private Button btnCalisanlar;
        private Button btnFinansalIslemler;
    }
}