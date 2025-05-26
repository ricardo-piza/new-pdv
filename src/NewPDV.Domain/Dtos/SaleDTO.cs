using NewPDV.Domain.Dtos;
using NewPDV.Domain.Entities.Enums;

namespace NewPDV.Domain.Entities.Dtos
{
    public class SaleDto
    {
        public SaleDto(Guid id, decimal value, DateTime date, ESaleStatus status, string paymentMethod, List<ItemDto> items)
        {
            Id = id;
            Value = value;
            Date = date;
            Status = status;
            PaymentMethod = paymentMethod;
            Items = items;
        }

        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public ESaleStatus Status { get; set; }
        public string PaymentMethod { get; set; }
        public List<ItemDto> Items { get; set; }

        public Sale Parse()
        {
            var _items = new List<Item>();
            if (Items.Count > 0)
            {
                foreach (var item in Items)
                {
                    _items.Add(item.Parse());
                }
            }

            return new Sale(
               Id,
               Value,
               Date,
               PaymentMethod,
               Status,
                _items
                );
        }
    }
}
