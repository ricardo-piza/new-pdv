using NewPDV.Domain.Dtos;
using NewPDV.Domain.Entities.Dtos;
using NewPDV.Domain.Entities.Enums;

namespace NewPDV.Domain.Entities
{
    public class Event : Audit
    {
        public Event()
        {
            
        }
        public Event(Guid id, string? name, string? responsible, EEventCashierStatus eventCashierStatus, decimal balance, List<Sale> sales, DateTime date, string duration)
        {
            Id = id;
            Name = name;
            Responsible = responsible;
            EventCashierStatus = eventCashierStatus;
            Balance = balance;
            Sales = sales;
            Date = date;
            Duration = duration;
        }

        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public string? Responsible { get; private set; }
        public EEventCashierStatus EventCashierStatus { get; private set; }
        public decimal Balance { get; private set; }
        public List<Sale> Sales { get; private set; } = new();
        public DateTime Date { get; private set; }
        public string Duration { get; private set; }

        public EventDto Parse()
        {
            var _sales = new List<SaleDto>();

            if(Sales.Count > 0)
            {
                foreach (Sale sale in Sales) { 
                    _sales.Add(sale.Parse());
                }
            }

            return new EventDto()
            {
                Id = Id,
                Name = Name,
                CashierStatus = EventCashierStatus,
                Balance = Balance,
                Sales = _sales,
                Date = Date,
                Duration = Duration,
                Responsible = Responsible,
            };
        }

        public Event AddEvent(Event _event)
        {

            return new Event(
                _event.Id,
                _event.Name,
                _event.Responsible,
                EEventCashierStatus.Openned,
                _event.Balance,
                _event.Sales,
                DateTime.Now,
                _event.Duration
                );
        }

        public Event StopEvent(Event _event)
        {

            return new Event(
                _event.Id,
                _event.Name,
                _event.Responsible,
                EEventCashierStatus.Closed,
                _event.Balance,
                _event.Sales,
                DateTime.Now,
                _event.Duration
                );
        }

        public void AddSale(Sale sale)
        {
            if (!string.IsNullOrEmpty(sale.PaymentMethod))
            {
                Sales.Add(sale);
            }
        }
    }
}
