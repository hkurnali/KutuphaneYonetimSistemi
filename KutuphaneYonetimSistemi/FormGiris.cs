using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        FormKitaplar formKitaplar;
        public FormGiris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglantý = new SqlConnection(@"Data Source=DESKTOP-H080ONB\SQLEXPRESS01;Initial Catalog=dbkutuphane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre="";
            try
            {
                baglantý.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM  TableKutuphaneYöneticileri WHERE KullanacýAdý = @p1", baglantý);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKulAd.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    sifre = Convert.ToString(sqlDataReader[0]);
                }

                // label3.Text = sifre;
                if (sifre==textBoxSifre.Text)
                {
                   
                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();
                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre HATALI..");
                    textBoxKulAd.Text = "";
                    textBoxSifre.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Baðlantý Hatasý   "+ex.Message);
            }
            finally
            {
                baglantý.Close();

            }   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}