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
    public partial class FrmFiyat_Guncelle : Form
    {
        public FrmFiyat_Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void FrmFiyat_Guncelle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(Oda_Ucreti) AS Oda_Topla FROM Fiyat_Guncelle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                BtnEskiFiyat.Text = oku["Oda_Topla"].ToString()+ " TL";
                            }
            baglanti.Close();
        }

        private void BtnFiyatGuncelle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtGuncelFiyat.Text))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand veriguncelle = new SqlCommand("Update Fiyat_Guncelle set Oda_Ucreti = @OdaUcreti", baglanti);
                    veriguncelle.Parameters.AddWithValue("@OdaUcreti", TxtGuncelFiyat.Text);
                    veriguncelle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Güncelleme Başarılı.");
                    TxtGuncelFiyat.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
                }
            }

        }



        private void BtnEskiFiyat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
