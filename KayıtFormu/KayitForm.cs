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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            InitializeComponent();
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\KayitForm");//klasör nesnesi
            if (directoryInfo.Exists==false)//Klasör var mı?
            {
                directoryInfo.Create(); //Klasör oluşturur.
            }
        }

        private void TSMI_Profilim_Click(object sender, EventArgs e)
        {
            Form[] AcikFormlar = this.MdiChildren;
            bool acikmi = false;
            foreach (Form item in AcikFormlar)
            {
                if (item.GetType() == typeof(Profilim))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if (acikmi == false)
            {
                Profilim frm = new Profilim();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
