using NewPDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Contexts
{
    public class NotificationContext : INotificationsContext
    {
        Notification notification = new();
        public async Task AddError(string error)
        {
            notification.AddError(error);
        }

        public async Task AddMessage(string message)
        {
            notification.AddMessage(message);
        }

        public async Task AddWarning(string warning)
        {
            notification.AddWarning(warning);
        }

        public async Task ClearAll()
        {
            notification.ClearAll();
        }

        public async Task ClearErrors()
        {
            notification.ClearErrors();
        }

        public async Task ClearMessages()
        {
            notification.ClearMessages();
        }

        public async Task ClearWarnings()
        {
            notification.ClearWarnings();
        }

        public async Task<ICollection<string>> GetErrors()
        {
            return notification.GetErrors();
        }

        public async Task<ICollection<string>> GetMessages()
        {
            return notification.GetMessages();
        }

        public async Task<ICollection<string>> GetWarnings()
        {
            return notification.GetWarnings();
        }

        public async Task<bool> HasErrors()
        {
            return notification.HasErrors;
        }

        public async Task<bool> HasMessages()
        {
            return notification.HasMessages;
        }

        public async Task<bool> HasWarnings()
        {
            return notification.HasWarnings;
        }
    }
}
