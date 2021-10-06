using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RandomCov2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSifre.Text = RastgeleUret();
        }

        private void BtnYarat_Click(object sender, EventArgs e)
        {
            txtSifre.Text = RastgeleUret();
        }

        private void BtnMD5_Click(object sender, EventArgs e)
        {
            txtMD5.Text = MD5Olustur(txtSifre.Text);
        }

        private void BtnHafiza_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSifre.Text.Trim()))
            {
                Clipboard.SetText(txtSifre.Text);
                lblUyari.Text = "Şifre Başarıyla Kopyalandı !";
                lblUyari.ForeColor = Color.Green;
            }
            else
            {
                lblUyari.Text = "Şifre alanı boştur. Şifre üretip tekrar deneyin !";
                lblUyari.ForeColor = Color.Brown;
            }
        }

        private void BtnTut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMD5.Text.Trim()))
            {
                Clipboard.SetText(txtMD5.Text);
                lblUyari.Text = "MD5 Başarıyla Kopyalandı !";
                lblUyari.ForeColor = Color.Green;
            }
            else
            {
                lblUyari.Text = "MD5 alanı boştur. MD5 üretip tekrar deneyin !";
                lblUyari.ForeColor = Color.Brown;
            }
        }

        public string MD5Olustur(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        string RastgeleUret()
        {
            int toplam = Convert.ToInt32(txtKacHarf.Text);
            Random rnd = new System.Random(unchecked((int)DateTime.Now.Ticks));
            string ret = "";
            for (int i = 0; i < toplam; i++)
            {
                if (chkSert.Checked)
                    ret += randZorLetter(rnd);
                else
                    ret += randLetter(rnd);
            }
            return ret;
        }
        const string letters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lettersZor = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!#*+-/@[]_";
        const string lettersMDZor = "0123456789abcçdefghıijklmnoöpqrsştuüvwxyzABCÇDEFGHIİJKLMNOÖPQRSŞTUÜVWXYZ!#*+-/@[]_";
        char randLetter(Random rnd)
        {
            return letters[rnd.Next(letters.Length)];
        }

        char randZorLetter(Random rnd)
        {
            return lettersZor[rnd.Next(lettersZor.Length)];
        }

        private void TxtKacHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
