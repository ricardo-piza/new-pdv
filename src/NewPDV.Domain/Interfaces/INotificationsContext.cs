using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Interfaces
{
    public interface INotificationsContext
    {
        Task AddMessage(string message);
        Task AddError(string error);
        Task AddWarning(string warning);
        Task<ICollection<string>> GetMessages();
        Task<ICollection<string>> GetErrors();
        Task<ICollection<string>> GetWarnings();
        Task ClearMessages();
        Task ClearErrors();
        Task ClearWarnings();
        Task ClearAll();
        Task<bool> HasMessages();
        Task<bool> HasErrors();
        Task<bool> HasWarnings();

    }
}
