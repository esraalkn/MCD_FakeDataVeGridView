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
    public partial class Form1 : Form
    {
        database db = new database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string isim = FakeData.NameData.GetFemaleFirstName();
            //string soyisim = FakeData.NameData.GetFemaleFirstName();
            //MessageBox.Show(isim + " " + soyisim, "Fake Data İnceleme", MessageBoxButtons.OK);

            
            List<Musteri> musteriliste = db.Musterilistele();

            // //1.Data bize lazım ama ekran üzerinde göstermek istemiyoruz bu gibi durumlarda columns koleksiyonu içinde ilgili kolonun id değeri veya tip prop adı verilerek Visible prop false edilmesi yeterlidir.
            // dgwMusteriListe.DataSource = musteriListe;
            // dgwMusteriListe.Columns[0].Visible = false;
            // dgwMusteriListe.Columns["id"].Visible = true;


            // //Data Grid View içerisinde bulunan kolonların isimlerini değiştirmek...

            // dgwMusteriListe.Columns[0].HeaderText = "Müşteri ID";
            // dgwMusteriListe.Columns[1].HeaderText = "Müşteri İsim";
            // dgwMusteriListe.Columns[2].HeaderText = "Müşteri Soyisim";
            ////dgwMusteriListe.Columns[2].HeaderText = 500;
            // dgwMusteriListe.Columns[3].HeaderText = "Müşteri Tam Adi";

            //2.Data bize lazım değil hiç bir şekilde ekranda görünmesini veya kullanmak istemiyoruz .

            var dgwListe = from I in musteriliste
                           select new
                           {
                               id = I.id,
                               Isim = I.isim,
                               Soyisim = I.soyisim,
                               Tamisim = I.tamAdi
                           };
            dgwMusteriListe.DataSource = dgwListe.ToList();
                           


        }

        

        private void dgwMusteriListe_DoubleClick(object sender, EventArgs e)
        {
            int musteriID =(int) dgwMusteriListe[0, dgwMusteriListe.CurrentCell.RowIndex].Value;// Ssçili olan satırdaki(kayıttaki) müşterinin idsini dönderir.

            
            Musteri bulunanMusteri = db.Musterilistele().FindAll(i => i.id == musteriID).FirstOrDefault();

            PopupMesaj popup = new PopupMesaj(bulunanMusteri);
            popup.Show();

        }
    }
}
