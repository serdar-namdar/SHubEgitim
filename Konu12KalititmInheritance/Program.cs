namespace Konu12KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı.");
        }      
    }
    class Otomobil : Arac // : araç dediğimizde araç sınıfındaki içerik otomobil sınıfına miras kalır.(kullanılır)
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class Tren : Arac
    {
        public string Model { get; set; }
        public int VagonSayisi { get; set; }
    }
    class Gemi : Arac
    {
        public int Uzunluk { get; set; }
        public int KamaraSayisi { get; set; }
    }
    internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Konu12KalitimInheritance");

                Arac arac = new Arac();
                arac.AracTuru = string.Empty;
                arac.KornaCal();

                Otomobil otomobil = new Otomobil();
                otomobil.AracTuru = "Otomobil"; // normalde otobobil classında araç türü yok ama araç classından miras aldığı için kullanabiliyor.
                otomobil.Marka = "Togg";
                otomobil.Model = "T10X";
                Console.WriteLine("otomobil.AracTuru :" + otomobil.AracTuru);
                otomobil.KornaCal(); // normalde otobobil classında KornaCal() yok ama araç classından miras aldığı için kullanabiliyor.
                
                Console.WriteLine();

                Kategori kategori = new()
                {
                    Id = 1, Name = "Elektronik", UstMenudeGoster = true
                };
                if (kategori.UstMenudeGoster)
                {
                Console.WriteLine(kategori.Name);
                }
                Console.WriteLine();
                Urun urun = new()
                {
                    Id = 1, Name = "Klavye", Fiyat = 399, Kdv = 20
                };
                Console.WriteLine("Ürün Bilgileri: ");
                Console.WriteLine("Ürün Adı: " + urun.Name);
                Console.WriteLine("Ürün Fiyat: " + urun.Fiyat);

                Console.WriteLine();

                Cizici[] birCizici = new Cizici[4];
                birCizici[0] = new DogruCiz();
                birCizici[1] = new DaireCiz();
                birCizici[2] = new KareCiz();
                birCizici[3] = new Cizici();

                foreach (var item in birCizici)
                {
                    item.Ciz(); // her  nesneye içindeki çiz metodunu çalıştırır
                }

            }
        }
        // Polimorfizm-Çokbiçimlilik
        public class Cizici
        {
            public virtual void Ciz() // virtual keywordu ile bu metodu override -ezilebilir hale getiriyoruz
            {
                Console.WriteLine("Cizici");
            }
        }
        public class DogruCiz : Cizici
        {
            public override void Ciz() // override boşluk dediğimizde ezilebilir metodlar gelir
            {
                Console.WriteLine("Düz çizgi");
            }
        }
            public class DaireCiz : Cizici
        {
            public override void Ciz() // override boşluk dediğimizde ezilebilir metodlar gelir
            {
                Console.WriteLine("Daire çizgi");
            }
        }
        public class KareCiz : Cizici
        {
            public override void Ciz() // override boşluk dediğimizde ezilebilir metodlar gelir
            {
                Console.WriteLine("Kare çizgi");
            }
        }
}




