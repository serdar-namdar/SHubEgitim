namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum
    {
        private string BolumAdi; // dışardan erişime kapalı değişkenimiz
        // Accessor - Getter
        public string GetBolumAdi()
        {
            return BolumAdi;
        } // geriye private BolumAdi değişkenini döndüren metot
        public void SetBolumAdi(string istenenEgitim) // dışarıdan erişime açık değişkenimiz
        {
            if (istenenEgitim == "Grafik Tasarım") // eğer parametre olarak gelen bolumAdi null veya boş değilse
            {
                Console.WriteLine("Kurumumuzda " + istenenEgitim + " Eğitimi verilmemektedir"); // private BolumAdi değişkenine parametre olarak
                                                                                               // gelen bolumAdı değerini ata
            }
            else
            {
                BolumAdi = istenenEgitim;  // mutator - setter seçilen eğitim onaylandı  
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13KapsullemeEncapsulation");
            Bolum bolum = new Bolum(); // Bolum sınıfından bir nesne oluştur   
            Console.WriteLine("Eğitim almak istediğiniz bölümü giriniz");
            // metot ile kapsülleme
            Console.WriteLine("Metot ile kapsülleme");
            var bolumAdi = Console.ReadLine(); // kullanıcıdan eğitim almak istediği bölümü al
            bolum.SetBolumAdi(bolumAdi); // set metodu çalışır
            Console.WriteLine("Seçtiğiniz bölüm: " + bolum.GetBolumAdi());

            // proerty ile kapsülleme
            Console.WriteLine();
            Console.WriteLine("Property ile kapsülleme");
            Fakulte fakulte = new Fakulte();
            fakulte.Bolum = bolumAdi; // set metodu çalışır
            Console.WriteLine("Seçtiğiniz bölüm: " + fakulte.Bolum); // get metodu çalışır

        }
    }
    // Propety ile kapsülleme
    public class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; }
            set
            {               
                if (value == "Grafik Tasarım")
                {
                    Console.WriteLine("Kurumumuzda " + value + "Eğitimi verilmemektedir");
                }
                else
                {
                    bolum = value;
                }
            }
        }

    }
}
