namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu06Diziler");
            // dizi oluşturma
            int[] sayi;
            int[] ogrenciler = new int[6]; // ogrenciler isminde int veri tipinde 6 elemandan oluşan bir dizi oluşturduk. dizi boyutu atrmaz ve azalmaz

            // dizilere indis denilen yapı vardır ve indisler 0 dan başlar
            ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 500; // dizi değerlerleri aynı olabilir
            // dizideki değere ulaşma
            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            ogrenciler[5] = 550; // dizideki eleman değeri değiştirilebilir
            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            //  ogrenciler[6] = 600; // dizinin boyutunu aştığımız için hata verir dizi dışı olmaz yani

            Console.WriteLine();
            
            string[] isimler = new string[5];
            isimler[0] = "Alp";
            isimler[1] = "Ali";
            isimler[2] = "Bekri";
            isimler[3] = "Serdar";
            isimler[4] = "Deniz";

            Console.WriteLine("isimler[4]: " + isimler[4]);

            Console.WriteLine();

            int[] ogrenciler2 = { 100, 200, 300, 400, 500 }; // dizi tanımlama ve değer atama aynı satırda
            Console.WriteLine("Seçilen öğrenci no: " + ogrenciler2[3]);
            ogrenciler2[3] = 550;
            Console.WriteLine("Seçilen öğrenci no: " + ogrenciler2[3]);

            Console.WriteLine();

            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu", "Beyaz Eşya", "Kitap" }; // Diziye eklenecek kayıt sayısı belirsizse bu şekilde de tanımlanabilir
            Console.WriteLine("kategoriler 1: " + kategoriler[1]);
            kategoriler[1] = "Aksesuar";
            Console.WriteLine("kategoriler 1: " + kategoriler[1]);

            Console.WriteLine();

            string[] urunler = { "Ürün 1", "Ürün 2", "Ürün3" };
            Console.WriteLine(urunler[1]);


        }
    }
}
