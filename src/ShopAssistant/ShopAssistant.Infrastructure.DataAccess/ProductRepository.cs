using System.Collections.Generic;
using ShopAssistant.Domain;
using SQLite;

namespace ShopAssistant.Infrastructure.DataAccess
{
    /// <summary>
    /// Product repository.
    /// </summary>
    public class ProductRepository
    {
        SQLiteConnection database;
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public ProductRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Product>();
        }

        /// <summary>
        /// Get items.
        /// </summary>
        /// <returns>Selection of items.</returns>
        public IEnumerable<Product> GetItems()
        {
            return database.Table<Product>().ToList();
        }
        
        /// <summary>
        /// Get item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Item.</returns>
        public Product GetItem(int id)
        {
            return database.Get<Product>(id);
        }
        
        /// <summary>
        /// Delete item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Deleted item.</returns>
        public int DeleteItem(int id)
        {
            return database.Delete<Product>(id);
        }
        
        /// <summary>
        /// Save item.
        /// </summary>
        /// <param name="item">Item with fields.</param>
        /// <returns>Id of added item.</returns>
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
