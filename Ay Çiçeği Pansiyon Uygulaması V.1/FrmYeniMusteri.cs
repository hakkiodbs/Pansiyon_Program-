using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "109";
        }

        private void BtnOda110_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "110";
        }

        private void BtnOda111_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "111";
        }

        private void BtnOda112_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "112";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir...");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşiş Renkli Odalar Boş Odaları Gösterir...");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand oda_ucret = new SqlCommand("SELECT Oda_Ucreti FROM Fiyat_Guncelle", baglanti);
                object odaUcreti = oda_ucret.ExecuteScalar();
                if (odaUcreti != null && odaUcreti != DBNull.Value)
                {
                    int odaUcretiValue = Convert.ToInt32(odaUcreti);

                    DateTime girisTarihi = Convert.ToDateTime(DtpGirisTarihi.Text);
                    DateTime cikisTarihi = Convert.ToDateTime(DtpCikisTarihi.Text);
                    TimeSpan fark = cikisTarihi - girisTarihi;
                    int gunSayisi = (int)fark.TotalDays;

                    int toplamUcret = gunSayisi * odaUcretiValue;
                    TxtUcret.Text = toplamUcret.ToString() + " TL";
                }
                else
                {
                    MessageBox.Show("Oda ücreti bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Musteri_Ekle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,Cikistarihi) VALUES (@Adi, @Soyadi, @Cinsiyet,@Telefon,@Mail,@TC,@OdaNo,@Ucret,@GirisTarihi,@Cikistarihi)", baglanti);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", CbxCinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", MksTxtNunber.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komut.Parameters.AddWithValue("@TC", TxtKimlikno.Text);
            komut.Parameters.AddWithValue("@OdaNo", TxtOda.Text);
            komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@Cikistarihi", DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Girişi Yapılmıştır.");
            this.Refresh();
        }

        private void BtnTemizle2_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CbxCinsiyet.Text = "";
            MksTxtNunber.Clear();
            TxtMail.Clear();
            TxtKimlikno.Clear();
            TxtOda.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
            this.Refresh();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT OdaNo FROM Musteri_Ekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                string odaNo = oku["OdaNo"].ToString();

                string buttonName = "BtnOda" + odaNo;
                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (button != null)
                {
                  button.BackColor = Color.Red; // Buton rengini varsayılan olarak kırmızı yapalım
                    button.Enabled = false;
                }
            }
            baglanti.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
//SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");