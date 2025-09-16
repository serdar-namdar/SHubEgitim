namespace Konu09StructYapilar
{
    public struct Yapi
    {
        // public string ad= "ali"; // struct yapılarında class dan farklı olarak öğelere başlangıç değeri atanmaz
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu09StructYapilar");
            Yapi ilkyapi = new Yapi();
            ilkyapi.metin = "yapı metni";
            ilkyapi.sayi = 18;
            ilkyapi.Metot();
            Console.WriteLine(ilkyapi.metin);
        }
    }
}
