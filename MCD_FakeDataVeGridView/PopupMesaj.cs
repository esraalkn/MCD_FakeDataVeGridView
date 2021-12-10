using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_FakeDataVeGridView
{
    public partial class PopupMesaj : Form
    {
        Musteri musteriData;
        public PopupMesaj(Musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void PopupMesaj_Load(object sender, EventArgs e)
        {
            txtIsim.Text = musteriData.isim;
            txtSoyisim.Text = musteriData.soyisim;
            txtTamIsim.Text = musteriData.tamAdi;
            TXTeMAİL.Text = musteriData.emailAdres;
            txtILıLCE.Text = $"{musteriData.il} / {musteriData.ilce}";
            TXTaDRES.Text = musteriData.adres;
            txtTelefon.Text = musteriData.telNumara;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
