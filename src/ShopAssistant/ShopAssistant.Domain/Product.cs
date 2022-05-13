using SQLite;

namespace ShopAssistant.Domain
{
    /// <summary>
    /// Product entity.
    /// </summary>
    [Table("Products")]
    public class Product
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
 
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
