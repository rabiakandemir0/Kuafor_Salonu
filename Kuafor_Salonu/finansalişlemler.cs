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
    public partial class finansalişlemler : Form

    {
        private anasayfa anaForm;  // Ana formu burada saklayacağız
        SqlConnection baglanti = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;");



        public finansalişlemler(anasayfa gelenAnaForm)
        {
            InitializeComponent();
            anaForm = gelenAnaForm;

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            OdemeleriListele();
            SatislariListele();
            GelirleriListele();
            GiderleriListele();
        }

        // Ödemeleri listeleme
        void OdemeleriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Odemelerr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOdemeler.DataSource = dt;
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMusteriID.Text, out int musteriID))
            {
                MessageBox.Show("Müşteri ID sayısal olmalıdır!");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Fiyat geçerli bir sayı olmalıdır!");
                return;
            }

            DateTime tarih = dtpRandevuTarihi_Odeme.Value;

            SqlConnection baglanti = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO Odemelerr (müşteri_id, fiyat, randevu_tarihi) VALUES (@musteri, @fiyat, @tarih)", baglanti);
            komut.Parameters.AddWithValue("@musteri", musteriID);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.Parameters.AddWithValue("@tarih", tarih);

            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();

            if (sonuc > 0)
            {
                MessageBox.Show("Ödeme başarıyla eklendi.");
                OdemeleriListele();  // Listeyi yenile
            }
            else
            {
                MessageBox.Show("Ekleme başarısız.");
            }
        }
        // Satışları listeleme
        void SatislariListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Satislarr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSatislar.DataSource = dt;
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Satislarr (randevu_id, müşteri_id, çalışan_id, hizmet_id, satis_tarihi) VALUES (@r1, @r2, @r3, @r4, @r5)", baglanti);
            komut.Parameters.AddWithValue("@r1", txtRandevuID.Text);
            komut.Parameters.AddWithValue("@r2", txtMusteriID.Text);
            komut.Parameters.AddWithValue("@r3", txtCalisanID.Text);
            komut.Parameters.AddWithValue("@r4", txthizmet.Text);
            komut.Parameters.AddWithValue("@r5", dtpSatisTarihi.Value.Date);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SatislariListele();
        }


        // Gelirleri listeleme
        void GelirleriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Gelirlerr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGelirler.DataSource = dt;
        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Gelirlerr (gelir_turu, miktar, gelir_tarihi) VALUES (@tur, @miktar, @tarih)", baglanti);
            komut.Parameters.AddWithValue("@tur", txtGelirTuru.Text);
            komut.Parameters.AddWithValue("@miktar", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@tarih", dtpGelirTarihi.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            GelirleriListele();
        }


        // Giderleri listeleme
        void GiderleriListele()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;"))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Giderlerr", conn);
                da.Fill(dt);
                dgvGiderler.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            anaForm.Show();  // Form2'yi tekrar göster
            this.Close();    // Bu formu kapat
        }

        private void dgvGelirler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Satislarr (randevu_id, müşteri_id, çalışan_id, hizmet_id, satis_tarihi) VALUES (@randevu_id, @musteri_id, @calisan_id, @hizmet_id, @tarih)", baglanti);
            komut.Parameters.AddWithValue("@randevu_id", txtRandevuID.Text);
            komut.Parameters.AddWithValue("@musteri_id", txtMusteriID.Text);
            komut.Parameters.AddWithValue("@calisan_id", txtCalisanID.Text);
            komut.Parameters.AddWithValue("@hizmet_id", txthizmet.Text);
            komut.Parameters.AddWithValue("@tarih", dtpSatisTarihi.Value);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Satış eklendi.");
            SatislariListele(); // Listeyi güncelle
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            if (dgvSatislar.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dgvSatislar.SelectedRows[0].Cells["satis_id"].Value);
                SqlCommand komut = new SqlCommand("DELETE FROM Satislarr WHERE satis_id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", secilenID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                SatislariListele();
            }
        }

        private void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvSatislar.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dgvSatislar.SelectedRows[0].Cells["satis_id"].Value);
                SqlCommand komut = new SqlCommand("UPDATE Satislarr SET randevu_id=@r1, müşteri_id=@r2, çalışan_id=@r3, hizmet_id=@r4, satis_tarihi=@r5 WHERE satis_id=@id", baglanti);
                komut.Parameters.AddWithValue("@r1", txtRandevuID.Text);
                komut.Parameters.AddWithValue("@r2", txtMusteriID.Text);
                komut.Parameters.AddWithValue("@r3", txtCalisanID.Text);
                komut.Parameters.AddWithValue("@r4", txthizmet.Text);
                komut.Parameters.AddWithValue("@r5", dtpSatisTarihi.Value.Date);
                komut.Parameters.AddWithValue("@id", secilenID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                SatislariListele();
            }
        }

        private void dgvSatislar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSatislarr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvSatislar.SelectedCells[0].RowIndex;
            txtRandevuID.Text = dgvSatislar.Rows[secilen].Cells["randevu_id"].Value.ToString();
            txtMusteriID.Text = dgvSatislar.Rows[secilen].Cells["müşteri_id"].Value.ToString();
            txtCalisanID.Text = dgvSatislar.Rows[secilen].Cells["çalışan_id"].Value.ToString();
            txthizmet.Text = dgvSatislar.Rows[secilen].Cells["hizmet_id"].Value.ToString();
            dtpSatisTarihi.Value = Convert.ToDateTime(dgvSatislar.Rows[secilen].Cells["satis_tarihi"].Value);
        }

        private void btnOdemeListele_Click(object sender, EventArgs e)
        {

        }

        private void btnOdemeGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Odemelerr SET müşteri_id=@musteri, fiyat=@fiyat, randevu_tarihi=@tarih WHERE OdemeID=@id", baglanti);
            komut.Parameters.AddWithValue("@musteri", txtMusteriID.Text);
            komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            komut.Parameters.AddWithValue("@tarih", dtpRandevuTarihi_Odeme.Value);
            komut.Parameters.AddWithValue("@id", txtOdemeID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            OdemeleriListele();
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Odemelerr WHERE OdemeID=@id", baglanti);
            komut.Parameters.AddWithValue("@id", txtOdemeID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            OdemeleriListele();
        }

        private void dgvOdemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvOdemeler.SelectedCells[0].RowIndex;
            txtOdemeID.Text = dgvOdemeler.Rows[secilen].Cells["OdemeID"].Value.ToString();
            txtMusteriID.Text = dgvOdemeler.Rows[secilen].Cells["müşteri_id"].Value.ToString();
            txtFiyat.Text = dgvOdemeler.Rows[secilen].Cells["fiyat"].Value.ToString();
            dtpRandevuTarihi_Odeme.Value = Convert.ToDateTime(dgvOdemeler.Rows[secilen].Cells["randevu_tarihi"].Value);
        }

        private void btnGelirSil_Click(object sender, EventArgs e)
        {
            if (txtGelirID.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Gelirlerr WHERE gelir_id=@id", baglanti);
                komut.Parameters.AddWithValue("@id", txtGelirID.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                GelirleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen bir gelir seçin.");
            }
        }

        private void btnGelirGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGelirID.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Gelirlerr SET gelir_turu=@tur, miktar=@miktar, gelir_tarihi=@tarih WHERE gelir_id=@id", baglanti);
                komut.Parameters.AddWithValue("@tur", txtGelirTuru.Text);
                komut.Parameters.AddWithValue("@miktar", decimal.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@tarih", dtpGelirTarihi.Value);
                komut.Parameters.AddWithValue("@id", txtGelirID.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                GelirleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen bir gelir seçin.");
            }
        }

        private void dgvGelirler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvGelirler.SelectedCells[0].RowIndex;
            txtGelirID.Text = dgvGelirler.Rows[secilen].Cells["gelir_id"].Value.ToString();
            txtGelirTuru.Text = dgvGelirler.Rows[secilen].Cells["gelir_turu"].Value.ToString();
            txtMiktar.Text = dgvGelirler.Rows[secilen].Cells["miktar"].Value.ToString();
            dtpGelirTarihi.Value = Convert.ToDateTime(dgvGelirler.Rows[secilen].Cells["gelir_tarihi"].Value);
        }

        private void dgvGiderler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvGiderler.SelectedCells[0].RowIndex;
            txtGiderID.Text = dgvGiderler.Rows[secilen].Cells["gider_id"].Value.ToString();
            txtGiderTürü.Text = dgvGiderler.Rows[secilen].Cells["gider_turu"].Value.ToString();
            txtMiktar.Text = dgvGiderler.Rows[secilen].Cells["miktar"].Value.ToString();
            dtpGiderTarihi.Value = Convert.ToDateTime(dgvGiderler.Rows[secilen].Cells["gider_tarihi"].Value);
        }


        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            if (txtGiderID.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Giderlerr WHERE gider_id=@id", baglanti);
                komut.Parameters.AddWithValue("@id", txtGiderID.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                GiderleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen bir gider seçin.");
            }
        }

        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiderID.Text))
            {
                MessageBox.Show("Lütfen güncellenecek gideri seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiderTürü.Text) || string.IsNullOrWhiteSpace(txtMiktarr.Text))
            {
                MessageBox.Show("Gider türü ve miktar boş bırakılamaz.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Giderlerr SET gider_turu = @gider_turu, miktar = @miktar, gider_tarihi = @gider_tarihi WHERE gider_id = @gider_id", conn);
                    komut.Parameters.AddWithValue("@gider_turu", txtGiderTürü.Text);
                    komut.Parameters.AddWithValue("@miktar", decimal.Parse(txtMiktarr.Text));
                    komut.Parameters.AddWithValue("@gider_tarihi", dtpGiderTarihi.Value);
                    komut.Parameters.AddWithValue("@gider_id", int.Parse(txtGiderID.Text));
                    int sonuc = komut.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Gider başarıyla güncellendi.");
                        GiderleriListele(); // listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Gider güncellenemedi. ID bulunamadı.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Miktar alanı sayısal olmalıdır.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiderTürü.Text) || string.IsNullOrWhiteSpace(txtMiktarr.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMiktarr.Text.Replace(".", ","), out decimal miktar))
            {
                MessageBox.Show("Geçerli bir miktar giriniz. Örnek: 120,50", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Giderlerr (gider_turu, miktar, gider_tarihi) VALUES (@tur, @miktar, @tarih)", conn);
                    cmd.Parameters.AddWithValue("@tur", txtGiderTürü.Text.Trim());
                    cmd.Parameters.AddWithValue("@miktar", miktar);
                    cmd.Parameters.AddWithValue("@tarih", dtpGiderTarihi.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gider başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                GiderleriListele(); // gridview yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaForm.Show();  // Form2'yi tekrar göster
            this.Close();    // Form3'ü kapat
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anaForm.Show();  // Form2'yi tekrar göster
            this.Close();    // Form3'ü kapat
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaForm.Show();  // Form2'yi tekrar göster
            this.Close();    // Form3'ü kapat
        }

        private void txtGelirTuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiderTürü_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
    
