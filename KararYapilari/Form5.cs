using System;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            // Ternary Operatoru ? : 


            //bool result = 10 > 2;
            //MessageBox.Show(result ? "" : "");

            //MessageBox.Show(20 > 20 ? "İşlem sonucu true" : "İşlem sonucu false");

            // Kullanıcı textbox içerisine bir değer girdiyse o değeri girmediyse de default bir değer gösteriniz.


            //MessageBox.Show(txtGelenDeger.Text.Length > 0 ? txtGelenDeger.Text : "Default Değer");


            //MessageBox.Show((txtGelenDeger.Text.Length > 0 && txtGelenDeger.Text != " ") ? txtGelenDeger.Text : "Default Değer");
            MessageBox.Show(!string.IsNullOrEmpty(txtGelenDeger.Text) ? txtGelenDeger.Text : "Default Değer");
            MessageBox.Show(!string.IsNullOrWhiteSpace(txtGelenDeger.Text) ? txtGelenDeger.Text : "Default Değer");
        }
    }
}
