using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Entities
{
    public abstract class Audit
    {
        public string? UserCreated { get; set; }
        public string? UserUpdated { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
