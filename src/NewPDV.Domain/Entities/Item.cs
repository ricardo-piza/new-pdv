using NewPDV.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Entities
{
    public class Item
    {
        public Item()
        {
            
        }
        public Item(Guid id, decimal price, string name, int stockQuantity, string status, string description, string ownerUserEmail)
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
        public ItemDto Parse()
        {
            return new ItemDto(
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
