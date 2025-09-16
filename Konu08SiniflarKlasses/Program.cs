namespace Konu08SiniflarClasses
{
    internal class Ev // Sınıf tanımlama
    {
        internal string sokakAdi; // Sınıf üyesi (field)
        internal int kapiNo; // Sınıf üyesi (field)

    }
    public class Deneme
    {
        public string UrunAdı = "public öğeye herkez erişebilir";
        protected class test // ait olduğu sınıftan ve o sınıftan türetülen sınıflardan erişebilir
        {
            string UrunAdi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08SiniflarClasses");
            /*
             * Erişim belirteçleri 4 ana sınıfa ayrılır.
             * public : Her yerden erişim, kısıt yok
             * protected : Sadece ait olduğu  sınıf içinden ve türetilen sınıflardan erişim
             * internal : Etkin projeye ait sınıflardan erişilebilir, onların doışından erişilemez
             * private : Sadece ait olduğu sınıf içinden erişilebilir (bulunduğu sınıflardan erişilebilir sadece)
             */

            #region Örnek1
            Ev ilkEv = new Ev(); // Soyut bir yapı olan ev sınıfından somut bir nesne olan ilkEv nesnesi oluşturuldu
            ilkEv.sokakAdi = "Çiçek sk";
            ilkEv.kapiNo = 10;
            Console.WriteLine("İlkEv sokak adı: " + ilkEv.sokakAdi);
            Console.WriteLine("İlkEv kapi No: " + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new();
            yazlikEv.sokakAdi = "Deniz sk";
            yazlikEv.kapiNo = 10;
            Console.WriteLine("YazlikEv sokak adı: " + yazlikEv.sokakAdi);
            Console.WriteLine("İlkEv kapi No: " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                kapiNo = 10,
                sokakAdi = "Mehmet Ağa Sokak"
            };
            Console.WriteLine("koyEvi sokak adı: " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapi No: " + koyEvi.kapiNo);
            #endregion
            #region Örnek 2
            Kullanici kullanici = new()
            {
                Adi = "Serdar",
                Soyadi = "Namdar",
                Id = 1,
                KullaniciAdi = "serdarn",
                Sifre = "12345"
            };
            Console.WriteLine("Kullanıcı Adı:");
            var KullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre: ");
            var Sifre = Console.ReadLine();

            if (KullaniciAdi == kullanici.KullaniciAdi && Sifre == kullanici.Sifre)
            {

                Console.WriteLine($"Hoşgeldin {kullanici.Adi} {kullanici.Soyadi}");
            }
            else
                Console.WriteLine("Giriş Başarısız!");
            #endregion
            #region Örnek 3
            Araba araba = new()
            {
                Marka = "TOGG", Model = "T10X", KasaTipi = "SUV", VitesTipi = "Otomatik",
            };
            Araba araba2 = new()
            {
                Marka = "TOGG", Model = "T10F", KasaTipi = "Sedan", VitesTipi = "Otomatik",
            };
            #endregion
            #region Örnek 4
            Kategori kategori = new()
            {
                Id = 1,
                KategoriAdi = "Elektronik",
            };
            Kategori kategori2 = new()
            {
                Id = 2,
                KategoriAdi = "Bilgisayar",
            };
            Kategori kategori3 = new()
            {
                Id = 3,
                KategoriAdi = "Telefon",
            };
            Console.WriteLine($"Anasayfa Hakkımızda: {kategori.KategoriAdi} {kategori2.KategoriAdi} {kategori3.KategoriAdi} İletişim");
            #endregion
            #region Örnek 5
            SiniftaMetotKullanimi metotKullanimi = new();
            var sonuc = metotKullanimi.LoginKontrol("admin", "123456");
            if (sonuc) // if de bu şekilde kullanırsak sonuç == true yu kontrol eder
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
                Console.WriteLine("Giriş Başarısız");
            var toplamasonucu = metotKullanimi.ToplamaYap(10, 8);
            Console.WriteLine("Toplama sonucu: " + toplamasonucu);

            Console.WriteLine("Statik Degisken: " + SiniftaMetotKullanimi.StatikDegisken); // statik değişkeni sınıfınadı.değişkenadı  şeklinde direk kullanabiliyoruz.
            Console.WriteLine("Dinamik Degisken: " + metotKullanimi.DinamikDegisken); // private olduğu için erişilemez
            #endregion

            User user = new()
            {
                Id = 1, CreateDate = DateTime.Now, Email = "admin@user.co", Password = "123456"
            };
        
            var KullaniciGirisSonuc = user.KullaniciGiris(user.Email, user.Password);

            Console.WriteLine("KullanıcıGirişSonuç: " + KullaniciGirisSonuc);
        }
    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
}