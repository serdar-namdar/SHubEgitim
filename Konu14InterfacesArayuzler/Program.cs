namespace Konu14InterfacesArayuzler
{
    public interface OrnekArayuz  // class yerine interface yazıyoruz
    {
        public int Id { get; set; }  
    }
    interface IDemo
    {
        void Goster(); // interfacede  metot imzası tanımlama
    }
    interface icerebilecekleri : IDemo // interface başka bir interface i içerebilir
    {
        public int sayi1 { get; set; }
        int sayi { get; set; }
        public static int sayi2 { get; set; } 
        void Topla();
        int ToplamaYap();  
    }
    class Arayuzkullanimi : icerebilecekleri
    {
        public int sayi1 { get; set; }
        public int sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine("void göster metodu");
        }

        public void Topla()
        {
            Console.WriteLine("void topla metodu");
        }
        public int ToplamaYap()
        {
            return sayi + sayi1;
        }
        public int Id { get; set; }
    }
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Konu14InterfacesArayuzler");
                Arayuzkullanimi arayuzkullanimi = new Arayuzkullanimi();
                arayuzkullanimi.sayi = 5;
                arayuzkullanimi.sayi1 = 10;
                arayuzkullanimi.Goster();
                arayuzkullanimi.Topla();
                Console.WriteLine("Toplama sonucu: " + arayuzkullanimi.ToplamaYap());
                
                Kategori kategori = new()
                {
                    Id = 1,
                    KategoriAdi = "Bilgisayar",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
                };
                Console.WriteLine($"Kategori Id: {kategori.Id}, CreateDate:{kategori.CreateDate}, UpdateDate: {kategori.UpdateDate}"); 
            }
    }
}

    
