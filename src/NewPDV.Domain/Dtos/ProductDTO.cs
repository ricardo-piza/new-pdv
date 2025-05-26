using NewPDV.Domain.Entities.Enums;

namespace NewPDV.Domain.Entities.Dtos
{

    public class ProductDTO
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public EProductStatus Status { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public Product Parse()
        {
            return new Product(
                Id,
                Price,
                Name,
                StockQuantity,
                Status,
                Description,
                Image
                );
        }
    }
}
