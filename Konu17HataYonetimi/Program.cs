namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu17HataYonetimi");
            Console.WriteLine();
            Console.WriteLine("Kdv hesaplamak için fiyat giriniz : ");
            var fiyat = Console.ReadLine();
            // KdvHesapla(double.Parse(fiyat));
            try // try yaz iki kere taba bas
            {
                KdvHesapla(double.Parse(fiyat)); // try bloğunda bulunan kodların çalıştırılması denenir. bir hata olursa
            }
            catch (Exception hata) // catch bloğunda oluşan hata yakalanarak işlem yapılır
            {
                Console.WriteLine(" Hata oluştu, lütfen sadece sayısal değer giriniz");
                // throw; // throw hata fırlatır
                // oluşan hatayı veritabanına kaydederek loglayabilir ve kendimize mail atarak haber vermesini sağlayabiliriz.
               Console.WriteLine(hata.Message); // hata mesajını görmek için
            }
            finally
            {
                Console.WriteLine("try catch bloğunda her seferinde çalışmasını istediğimiz bir işlem varsa bu blokta çalıştırabiliriz. Kullanımı zorunlu değildir.");
                Console.WriteLine("Kdv hesaplamak için fiyat giriniz : ");
                var fiyat2 = Console.ReadLine();
                KdvHesapla(double.Parse(fiyat2));
            }
        }
        static void KdvHesapla(double fiyat)
        { Console.WriteLine("Fiyat : " + fiyat);
            Console.WriteLine("Kdv : " + (fiyat* 0.2));
            Console.WriteLine("Kdv dahil toplam fiyat : " + (fiyat + (fiyat * 0.2)));
        }
    }
}
