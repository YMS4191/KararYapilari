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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            string username = txtGelenDeger1.Text;

            switch (username)
            {
                case "admin":
                    MessageBox.Show("Admin Hoşgeldin");
                    break;
                case "ceo":
                    MessageBox.Show("Ceo Hoşgeldin");
                    break;
                case "user":
                    MessageBox.Show("User Neden Geldin");
                    break;
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            string
                gelen_username = txtGelenDeger1.Text,
                gelen_password = txtGelenDeger2.Text;


            // Kullanıcı dışarıdna kullanıcı adı ve şifresini girecek.
            // 1) Kullanıcı kullanıcı adını yanlış girerse, "kullanıcı adınız yanlış, şifrenizi kontrol etmedim"
            // 2) Kullanıcı kullanıcı adını doğru girerse, şifresini kontrol ediniz.
            // 3) Kullanıcı şifresini yanlış girerse, "kullanıcı adınız doğru, fakat şifreniz yanlış"
            // 4) Kullanıcı şifresini doğru girerse, "Tebrikler, hayata dair büyük bir başarı"
            const string admin = "admin";

            switch (gelen_username)
            {
                case admin:
                    switch (gelen_password)
                    {
                        case "123":
                            MessageBox.Show("Tebrikler, hayata dair büyük bir başarı");
                            break;
                        default:
                            MessageBox.Show("kullanıcı adınız doğru, fakat şifreniz yanlış");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("kullanıcı adınız yanlış, şifrenizi kontrol etmedim");
                    break;
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            // dışarıdan admin,ceo, moderator girilirse, yönetim paneli
            // user, girilirse, kullanıcı paneli
            // default bir değer girilirse, yetki hatası mesajı verdiriniz.

            switch (txtGelenDeger1.Text)
            {
                case "admin":
                case "moderator":
                case "ceo":
                    MessageBox.Show("Yönetim Paneli");
                    break; 
                case "user":
                    MessageBox.Show("Kullanıcı Paneli");
                    break;
                default:
                    MessageBox.Show("Yetki Hatası");
                    break;
            }
        }
    }
}
