using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kuafor_Salonu
{
    public partial class musteriler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=kandemir\\SQL;Initial Catalog=kuafor_salonu;Integrated Security=True;");
        private object anaForm;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells["müşteri_id"].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells["ad"].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells["soyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[secilen].Cells["telefon_no"].Value.ToString();
            dtpKayitTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells["kayıt_tarihi"].Value);
        }

        public musteriler(anasayfa gelenAnaForm)
        {
            InitializeComponent();
            anaForm = gelenAnaForm;
        }

        public musteriler()
        {
            InitializeComponent();
            this.Load += new EventHandler(musteriler_Load);
        }

        private void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Müşterilerr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void musteriler_Load(object sender, EventArgs e)
        {
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            Listele(); // Zaten varsa, aynen bırak.
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Müşterilerr (ad, soyad, telefon_no, kayıt_tarihi) VALUES (@ad, @soyad, @telefon, @tarih)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@tarih", dtpKayitTarihi.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.");
                return;
            }

            DialogResult onay = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Müşterilerr WHERE müşteri_id=@id", baglanti);
                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
                    int sonuc = komut.ExecuteNonQuery();
                    baglanti.Close();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Müşteri başarıyla silindi.");
                        Listele();
                        txtID.Clear();
                        txtAd.Clear();
                        txtSoyad.Clear();
                        txtTelefon.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Silme başarısız. Müşteri bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Müşterilerr SET ad=@ad, soyad=@soyad, telefon_no=@telefon, kayıt_tarihi=@tarih WHERE müşteri_id=@id", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@tarih", dtpKayitTarihi.Value);
            komut.Parameters.AddWithValue("@id", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells["müşteri_id"].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells["ad"].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells["soyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[secilen].Cells["telefon_no"].Value.ToString();
            dtpKayitTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells["kayıt_tarihi"].Value);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa(); // yeni anasayfa formu oluştur
            ana.Show();                    // anasayfayı aç
            this.Hide();                   // müşteriler formunu gizle
        }
    }


}
