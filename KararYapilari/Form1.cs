using System;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
           KARAR YAPILARI
           Uygulamanizin calismasi esnasinda farkli senaryolara gore farkli yonlendirmeler yapmaniz gerekebilir. Ornegin, kullanicidan gelen degerin araligina gore,      uygulamadaki     mantiksal islerinizin sonuclarina gore yonlendirmeler yapabiliriz. 
           3 temel karar yapısı karsimiza cikar => IF-ELSE ~ SWITCH-CASE ~ TERNARY OPERATORU
        */
        /*
         Karşılaştırma operatorleri
         1) == (Soldaki değerin, sağdaki değere eşit olma durumu)
            1 == 1 => true  (if)
            1 == 2 => false (else)

         2) != (Soldaki değerin, sağdaki değere eşit olmama durumu)
            1 != 2 => true  (if)
            1 != 1 => false (else)
            
         3) < (Soldai değerin, sağdaki değerden, küçük olma durumu)
            1 < 2 => true   (if)
            2 < 1 => false  (else)
              
         4) > (Soldaki değerin, sağdaki değerden, büyük olma durumu)
            2 > 1 => true   (if)
            2 > 5 => false  (else)

         5) <= (Soldaki değerin, sağdaki değerden küçük veya eşit olma durumu)
            1 <= 2 => true  (if) (küçük olma durumu)
            1 <= 1 => true  (if) (eşit olma durumu) 
            2 <= 1 => false (else) 

         6) >= (Soldaki değerin, sağdaki değerden büyük veya eşit olma durumu)
            5 >= 1 => true  (if) (büyük olma durumu)
            5 >= 5 => true  (if) (eşit olma durumu)
            1 >= 5 => false (else)


         7) ! (Olumsuz hale getirme durumu)
            !(1 == 1) => false
        */
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "admin")
            {
                MessageBox.Show("Tebrikler giriş yaptınız");
            } // true
            else
            {
                MessageBox.Show("Ne kadar zor olabilir ?");
            } // false
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Eger girilen not 0'dan kucukse "O'dan küçük bir not girişi yapamazsınız" 100'den buyukse "100'den büyük bir not girişi yapamazsınız" mesajini gostersin...

            //int not = Convert.ToInt32(txtDeger.Text);
            int not = int.Parse(txtDeger.Text);
            if (not < 0)
            {
                MessageBox.Show("0'dan küçük not girişi yapamazsınız!");
            }
            else if (not > 100)
            {
                MessageBox.Show("100'den büyük not girişi yapamazsınız!");
            }
            else
            {
                MessageBox.Show("Notunuz : " + not);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //txtGirisAlani'ndan girilen sayi cift ise "Sayı Çifttir" tek ise "Sayı Tektir" mesajini kullaniciya gosteriniz...

            int sayi = int.Parse(txtDeger.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("Sayı çifttir");
            }
            else
            {
                MessageBox.Show("Sayı tektir");
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Disaridan girilen kelimenin uzunlugu 8 karaktere esit ya da buyukse kayit onaylandi, degilse daha uzun bir sifre giriniz...

            if (txtDeger.Text.Length >= 8) { MessageBox.Show("Tebrikler"); }
            else { MessageBox.Show("Hayal Kırıklığısını"); }
        }

        private void txtDeger_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
