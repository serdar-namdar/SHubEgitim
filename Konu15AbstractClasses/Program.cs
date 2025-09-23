namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu15AbstractClasses");
            // Database database = new Database(); // Abstract classlardan nesne üretilemez
            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();
            database1.Get();

            Database database2 = new MySql();
            database2.Add();
            database2.Delete();
            database2.Get();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Add metodu çalıştı ekleme yapıldı");
        }
        public abstract void Delete(); // crud
        public abstract void Update(); // crud
        public abstract void Get();  // crud

    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Sql Server Delete metodu çalıştı Silme Yapıldı");
        }
        public override void Get()
        { Console.WriteLine("Sql Server get metodu çalıştı Listeleme Yapıldı"); }
        public override void Update()
        {
            Console.WriteLine("Sql Server Update metodu çalıştı Güncelleme Yapıldı");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle Server Delete metodu çalıştı Silme Yapıldı");
        }
        public override void Get()
        {
            Console.WriteLine("Oracle Server get metodu çalıştı Listeleme Yapıldı");
        }
        public override void Update()
        {
            Console.WriteLine("Oracle Server Update metodu çalıştı Güncelleme Yapıldı");
        }
    }
    class MySql : Database
        {
            public override void Delete()
            {
                Console.WriteLine("MySql Server Delete metodu çalıştı Silme Yapıldı");
            }
            public override void Get()
            { 
                Console.WriteLine("MySql Server get metodu çalıştı Listeleme Yapıldı");
            }
            public override void Update()
            {
                Console.WriteLine("MySql Server Update metodu çalıştı Güncelleme Yapıldı");
            }
        }
}
