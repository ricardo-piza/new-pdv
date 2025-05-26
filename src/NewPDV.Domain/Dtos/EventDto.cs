using NewPDV.Domain.Entities;
using NewPDV.Domain.Entities.Dtos;
using NewPDV.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Dtos
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Responsible { get; set; }
        public EEventCashierStatus CashierStatus { get; set; }
        public decimal Balance { get; set; }
        public List<SaleDto> Sales { get; set; }
        public DateTime Date { get; set; }
        public string Duration { get; set; }
        public Event Parse()
        {
            var _sales = new List<Sale>();

            if (Sales.Count > 0)
            {
                foreach (var sale in Sales)
                {
                    _sales.Add(sale.Parse());
                }
            }

            return new Event(
                Id,
                Name,
                Responsible,
                CashierStatus,
                Balance,
                _sales,
                Date,
                Duration);
        }
        public void AddSale(SaleDto sale)
        {
            Sales.Add(sale);
        }
    }
}
