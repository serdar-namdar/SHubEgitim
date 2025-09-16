
namespace Konu08SiniflarClasses
{
    public class urun
    {
        // class içinde değişken-field kullanımı
        internal int id;
        internal string Adi;
        internal decimal Fiyati;
        // class içinde property kullanımı
        public string UrunAciklamasi { get; set; } // property oluşturmanın kısa yolu prop tab tab a bas
        public int Markasi { get; set; }
        public bool Durum { get; set; }
        public int Kategoriİd { get; set; }

        public Kategori? Kategori { get; set; } // navigation property, ürün ve kategori arasında ilişki kurar
    }
}
