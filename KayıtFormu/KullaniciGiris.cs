using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtFormu
{
    public partial class KullaniciGiris : Form
    {
        bool key = false;
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

        }

        private void buttonSifremiUnuttum_Click(object sender, EventArgs e)
        {

        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (key==false)
            {
                Application.Exit();
            }
        }
    }
}
