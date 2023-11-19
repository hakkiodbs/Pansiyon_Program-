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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-91BCT64\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand vericek = new SqlCommand("Select * from Musteri_Ekle", baglanti);
            SqlDataReader verioku = vericek.ExecuteReader();

            while (verioku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = verioku["Musteriid"].ToString();
                ekle.SubItems.Add(verioku["Adi"].ToString());
                ekle.SubItems.Add(verioku["Soyadi"].ToString());
                ekle.SubItems.Add(verioku["Cinsiyet"].ToString());
                ekle.SubItems.Add(verioku["Telefon"].ToString());
                ekle.SubItems.Add(verioku["Mail"].ToString());
                ekle.SubItems.Add(verioku["TC"].ToString());
                ekle.SubItems.Add(verioku["OdaNo"].ToString());
                ekle.SubItems.Add(verioku["Ucret"].ToString());
                ekle.SubItems.Add(verioku["GirisTarihi"].ToString());
                ekle.SubItems.Add(verioku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text= listView1.SelectedItems[0].SubItems[2].Text;
            CbxCinsiyet.Text= listView1.SelectedItems[0].SubItems[3].Text;
            MksTxtNunber.Text= listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text= listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikno.Text= listView1.SelectedItems[0].SubItems[6].Text;
            TxtOda.Text= listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text= listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text= listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text= listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Musteri_Ekle SET OdaNo = NULL WHERE OdaNo = @OdaNo", baglanti);
            komut.Parameters.AddWithValue("@OdaNo", TxtOda.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleşmiştir.");
            // Buradan Sonraki Ekranları Temizleyecektir.
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
            verilerigoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CbxCinsiyet.Text="";
            MksTxtNunber.Clear();
            TxtMail.Clear();
            TxtKimlikno.Clear();
            TxtOda.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
            verilerigoster();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand veriguncelle = new SqlCommand("Update Musteri_Ekle set Adi='"+TxtAdi.Text+"',Soyadi='"+TxtSoyadi.Text+"',Cinsiyet='"+CbxCinsiyet.Text+"',Telefon='"+MksTxtNunber.Text+"',Mail='"+TxtMail.Text+"',TC='"+TxtKimlikno.Text+"',OdaNo='"+TxtOda.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"+DtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='"+DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid="+id+"",baglanti);
            veriguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı.");
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
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand vericek = new SqlCommand("Select * from Musteri_Ekle Where Adi like '%"+TxtAra.Text+"%'", baglanti);
            SqlDataReader verioku = vericek.ExecuteReader();

            while (verioku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = verioku["Musteriid"].ToString();
                ekle.SubItems.Add(verioku["Adi"].ToString());
                ekle.SubItems.Add(verioku["Soyadi"].ToString());
                ekle.SubItems.Add(verioku["Cinsiyet"].ToString());
                ekle.SubItems.Add(verioku["Telefon"].ToString());
                ekle.SubItems.Add(verioku["Mail"].ToString());
                ekle.SubItems.Add(verioku["TC"].ToString());
                ekle.SubItems.Add(verioku["OdaNo"].ToString());
                ekle.SubItems.Add(verioku["Ucret"].ToString());
                ekle.SubItems.Add(verioku["GirisTarihi"].ToString());
                ekle.SubItems.Add(verioku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
//Data Source=DESKTOP-91BCT64\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True