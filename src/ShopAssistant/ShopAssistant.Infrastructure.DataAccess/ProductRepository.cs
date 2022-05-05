using System.Collections.Generic;
using ShopAssistant.Domain;
using SQLite;

namespace ShopAssistant.Infrastructure.DataAccess
{
    public class ProductRepository
    {
        SQLiteConnection database;
        public ProductRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Product>();
        }
        public IEnumerable<Product> GetItems()
        {
            return database.Table<Product>().ToList();
        }
        public Product GetItem(int id)
        {
            return database.Get<Product>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Product>(id);
        }
        public int SaveItem(Product item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}