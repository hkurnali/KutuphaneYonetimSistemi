using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormKitaplar : Form
    {
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-H080ONB\SQLEXPRESS01;Initial Catalog=dbkutuphane;Integrated Security=True");

        public FormKitaplar()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonYeniKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into TableKitaplar" +
               "(Kitapadi,Yazaradi,YazarSoyadi,ISBN,Durum,KitapTurKodu)values(@P1,@P2,@P3,@P4,@P5,@P6)", baglantı);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "True");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxKitapTurKodu.Text);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
MessageBox.Show("Bir bağlantı hatası oluştu.."+ex.Message);
               
            }
            finally
            {
                baglantı.Close();
            }
            VerileriGoster();
        }
        private void VerileriGoster()
        {

            string g = "select * from TableKitaplar";
            SqlDataAdapter da = new SqlDataAdapter(g, baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewKitaplar.DataSource = dt;
            }

        }
      
            private void FormKitaplar_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

       

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyadi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)
                dateTimePicker1.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;
        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                baglantı.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi=@P1,YazarAdi=@P2,YazarSoyadi=@P3,ISBN=@P4,KitapTurKodu=@P5 WHERE ID=@P6", baglantı);


                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxKitapTurKodu.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir bağlantı hatası oluştu.." + ex.Message);

            }
            finally
            {
                baglantı.Close();
            }

            VerileriGoster();
        }

        private void buttonKitapOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {

                    baglantı.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan=@P1,OduncAlmaTarihi=@P2,Durum=@P3 WHERE ID=@P4", baglantı);


                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünc esnasında hatası oluştu.." + ex.Message);

                }
                finally
                {
                    baglantı.Close();
                }

                VerileriGoster();

            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz..");
            }
        }

        private void buttonGecikmeHesaplama_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime bugununTarihi = DateTime.Now;
                int gunFarki = (int)(bugununTarihi - dateTimePicker1.Value.Date).TotalDays;
                if (gunFarki > 10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 2;
                    labelGecikmeBedeli.Text = Convert.ToString(gecikmeBedeli);
                }

            }
        }

        private void buttonKitapİadeEt_Click(object sender, EventArgs e)
        {

            if (labelID.Text != "-")
            {

                try
                {

                    baglantı.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan=@P1,OduncAlmaTarihi=@P2,Durum=@P3 WHERE ID=@P4", baglantı);


                    sqlCommand.Parameters.AddWithValue("@P1", " ");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                    textBoxOduncAlan.Text= " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade esnasında hatası oluştu.." + ex.Message);

                }
                finally
                {
                    baglantı.Close();
                }

                VerileriGoster();

            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            MetinKutulariniTemizle();

        }
        public void MetinKutulariniTemizle()
        {

            labelID.Text = "";
            textBoxKitapAdi.Text = "";
            textBoxYazarAdi.Text = "";
            textBoxYazarSoyadi.Text = "";
            textBoxISBN.Text = "";
            textBoxOduncAlan.Text = "";
            textBoxKitapTurKodu.Text = "";

        }

        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            aranmaSonuclariniGoster();
        }
            private void aranmaSonuclariniGoster()
            {
            try
            {
                string g = "SELECT * FROM TableKitaplar WHERE Kitapadi LIKE '" + textBoxKitapAdi.Text 
                                   + "%'  AND Yazaradi LIKE '" + textBoxYazarAdi.Text + "%'"
                                                          + "  AND YazarSoyadi LIKE '" + textBoxYazarSoyadi.Text + "%'"
                                                           + " AND ISBN LIKE '" + textBoxISBN.Text + "%'"
                                                            + "  AND KitapTurKodu LIKE '" + textBoxKitapTurKodu.Text + "%'"
                                                             + "  AND OduncAlan LIKE '" + textBoxOduncAlan.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(g, baglantı);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }

            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }







            }

        private void buttonHepsiniGoster_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void dataGridViewKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text=="-"|| labelID.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin..");
            }
            else
            {

           
            try
            {

                baglantı.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID = @P1", baglantı);                
                sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap silerken hatası oluştu.." + ex.Message);

            }
            finally
            {
                baglantı.Close();
            }

            VerileriGoster();
                MetinKutulariniTemizle();
            }
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
