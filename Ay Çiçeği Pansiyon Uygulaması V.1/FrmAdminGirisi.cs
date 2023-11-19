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
    public partial class FrmAdminGirisi : Form
    {
        public FrmAdminGirisi()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True";

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            this.AcceptButton = BtnGirisYap;
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sql = "SELECT * FROM AdminGiris WHERE Kullanici = @KullaniciAdi";
                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdi.Text.Trim());

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string storedPassword = dt.Rows[0]["Sifre"].ToString();
                        string enteredPassword = TxtSifre.Text.Trim();

                        if (storedPassword == enteredPassword)
                        {
                            FrmAnaForm fr = new FrmAnaForm();
                            fr.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Şifre yanlış girildi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı yanlış girildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu: " + ex.Message);
                }
                // using bloğu içerisinde bağlantı kapatılacak
            }
        }
    }
}
