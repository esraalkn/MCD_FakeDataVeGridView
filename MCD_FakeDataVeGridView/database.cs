using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_FakeDataVeGridView
{
    public class database
    {
        public List<Musteri> musteriler = new List<Musteri>();

        public database()
        {

        }

        public List<Musteri> Musterilistele()
        {
            for (int i = 1; i < 1001; i++)
            {
                Musteri temp = new Musteri();
                temp.id = 1000 + i;
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.tamAdi = $"{temp.isim} {temp.soyisim}";
                temp.emailAdres = FakeData.NetworkData.GetEmail(temp.isim, temp.soyisim);
                temp.telNumara = FakeData.PhoneNumberData.GetPhoneNumber();
                temp.il = FakeData.PlaceData.GetCity();
                temp.ilce = FakeData.PlaceData.GetCountry();
                temp.adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(temp);

            }

            return musteriler;
        }

       
    }
}
