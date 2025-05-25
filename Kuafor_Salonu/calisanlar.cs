using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kuafor_Salonu
{
    public partial class Çalışanlar : Form
    {
        private anasayfa anaForm;

        SqlConnection baglanti = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;");
        public Çalışanlar(anasayfa gelenAnaForm)
        {
            InitializeComponent();
            anaForm = gelenAnaForm;
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM calisanlarr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCalisanlar.DataSource = dt;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void CalisanlariListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM calisanlarr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCalisanlar.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO calisanlarr (ad, soyad, telefon_no, pozisyon) VALUES (@ad, @soyad, @telefon, @pozisyon)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@pozisyon", txtPozisyon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void dgvCalisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvCalisanlar.SelectedCells[0].RowIndex;
            txtID.Text = dgvCalisanlar.Rows[secilen].Cells["calisan_id"].Value.ToString();
            txtAd.Text = dgvCalisanlar.Rows[secilen].Cells["ad"].Value.ToString();
            txtSoyad.Text = dgvCalisanlar.Rows[secilen].Cells["soyad"].Value.ToString();
            txtTelefon.Text = dgvCalisanlar.Rows[secilen].Cells["telefon_no"].Value.ToString();
            txtPozisyon.Text = dgvCalisanlar.Rows[secilen].Cells["pozisyon"].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("txtID içeriği: " + txtID.Text);  // Test için

            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE calisanlarr SET ad=@ad, soyad=@soyad, telefon_no=@telefon, pozisyon=@pozisyon WHERE calisan_id=@id", baglanti);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@pozisyon", txtPozisyon.Text);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Çalışan güncellendi.");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Güncelleme yapılamadı, ID bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen çalışan seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM calisanlarr WHERE calisan_id=@id", baglanti);
                komut.Parameters.AddWithValue("@id", txtID.Text);
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt silindi.");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir çalışan seçin.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa(); // yeni anasayfa formu oluştur
            ana.Show();                    // anasayfa formunu aç
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }


}
