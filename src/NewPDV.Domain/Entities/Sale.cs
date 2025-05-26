using NewPDV.Domain.Dtos;
using NewPDV.Domain.Entities.Dtos;
using NewPDV.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Entities
{
    public class Sale : Audit
    {
        public Sale()
        {
            
        }
        public Sale(Guid id, decimal value, DateTime date, string? paymentMethod, ESaleStatus status, List<Item> items)
        {
            Id = id;
            Value = value;
            Date = date;
            PaymentMethod = paymentMethod;
            Status = status;
            Items = items;
        }

        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }
        public string? PaymentMethod { get; private set; }
        public ESaleStatus Status { get; private set; }
        public List<Item> Items { get; set; }

        public SaleDto Parse()
        {
            var _items = new List<ItemDto>();

            if(Items.Count > 0)
            {
                foreach (var item in Items) {
                    _items.Add(item.Parse());
                }
            }

            return new SaleDto(
                Id, 
                Value, 
                Date,
                Status,
                PaymentMethod,
                _items
                );
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public void RemoveItemById(Guid itemId)
        {
            if (Items.Count == 0) return;
            Items.Remove(Items.FirstOrDefault(x => x.Id == itemId));
        }
    }
}
