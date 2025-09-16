namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10StringSinifi");
            string degisken;
            char karakter = 'a';
            string metinlericin = "yanyana karakterlerden oluşan metinler için";
            // Ornek1();
            // StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birsayi = "123456789";
            System.String birTarih = "02.05.2021";
            string kod = "//5456dfgd\n";//buradaki \n kodu enter görevi görür ve kendinden sonra gelecek olan metni bir alt satıra kaydırır
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            string s = "Barış Manço";
            Console.WriteLine("For Döngüsü");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]); //s değişkeninin i. indexteki değeri 
            }
            Console.WriteLine("Foreach Döngüsü");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

        }
        static void StringMetotlari()
        {
            string metin = "Stringin birçok Metodu vardır";
            Console.WriteLine("metin in karakter sayısı(metin.length) : " + metin.Length); //metin değişkeninin karakter sayısını verir

            var klon = metin.Clone(); //metin değişkeninin bir klonunu oluşturur klon değişkenine atar
            Console.WriteLine("metin klonu : " + klon);

            Console.WriteLine();

            metin = "My Name is Ali";
            Console.WriteLine(metin + "EndsWith i: " + metin.EndsWith("i"));
            Console.WriteLine(metin + "EndsWith r: " + metin.StartsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + "StartsWith S: " + metin.StartsWith("S"));
            Console.WriteLine(metin + "StartsWith m: " + metin.StartsWith("m"));
            Console.WriteLine(metin + "StartsWith M: " + metin.StartsWith("M"));

            Console.WriteLine(); 

            Console.WriteLine(metin + " IndexOf name: " + metin.IndexOf("name"));
            Console.WriteLine(metin + " İndexOf Name: " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " LastIndexOf i: " + metin.LastIndexOf("i"));

            Console.WriteLine();

            Console.WriteLine(metin + "Insert 0: " + metin.Insert(0, "Merhaba :")); // metin değeri değişmiyor sadece başına merhaba ekleniyor.
            Console.WriteLine(metin);

            Console.WriteLine();
            Console.WriteLine(metin + " Substring 2: " + metin.Substring(2));
            Console.WriteLine(metin + " Substring 2, 5: " + metin.Substring(2, 5));
            
            Console.WriteLine();

            Console.WriteLine(metin + " ToLower: " + metin.ToLower());
            Console.WriteLine(metin + " ToUpper: " + metin.ToUpper());
            Console.WriteLine(metin + "metin.ToLower().Replace: " + metin.ToLower().Replace(" ", "-"));
            Console.WriteLine(metin + "Remove 2: " + metin.Remove(2));
            Console.WriteLine(metin + " Remove 2, 5: " + metin.Remove(2, 5));

        }

        static void SplitMetodu()
        {
            string sehirler = "İstanbul,Ankara,İzmir,Bursa,Adana,Antalya,Çankırı";
            string[] sehirlerArray = sehirler.Split(','); //verilen karaktere göre metni parçalar
            Console.WriteLine("4. Şehir : " + sehirlerArray[3]);
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir: " + item);
            }
            Console.WriteLine();
        }
    }
}



