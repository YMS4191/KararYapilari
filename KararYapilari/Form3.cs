using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        private void Form3_Load(object sender, EventArgs e)
        {
            //Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler adli label'a yazdirilacak ve kullanicidan butona bastigi anda textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak. Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
            //Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
            //Her hatali giriste yeni bir rastgele sayi turetilmelidir...

            lblRastgeleKarakterler.Text = rnd.Next(10000000, 100000000).ToString();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (lblRastgeleKarakterler.Text == txtMetinGirisAlani.Text)
            {
                MessageBox.Show("Tebrikler giriş yaptınız!");
                lblRastgeleKarakterler.Text = "* * *";
                txtMetinGirisAlani.Text = "";
                txtMetinGirisAlani.Enabled = false;
                btnGirisYap.Enabled = false;
                lblKalanHakkimiz.Text = "5";
            }
            else
            {
                lblRastgeleKarakterler.Text = rnd.Next(10000000, 100000000).ToString();
                txtMetinGirisAlani.Clear();
                txtMetinGirisAlani.Focus();
                lblKalanHakkimiz.Text = (int.Parse(lblKalanHakkimiz.Text) - 1).ToString();
                if (lblKalanHakkimiz.Text == "0")
                {
                    lblRastgeleKarakterler.Text = "* * *";
                    txtMetinGirisAlani.Text = null;
                    txtMetinGirisAlani.Enabled = false;
                    btnGirisYap.Enabled = false;
                    lblKalanHakkimiz.Text = "5";
                }
            }
        }
    }
}
