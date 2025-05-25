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
    public partial class Hizmetler : Form
    {
        private anasayfa anaForm;
        SqlConnection baglanti = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;");
        private object id;

        public Hizmetler(anasayfa gelenAnaForm)
        {
            InitializeComponent();
            anaForm = gelenAnaForm;
            this.Load += new System.EventHandler(this.Form5_Load);
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hizmetlerr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHizmetler.DataSource = dt;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void HizmetleriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hizmetlerr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHizmetler.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            decimal fiyat;
            if (!decimal.TryParse(txtFiyat.Text, out fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Hizmetlerr (hizmet_adı, fiyat) VALUES (@ad, @fiyat)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtHizmetAdi.Text);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void dgvHizmetler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvHizmetler.SelectedCells[0].RowIndex;
            txtID.Text = dgvHizmetler.Rows[secilen].Cells["hizmet_id"].Value.ToString();
            txtHizmetAdi.Text = dgvHizmetler.Rows[secilen].Cells["hizmet_adı"].Value.ToString();
            txtFiyat.Text = dgvHizmetler.Rows[secilen].Cells["fiyat"].Value.ToString();
        }


        void Temizle()
        {
            txtHizmetAdi.Text = "";
            txtFiyat.Text = "";
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek hizmeti seçin.");
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Hizmetlerr SET hizmet_adı = @ad, fiyat = @fiyat WHERE hizmet_id = @id", baglanti);
                komut.Parameters.AddWithValue("@ad", txtHizmetAdi.Text);
                komut.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Hizmet başarıyla güncellendi.");
                    Listele(); // Listeyi güncelle
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.");
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Lütfen silinecek hizmeti seçin.");
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Hizmetlerr WHERE hizmet_id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            anaForm.Show();  // Form2'yi tekrar göster
            this.Close();    // Form3'ü kapat
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvHizmetler_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvHizmetler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvHizmetler.SelectedCells[0].RowIndex;
            txtID.Text = dgvHizmetler.Rows[secilen].Cells["hizmet_id"].Value.ToString();
            txtHizmetAdi.Text = dgvHizmetler.Rows[secilen].Cells["hizmet_adı"].Value.ToString();
            txtFiyat.Text = dgvHizmetler.Rows[secilen].Cells["fiyat"].Value.ToString();
        }
    }


}

