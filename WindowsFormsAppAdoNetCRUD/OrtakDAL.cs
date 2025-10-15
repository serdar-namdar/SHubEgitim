using System.Data; // Veri tabanı işlemleri için gerekli    
using System.Data.SqlClient; // sql işlemleri için gerekli ado net kütüphanesi

namespace WindowsFormsAppAdoNetCRUD
{
    public class OrtakDAL
    {
        internal SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database= WindowsFormsAppAdoNetCRUD; 
         Integrated Security=True;"); //  veritabanının bulunduğu srver bilgisini connection string olarak tanımladık
        internal void ConnectionKontrol() // veritabanı bağlantısını kontrol edecek olan metot
        {
            if (_connection.State == ConnectionState.Closed) // eğer bağlantı kapalı ise
            {
                _connection.Open(); // veritabanı bağlantısını aç
            }
        }
        public DataTable GetDataTable(string sqlSorgu)
        { 
            DataTable dt = new DataTable(); // datatable nesnesi oluşturduk
            ConnectionKontrol(); // bağlantı kontrol metotunu çağırdık
            SqlCommand command = new SqlCommand(sqlSorgu, _connection); // sql sorgusunu ve bağlantı nesnesini parametre olarak alan sqlcommand
                                                                        // nesnesi oluşturduk
            SqlDataReader reader = command.ExecuteReader(); // sqlcommand nesnesinden dönen verileri okumak için sqldatareader nesnesi oluşturduk
            dt.Load(reader); // datatable nesnesine sqlcommand nesnesinden dönen verileri yükledik
            reader.Close(); // sql data reader nesnesini kapattık
            _connection.Close(); // veritabanı bağlantısını kapattık
            return dt; // datatable nesnesini döndürdük
        }
    }
}
