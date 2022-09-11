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
    public partial class Profilim : Form
    {
        public Profilim()
        {
            InitializeComponent();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            
            
            
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

        private void Profilim_Load(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = ProgramKullanici.KullaniciAdi;
            StreamReader streamReader = new StreamReader(@"C:\KayitForm\ProgramKullanıcıları/" + textBoxKullaniciAdi.Text.ToUpper() + ".txt");//Dosya okuma
            string kullaniciAdi1 = streamReader.ReadLine();
            string eposta = streamReader.ReadLine();
            string sifre = streamReader.ReadLine();
            textBoxEposta.Text = eposta;
        }
        private string GetData(string metin)
        {
            string arananMetin = "";
            
            return arananMetin;
        }
    }
}
