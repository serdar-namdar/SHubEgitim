namespace Konu01Degiskenler
{
    internal class Program // Sınıf
    {
        static void Main(string[] args) // Metot
        {
            Console.WriteLine("Hello, World!"); // Komut ekrana yazı yazdırır.
            Console.WriteLine();
            Console.WriteLine("Merhaba, Dünya!");
            
            Console.Write("Console."); // gönderilen değerleri yan yana yazar.
            Console.Write(".Write");

            //Console.Read(); // ekrandan girilecek 1 karakteri okur.
           // Console.ReadLine(); // ekrandan girilecek 1 satırı okur.

            //C# ta değişken tanımlama
            //tamsayı veri tipleri
            byte plaka_kodu; // 0-255 arası değer alır. 1 byte yer kaplar.
            plaka_kodu = 34; // Değişkene değer atama işlemi
            Console.WriteLine(plaka_kodu); // Değişkeni ekrana yazdırma işlemi

            // Değişkenler tiplerine göre bellekte stack ve heap denilen 2 ayrı bölümde saklanır. Değer tipli değişkenler stack alanında
            // saklanırken referans tipli değişkenler heap bölümünde saklanır.

            byte birSayi, birSayiDaha; // bir tiple birden fazla değişken oluşturma
            birSayi = 0;
            birSayiDaha = 255;
            Console.WriteLine(birSayi);
            Console.WriteLine(birSayiDaha);

            sbyte sbyteTuru = 127; // -128 ile 127 arası değer alır. 1 byte yer kaplar.
            short kisa= 32767; // -32.768 ile 32.767 arası değer alır. 2 byte yer kaplar.
            ushort birazUzun = 65535; // 0 ile 65.535 arası değer alır. 2 byte yer kaplar.
            int tamsayi = 1234567890; // -2.147.483.648 ile 2.147.483.647 arası değer alır. 4 byte yer kaplar.
            uint uzunTamsayi = 4294967295; // 0 ile 4.294.967.295 arası değer alır. 4 byte yer kaplar.
            long dahaUzunTamsayi = 123456789000000; // -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807 arası değer alır. 8 byte yer kaplar.
            ulong enUzunTamsayi = 12345678900000000000; // 0 ile 18.446.744.073.709.551.615 arası değer alır. 8 byte yer kaplar.

            // Kesirli Sayı Değişken Tipleri
            float kesirliSayi = 4.5f; // 4 byte yer
            double kesirliSayi2 = 4.5; // 8 byte yer kaplar. daha kesirli

            // Decimal veri tipi
            decimal UrunFiyati = 9999; // 12 byte, duyarlı basamak 28-29, para birimleri için kullanılır.

            // Char veri tipi
            char karakter = 'ç'; // 2 byte yer kaplar. Tek karakter tutar.

            // String veri tipi
            string degisken; //klavyeden girilecek karakterlerden oluşan bir metin tutar. 2 byte yer kaplar.
            string degisken1, degisken2;
            string metin = "string veri tipinde tüm karakterleri kullanabiliyoruz."; // çift tırnak içinde tanımlanır.
            Console.WriteLine(metin); // debug mod-debugging hata ayıklama - satırın solundaki şeride tıklayıp kırmızı nokta oluşturuyoruz bunun adı breakpoint

            // Boolean veri tipi
            // geriye true/false dönen veri tipidir. değer alır. 1 byte yer kaplar.
            bool islemSonuc = false;
            // işlem başarılıysa eğer
            islemSonuc = true;

            byte? kilo = null; // eğer bir değişkene başlangıç değeri olarak null vermek istersek veri tipinin yanına ? koyarız
            kilo = 66; 

            // * Bir ürünün satışta olup olmadığı bilgisini tutacak değişken 
            bool? isSatistami = null; // ürünün satış durumu başlangıçta bilinmiyor
            // kontrol ettik 
            isSatistami = true; // ürün satışta

            // var ile değişken oluşturma 
            var birdegisken = 18;  // var ile oluşturulan değişkenlerde değişkenin veri tipi c# tarafından değişkene atanan değere göre otomatik algılanır
            var strmetin = "var kullanırsak değişkene değer atamak zorundayız";
            var sonuc = false;


            Console.WriteLine(birdegisken.GetType()); // GetType() metodu değişkenin veri tipini verir
            Console.WriteLine(strmetin.GetType());
            Console.WriteLine(sonuc.GetType());

            sonuc = true;
            // sonuc = 1; var ile oluşturulan bir değişkenin türü sonradan değiştirilemez,ancak içindeki değer değiştirilebilir

            Console.WriteLine();
            Console.WriteLine("Object veri tipi");
            object nesne = "bu bir nesnedir"; // bu değişken türüne her türlü veri atanabilir
            Console.WriteLine(nesne + "-Tipi:" + nesne.GetType());
            nesne = 18; // object ile tanımlanan nesne değiştirilebilir
            Console.WriteLine(nesne + "-Tipi:" + nesne.GetType());

            object a = 10;   // tamsayı
            object b = 'k';  // karakter
            object c = "metin";  // string
            object d = 12.9f; // float

            Console.WriteLine();
            // c# ta sabit tanımlama
            Console.WriteLine("c# ta sabit tanımlama");
            const int kdvOrani = 18; // sabitleri const olarak tanımlayıp program içersinde kullanabiliriz,sabitlerin değeri tanımlandığı yerde verilir sonradan değiştirilemez
            const int iskonto = 25;
            // kdvOrani = 20;

            Console.WriteLine("kdvOrani:");
            Console.WriteLine(kdvOrani);

            // Ekrandan değer alma
            Console.WriteLine("Ekrandan değer alma");
            var deger = Console.ReadLine(); // bu komut ekrandan girilen 1 satırlık veriyi yakalamamızı sağlar
            Console.WriteLine("\nGirdiğiniz Değer:");
            Console.Write(deger);
            Console.WriteLine("\nGirdiğiniz Değer: " + deger);
            Console.WriteLine("\nGirdiğiniz Değer 2: " + deger);
        }
    }
}