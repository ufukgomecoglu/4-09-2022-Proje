using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtFormu
{
    public partial class KullaniciGiris : Form
    {
        bool GırısYap = false;
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.ShowDialog();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            bool key = true;
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            foreach (string item in ProgramKullanicilariDosyalariListele())
            {
                string kAB= kullaniciAdi.ToUpper()+".txt";
                if (kAB!=item)
                {
                    key = false;
                    textBoxKullaniciAdi.Text = "";
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (key==true)
            {
                StreamReader streamReader = new StreamReader(@"C:\KayitForm\ProgramKullanıcıları/" + kullaniciAdi.ToUpper() + ".txt");//Dosya okuma
                string kullaniciAdi1 = streamReader.ReadLine();
                string eposta = streamReader.ReadLine();
                string sifre = streamReader.ReadLine();
                if (kullaniciAdi1 == $"Kullanıcı Adı={textBoxKullaniciAdi.Text}" && sifre ==$"Şifre={textBoxSifre.Text}")
                {
                    GırısYap = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şİfre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSifremiUnuttum_Click(object sender, EventArgs e)
        {

        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GırısYap==false)
            {
                Application.Exit();
            }
        }
        private List<string> ProgramKullanicilariDosyalariListele()
        {
            List<string> kullaniciAdi = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\KayitForm\ProgramKullanıcıları");
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach (FileInfo file in fileInfo)
            {
                kullaniciAdi.Add($"{file.Name}");
            }
            return kullaniciAdi;
        }
    }
}
