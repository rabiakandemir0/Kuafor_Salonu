using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kuafor_Salonu
{
    public partial class Randevular : Form
    {


        private anasayfa anaForm;  // Ana formu burada saklayacağız
        SqlConnection baglanti = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;");


        public Randevular(anasayfa gelenAnaForm)
        {
            InitializeComponent();
            anaForm = gelenAnaForm;


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CalisanListele();
            HizmetListele();
            DurumlariYukle();
            RandevulariListele();
        }

        private void RandevulariYukle()
        {

        }

        private void CalisanListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT calisan_id, ad + ' ' + soyad AS adsoyad FROM Calisanlarr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCalisan.DataSource = dt;
            cmbCalisan.DisplayMember = "adsoyad";
            cmbCalisan.ValueMember = "calisan_id";
        }

        private void HizmetListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT hizmet_id, hizmet_adı FROM hizmetlerr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbHizmet.DataSource = dt;
            cmbHizmet.DisplayMember = "hizmet_adı";
            cmbHizmet.ValueMember = "hizmet_id";
        }
        private void DurumlariYukle()
        {
            cmbDurum.Items.Add("Bekliyor");
            cmbDurum.Items.Add("Tamamlandı");
            cmbDurum.Items.Add("İptal");
            cmbDurum.SelectedIndex = 0;
        }

        private void RandevulariListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Randevularr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRandevular.DataSource = dt;
        }


        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {

            // Müşteri ID'sini otomatik almak için önce veritabanından son eklenen müşteri ID'sini alıyoruz.
            int musteriId = GetLastMusteriId();

            if (musteriId == 0)
            {
                MessageBox.Show("Geçerli bir müşteri bulunamadı.");
                return;
            }

            // Diğer verileri alıyoruz
            int calisanId = Convert.ToInt32(cmbCalisan.SelectedValue);
            int hizmetId = Convert.ToInt32(cmbHizmet.SelectedValue);
            string durum = cmbDurum.SelectedItem?.ToString();
            DateTime tarih = dtpRandevuTarihi.Value;

            string query = "INSERT INTO Randevularr (müşteri_id, çalışan_id, hizmet_id, randevu_tarihi, randevu_durumu) " +
                           "VALUES (@musteri, @calisan, @hizmet, @tarih, @durum)";

            using (SqlConnection conn = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@musteri", musteriId); // Otomatik alınan müşteri ID'si
                cmd.Parameters.AddWithValue("@calisan", calisanId);
                cmd.Parameters.AddWithValue("@hizmet", hizmetId);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.Parameters.AddWithValue("@durum", durum);

                conn.Open();
                cmd.ExecuteNonQuery();  // Veri ekle
                conn.Close();
            }

            // Veri başarıyla eklendikten sonra DataGridView güncelleniyor
            MessageBox.Show("Randevu başarıyla eklendi.");
            RandevulariListele();  // Güncellenmiş veriyi listele
        }

        // Son eklenen müşteri ID'sini veritabanından alıyoruz
        private int GetLastMusteriId()
        {
            int lastMusteriId = 0;

            string query = "SELECT MAX(müşteri_id) FROM Müşterilerr";

            using (SqlConnection conn = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastMusteriId = Convert.ToInt32(result);
                }

                conn.Close();
            }

            return lastMusteriId;
        }
        
        



        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            anaForm.Show();  // Form2'yi tekrar göster
            this.Close();    // Bu formu kapat
        }

        private void RandevularıYukle_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.SelectedRows.Count > 0)
            {
                int randevuId = Convert.ToInt32(dgvRandevular.SelectedRows[0].Cells["randevu_id"].Value);
                SqlCommand cmd = new SqlCommand("DELETE FROM Randevularr WHERE randevu_id = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", randevuId);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Randevu silindi.");
                RandevulariListele();
            }


            // Randevuları tekrar yükle

        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RandevuGuncelle_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan randevu ID'sini alıyoruz
            int randevuId;

            // Randevu ID'nin geçerli bir tam sayı (int) olup olmadığını kontrol et
            if (!int.TryParse(txtRandevuId.Text, out randevuId) || randevuId <= 0)
            {
                MessageBox.Show("Geçerli bir randevu ID'si giriniz.");
                return;  // Eğer geçerli değilse işlemi durdur
            }

            // Güncellenecek verileri alıyoruz
            int calisanId = Convert.ToInt32(cmbCalisan.SelectedValue);
            int hizmetId = Convert.ToInt32(cmbHizmet.SelectedValue);
            string durum = cmbDurum.SelectedItem?.ToString();
            DateTime tarih = dtpRandevuTarihi.Value;

            // UPDATE SQL sorgusu
            string query = "UPDATE Randevularr SET çalışan_id = @calisan, hizmet_id = @hizmet, randevu_tarihi = @tarih, randevu_durumu = @durum WHERE randevu_id = @randevuId";

            using (SqlConnection conn = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Parametreleri ekliyoruz
                cmd.Parameters.AddWithValue("@randevuId", randevuId);
                cmd.Parameters.AddWithValue("@calisan", calisanId);
                cmd.Parameters.AddWithValue("@hizmet", hizmetId);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.Parameters.AddWithValue("@durum", durum);

                try
                {
                    // Bağlantıyı açıyoruz ve komutumuzu çalıştırıyoruz
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Randevu başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi başarısız oldu. Lütfen randevu ID'sini kontrol edin.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            // DataGridView'i tekrar güncelliyoruz
            RandevulariListele();  // Güncellenmiş veriyi listele

        }




    }
    
}
