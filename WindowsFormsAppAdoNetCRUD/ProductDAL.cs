
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System;

namespace WindowsFormsAppAdoNetCRUD
{
    public class ProductDAL : OrtakDAL
    {
        public List<Product> GetAll()
        { 
            var products = new List<Product>();
            ConnectionKontrol();
            SqlCommand sqlcommand = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                    IsActive = (bool)reader["IsActive"],
                    Stock = (int)reader["Stock"],
                    Price = Convert.ToDecimal(reader["Price"]),
                    CreateDate = Convert.ToDateTime(reader["CreateDate"])
                };
                products.Add(product);
            }
            reader.Close(); 
            _connection.Close();
            sqlcommand.Dispose();
            return products;
        }
        public int Add(Product product)
        {
            int sonuc = 0;
            ConnectionKontrol(); // bağlantı kontrol metotunu çağırdık
            SqlCommand cmd = new SqlCommand("insert into Products (Name, Description, IsActive, CreateDate, Stock, Price) values " +
                "(@Name, @Description, @IsActive, @CreateDate, @Stock, @Price)", _connection);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            sonuc = cmd.ExecuteNonQuery(); // sql komutunu çalıştır ve etkilenen kayıt sayısını sonuca ata
            cmd.Dispose(); // sqlcommand nesnesini bellekten at 
            _connection.Close(); // veritabanı bağlantısını kapattık
            return sonuc;
        }
        public int Update(Product product)
        {
            int sonuc = 0;
            ConnectionKontrol(); // bağlantı kontrol metotunu çağırdık
            SqlCommand cmd = new SqlCommand("update Products set Name=@Name, Description=@Description, IsActive=@IsActive," +
                " CreateDate=@CreateDate, Stock=@Stock, Price=@Price where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Id", product.Id);
            sonuc = cmd.ExecuteNonQuery(); // sql komutunu çalıştır ve etkilenen kayıt sayısını sonuca ata
            cmd.Dispose(); // sqlcommand nesnesini bellekten at 
            _connection.Close(); // veritabanı bağlantısını kapattık
            return sonuc;
        }
        public int Delete(int Id)
        {
            int sonuc = 0;
            ConnectionKontrol(); // bağlantı kontrol metotunu çağırdık
            SqlCommand cmd = new SqlCommand("delete from Products where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Id", Id);
            sonuc = cmd.ExecuteNonQuery(); // sql komutunu çalıştır ve etkilenen kayıt sayısını sonuca ata
            cmd.Dispose(); // sqlcommand nesnesini bellekten at 
            _connection.Close(); // veritabanı bağlantısını kapattık
            return sonuc;
        }
    }
        
}
