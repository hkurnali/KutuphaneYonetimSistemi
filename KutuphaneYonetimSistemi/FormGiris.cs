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
        SqlConnection baglant� = new SqlConnection(@"Data Source=DESKTOP-H080ONB\SQLEXPRESS01;Initial Catalog=dbkutuphane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre="";
            try
            {
                baglant�.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM  TableKutuphaneY�neticileri WHERE Kullanac�Ad� = @p1", baglant�);
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
                    MessageBox.Show("Kullan�c� Ad� veya �ifre HATALI..");
                    textBoxKulAd.Text = "";
                    textBoxSifre.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ba�lant� Hatas�   "+ex.Message);
            }
            finally
            {
                baglant�.Close();

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