namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock= stock;
        }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; } = "Водный спорт";
        public Product Related { get; set; }
        public bool InStock { get; } = true;
        public static Product[] GetProducts()
        {
            Product kayak = new()
            {
                Name = "Каяк",
                Category = "Лодки",
                Price = 275M
            };
            Product lifejacket = new(false)
            {
                Name = "Спасательный жилет",
                Price = 48.95M
            };
            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}
