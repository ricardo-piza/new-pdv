using NewPDV.Domain.Entities;

namespace NewPDV.Domain.Dtos
{
    public class ItemDto
    {
        public ItemDto(Guid id, decimal price, string name, int stockQuantity, string status, string description, string ownerUserEmail)
        {
            Id = id;
            Price = price;
            Name = name;
            StockQuantity = stockQuantity;
            Status = status;
            Description = description;
            OwnerUserEmail = ownerUserEmail;
        }

        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string OwnerUserEmail { get; set; }

        public Item Parse()
        {
            return new Item(
                Id,
                Price, 
                Name,
                StockQuantity,
                Status,
                Description,
                OwnerUserEmail
                );
        }
    }
}
