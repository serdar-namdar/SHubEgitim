using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitimi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez!");
            }
            else
            {
                if (txtKullaniciAdi.Text == "Admin" && txtSifre.Text == "12345")
                {
                    MessageBox.Show("Hoşgeldin Admin");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
