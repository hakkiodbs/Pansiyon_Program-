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
    public partial class FrmMuhasebeFormu : Form
    {
        public FrmMuhasebeFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt32(TxtPersonelsayisi.Text);
            LblPersonelMaas.Text = (personel * 1500).ToString();

            int kasa_Toplam_Hesap;
            kasa_Toplam_Hesap = Convert.ToInt32(LblKasaToplamPara.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblToplamUrun.Text) + Convert.ToInt32(LblFatura.Text));

            LblKarZarar.Text =(kasa_Toplam_Hesap).ToString();


        }

        private void FrmMuhasebeFormu_Load(object sender, EventArgs e)
        {
           // Kasadaki Toplam Para
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(Ucret) AS Toplam FROM Musteri_Ekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplamPara.Text = oku["Toplam"].ToString();
            }
            baglanti.Close();

            //Gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(Gida) AS Toplam2 FROM Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler1.Text = oku2["Toplam2"].ToString();
            }
            baglanti.Close();

            //İçecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT SUM(Icecek) AS Toplam3 FROM Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler2.Text = oku3["Toplam3"].ToString();
            }
            baglanti.Close();

            //Atıştırmalık

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT SUM(Cerezler) AS Toplam4 FROM Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler3.Text = oku4["Toplam4"].ToString();
            }
            baglanti.Close();

            int a,b,c,sonuc;

            a = Convert.ToInt32(LblAlinanUrunler1.Text);
            b = Convert.ToInt32(LblAlinanUrunler2.Text);
            c = Convert.ToInt32(LblAlinanUrunler3.Text);
            sonuc = a + b + c;

            LblToplamUrun.Text = (sonuc).ToString();


            //Elektrik
            baglanti.Open();
            SqlCommand elektrik = new SqlCommand("SELECT SUM(Elektrik) AS Etoplam FROM Faturalar", baglanti);
            SqlDataReader elektrik_oku = elektrik.ExecuteReader();
            while (elektrik_oku.Read())
            {
                LblElektrik.Text = elektrik_oku["Etoplam"].ToString();
            }
            baglanti.Close();

            //Doğalgaz
            baglanti.Open();
            SqlCommand Dogalgaz = new SqlCommand("SELECT SUM(Dogalgaz) AS Dtoplam FROM Faturalar", baglanti);
            SqlDataReader dogalgaz_oku = Dogalgaz.ExecuteReader();
            while (dogalgaz_oku.Read())
            {
                LblDogalgaz.Text = dogalgaz_oku["Dtoplam"].ToString();
            }
            baglanti.Close();

            //Su Faturası

            baglanti.Open();
            SqlCommand SuFaturasi = new SqlCommand("SELECT SUM(SuFaturasi) AS Stoplam FROM Faturalar", baglanti);
            SqlDataReader su_oku = SuFaturasi.ExecuteReader();
            while (su_oku.Read())
            {
                LblSu.Text = su_oku["Stoplam"].ToString();
            }
            baglanti.Close();

            //İnternet Fautrası

            baglanti.Open();
            SqlCommand internetF = new SqlCommand("SELECT SUM(internet) AS itoplam FROM Faturalar", baglanti);
            SqlDataReader internet_oku = internetF.ExecuteReader();
            while (internet_oku.Read())
            {
                Lblİnternet.Text = internet_oku["itoplam"].ToString();
            }
            baglanti.Close();

            int d, x, f,g,fsonuc;

            d = Convert.ToInt32(LblElektrik.Text);
            x = Convert.ToInt32(LblDogalgaz.Text);
            f = Convert.ToInt32(LblSu.Text);
            g = Convert.ToInt32(Lblİnternet.Text);
            fsonuc = d + x + f + g;

            LblFatura.Text = (fsonuc).ToString();


           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
