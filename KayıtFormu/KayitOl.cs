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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\KayitForm\ProgramKullanıcıları");//klasör nesnesi
            if (directoryInfo.Exists == false)//Klasör var mı?
            {
                directoryInfo.Create(); //Klasör oluşturur.
            }
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            bool key = true;
            string ad = textBoxKullaniciAdi.Text;
            string eposta = textBoxEposta.Text;
            string sifre = textBoxSifre.Text;
            string sifretekrar = textBoxSifreTekrar.Text;
            foreach (string item in ProgramKullanicilariDosyalariListele())
            {
                string dosyaAdi = ad.ToUpper() + ".txt";
                if (dosyaAdi!=item)
                {
                    key = true;
                }
                else
                {
                    key=false;
                    MessageBox.Show("Kullanıcı Adı Mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxKullaniciAdi.Text = "";
                }
            }
            if (sifre == sifretekrar)
            {
                key = true;
            }
            else
            {
                key = false;
                MessageBox.Show("Şifre ve Şifre Tekrar aynı olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSifre.Text = "";
                textBoxSifreTekrar.Text = "";
            }
            if (key == true)
            {
                StreamWriter streamWriter = new StreamWriter(@"C:\KayitForm\ProgramKullanıcıları/" + ad.ToUpper() + ".txt"); //Dosya oluşturma
                streamWriter.WriteLine("Kullanıcı Adı=" + ad);
                streamWriter.WriteLine("E-posta=" + eposta);
                streamWriter.WriteLine("Şifre=" + sifre);
                streamWriter.Close();
                Temizle();
                MessageBox.Show("Kayıt başarılı bir şekilde tamamlandı.", "Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Sırasında Bir Hata Oluştu.", "Kayıt Başarısız");
            }
        }
        private void Temizle()
        {
            textBoxKullaniciAdi.Text = textBoxEposta.Text = textBoxSifre.Text = textBoxSifreTekrar.Text = "";
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
