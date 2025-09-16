namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu07Donguler");

            Console.WriteLine("1-For Döngüsü"); // i değişkenini oluştur ve 0 değerini ata; i 5 den küçük olduğu sürece dön , her döngü sonunda i değerini 1 artır
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i değişkeninin değri: {0}", i);
            }
            Console.WriteLine();

            Console.WriteLine("2-While Döngüsü");
            int j = 0; // dışarıda bir j değişkeni tanımlıyoruz ve 0 değerini ata
            while (j < 5) // j 5 den küçük olduğu sürece dön
            {
                Console.WriteLine("j değişkeninin değri: {0}", j); // j değişkeninin (toplamın) değerini ekrana yazdır
                j++; // her döngü sonunda j değerini 1 artır böylece sonsuz döngüye girmemiş oluruz
            }
            Console.WriteLine();

            Console.WriteLine("3- Do While Döngüsü");

            int toplam = 7; // dışarıda bir toplam değişkeni tanımlıyoruz 
            do
            {
                Console.WriteLine("toplamın değri: ", toplam); // toplam değişkeninin (toplamın) değerini ekrana yazdır
            } while (toplam < 5); // toplam 5 den küçük olduğu sürece dön

            Console.WriteLine();

            Console.WriteLine("4- Foreach Döngüsü");
            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu" }; // bir string dizisi tanımlıyoruz 
            Console.WriteLine("Kategoriler:");
            foreach (var item in kategoriler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // iç içe döngü kullanımı
            string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" };
            foreach (var kategori in kategoriler)
            {
                Console.WriteLine(kategori); // kategori adını yazdır
                foreach (var urun in urunler) // ürünler dizisinde dönmeye başla
                {
                    Console.WriteLine(urun);
                }
            }
            Console.WriteLine();

            Console.WriteLine("iç içe for döngüsü");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i : " + i);  
                for (int k = 0; k < 3; k++)
                {
                   
                    {
                        Console.WriteLine($"k nın değeri : {k}");
                    }
                }   
            }
        }

    }
}

