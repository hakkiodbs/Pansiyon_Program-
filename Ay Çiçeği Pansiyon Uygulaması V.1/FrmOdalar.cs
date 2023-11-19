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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT OdaNo, Adi, Soyadi FROM Musteri_Ekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                string odaNo = oku["OdaNo"].ToString();
                string adiSoyadi = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();

                string buttonName = "BtnOda" + odaNo;
                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (button != null)
                {
                    button.Text = adiSoyadi;
                    if (button.Text != odaNo)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            baglanti.Close();
        }
    }
}
