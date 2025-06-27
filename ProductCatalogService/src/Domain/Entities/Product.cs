namespace ProductCatalogService.Domain.Entities
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Category { get; set; } = string.Empty;

        public int StockQuantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public void Update(string name, string description, decimal price, string category, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            StockQuantity = stock;
            UpdatedAt = DateTime.UtcNow;
        }

    }
}
