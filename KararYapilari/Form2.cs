using System;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
           * MANTIKSAL OPERATORLER
           * Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
           * && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret eder... Kosullardan biri dahi saglanmazsa blogunuz harekete gecmez...)
           * || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi durumuna isaret eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz kodlar harekete gecer...) Kısayol => ALTGR + Tire
           * 
           * Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. Kosullari kontrole en soldan baslar, herhangi bir uygunsuzluk durumunda diger kosullara asla bakmaz!.. Asagidaki operatorlerde ise, kosullar uysun ya da uymasin hepsi kontrol edilir...
           * 
           * & => VE
           * | => VEYA
           */

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string result = "";
            if (username == txtGelenDeger1.Text) // admin => true
            {
                if (password == txtGelenDeger2.Text) // 123
                {
                    result = "Tebrikler!!!";
                }
                else
                {
                    result = "Şifreniz Yanlış\nAnne sütü önemli";
                }
            }
            else
            {
                result = "Kullanıcı Adınız Yanlış\nYine başarısızlık!!!";
            }
            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";
            string result = "";

            if (txtGelenDeger1.Text == username && txtGelenDeger2.Text == password)
            {
                result = "Tebrikler!!!";
            }
            else
            {
                result = "Kullanıcı Adınız Yanlış\nYine başarısızlık!!!";
            }
            MessageBox.Show(result);
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..

            int not = int.Parse(txtGelenDeger1.Text);
            string _not = "Harf Nonutunuz ";
            if (not >= 0 && not <= 30)
                _not += "FF";
            else if (not > 30 && not <= 50)
                _not += "DD";
            else if (not > 50 && not <= 70)
                _not += "CC";
            else if (not > 70 && not <= 85)
                _not += "BB";
            else if (not > 85 && not <= 100)
                _not += "AA";
            else
                _not = "Lütfen Geçerli bir not değeri giriniz!!!";
            MessageBox.Show(_not);




            if (not >= 0 && not <= 100)
            {
                if (not <= 30) { _not += "FF"; }
                else if (not <= 50) { _not += "DD"; }
                else if (not <= 70) { _not += "CC"; }
                else if (not <= 85) { _not += "BB"; }
                else { _not += "AA"; }
            }
            else
                _not = "Lütfen Geçerli bir not değeri giriniz!!!";
            MessageBox.Show(_not);
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!

            string urun = txtGelenDeger1.Text.ToLower(); //ToLower() => hepsini küçük harfe çevirir
            string mesaj = "Aradığınız ürün ";
            if (urun == "domates" || urun == "patlıcan" || urun == "biber")
            {
                mesaj += "Sebze Reyonundadır!";
            }
            else if (urun == "diş macunu" || urun == "parfüm" || urun == "şampuan")
            {
                mesaj += "Kozmetik Reyonundadır!";
            }
            else if (urun == "cep telefonu" || urun == "bilgisayar" || urun == "ses sistemi")
            {
                mesaj += "Teknoloji Reyonundadır!";
            }
            else
            {
                mesaj += "bizde bulunmamaktadır!";
            }
            MessageBox.Show(mesaj);
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...

            // Toplam sipariş adediniz : 100
            // Birim fiyatı            : 5 TL
            // Toplam tutar            : 500 TL
            // Yapılan indirim oranı   : %25
            // Ödemeniz gereken tutar  : 375 TL
        }
    }
}
