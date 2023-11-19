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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void veriler()
        {
            ListEnvanter.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                ListEnvanter.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void faturalar()
        {
            LstFatura.Items.Clear();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Faturalar", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku1["Elektrik"].ToString();
                ekle.SubItems.Add(oku1["Dogalgaz"].ToString());
                ekle.SubItems.Add(oku1["SuFaturasi"].ToString());
                ekle.SubItems.Add(oku1["internet"].ToString());
                LstFatura.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            faturalar();
        }

        private void BtnKaydetFatura_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("INSERT INTO Faturalar (Elektrik,Dogalgaz,SuFaturasi,internet) VALUES (@Elektrik,@Dogalgaz,@SuFaturasi,@internet)", baglanti);
            komut1.Parameters.AddWithValue("@Elektrik", TxtElektrik.Text);
            komut1.Parameters.AddWithValue("@Dogalgaz", TxtDogalgaz.Text);
            komut1.Parameters.AddWithValue("@SuFaturasi", TxtSuFaturasi.Text);
            komut1.Parameters.AddWithValue("@internet", TxtInternet.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
            TxtGidalar.Clear();
            TxtIcecekler.Clear();
            TxtAtistirmalik.Clear();
            faturalar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Stoklar (Gida,Icecek,Cerezler) VALUES (@Gida,@Icecek,@Cerezler)", baglanti);
            komut.Parameters.AddWithValue("@Gida", TxtGidalar1.Text);
            komut.Parameters.AddWithValue("@Icecek", TxtIcecekler1.Text);
            komut.Parameters.AddWithValue("@Cerezler", TxtAtistirmalik1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
            TxtGidalar.Clear();
            TxtIcecekler.Clear();
            TxtAtistirmalik.Clear();
            veriler();
        }
    }
}
