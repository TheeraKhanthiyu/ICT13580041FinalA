using System;
using ICT13580041FinalA.Models;
using SQLite;
namespace ICT13580041FinalA.DbHelper
{
    public class DbHelper
    {
        SQLiteConnection db;

        public  DbHelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();

        }

        public int AddPersonal(Product  product)
        {
            db.Insert(product);
            return product.Id;
        }
    }
}
