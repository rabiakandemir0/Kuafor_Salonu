using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuafor_Salonu;

namespace Kuafor_Salonu
{
    public partial class anasayfa : Form
    {
        private anasayfa anaForm;
        public anasayfa(anasayfa gelenAnaForm)
        {
            InitializeComponent();
            anaForm = gelenAnaForm; // Form2'yi saklıyoruz
        }
        
        public anasayfa()
        {
            InitializeComponent();
          
        }


        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            musteriler musteriForm = new musteriler(); // yeni müşteriler formu oluştur
            musteriForm.Show();                        // müşteriler formunu aç
            this.Hide();
        }                             //

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            Randevular musteriForm = new Randevular(this); // ← this = şu anki Form2’yi gönderiyoruz
            musteriForm.Show();
            this.Hide(); // Ana menüyü gizle
        }

        private void btnHizmetler_Click(object sender, EventArgs e)
        {
            Hizmetler musteriForm = new Hizmetler(this); // ← this = şu anki Form2’yi gönderiyoruz
            musteriForm.Show();
            this.Hide(); // Ana menüyü gizle
        }

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            Çalışanlar musteriForm = new Çalışanlar(this); // ← this = şu anki Form2’yi gönderiyoruz
            musteriForm.Show();
            this.Hide(); // Ana menüyü gizle
        }

        private void btnFinansalIslemler_Click(object sender, EventArgs e)
        {
            // Form3'ü açarken, Form2'yi parametre olarak geçiyoruz
            finansalişlemler finansalişlemler = new finansalişlemler(this); // this, yani Form2'yi parametre olarak gönderiyoruz
            finansalişlemler.Show();
            this.Hide();  // Form2'yi gizliyoruz

        }
    }
}