using NewPDV.Domain.Entities.Enums;

namespace NewPDV.Domain.Entities
{
    public class Product : Audit
    {
        public Product()
        {
            
        }
        public Product(Guid id, decimal price, string name, int stockQuantity, EProductStatus status, string description, byte[] image)
        {
            Id = id;
            Price = price;
            Name = name;
            StockQuantity = stockQuantity;
            Status = status;
            Description = description;
            Image = image;
        }

        public Guid Id { get; private set; }
        public decimal Price { get; private set; }
        public string Name { get; private set; }
        public int StockQuantity { get; private set; }
        public EProductStatus Status { get; private set; }
        public string Description { get; private set; }
        public byte[] Image { get; private set; }
    }
}
