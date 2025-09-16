namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu05Metotlar");
            Console.WriteLine();
            ToplamaYap(); // Methodları çağırmazsak çalışmazlar
            ToplamaYap(18, 25); // Method çağırma
            int sonuc = ToplamaYap(10, 20, 30);
            Console.WriteLine("Hesaplanmış Fiyat: " + sonuc);
           
            Console.WriteLine();
            Console.WriteLine("Mail Adresiniz: ");
            var email = Console.ReadLine();

            var mailGonderildimi = MailGonder(email);
            if (mailGonderildimi == true)
            {
                Console.WriteLine("Mail gönderme işlemi başarılı");
            }
            else
            {
                Console.WriteLine("Mail gönderme işlemi başarısız");
            }
        }
        static void ToplamaYap() // Method   tanımlama
        {
            // void olan metotlar geriye değer döndürmeyen metotlardır
            // Aynı isimde metotlar farklı parametrelerle kullanılırsa buna overloading-aşırı yükleme denir.
            //Metot kullanımında kullanılan parametreler(sayi1, sayi2) metodun kullanıldığı yerde metoda gönderilmek zorundadır, aksi halde program hata verir
            Console.WriteLine(10 + 8);
        }
        static void ToplamaYap(int sayi1, int sayi2) // Methodlar dışardan parametre alarak  çalışabilir
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        static int ToplamaYap(int sayi1, int sayi2, int sayi3) // Methodlar dışardan parametre alarak  çalışabilir
        {
            return sayi1 + sayi2 + sayi3; // int olan metotlar geriye değer döndüren metotlardır return ile değer döndürür.
        }
        static bool MailGonder(string MailAdresi) 
        {
          if (!string.IsNullOrWhiteSpace(MailAdresi)) // eğer mail adresi değişkenin değeri boş değilse 
            {
                //Mail gönderme kodlarıyazılır buraya
                return true; // mail gönderme başarılı ise true değerini gönder
            }
            return false; // mail gönderme başarısız ise değerini gönder  
        }

    }
}
    

