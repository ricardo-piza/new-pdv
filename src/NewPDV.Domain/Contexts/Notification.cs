using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Contexts
{
    public class Notification
    {
        public ICollection<string> Messages { get; private set; } = new List<string>();
        public ICollection<string> Errors { get; private set; } = new List<string>();
        public ICollection<string> Warnings { get; private set; } = new List<string>();
        public bool HasMessages => Messages.Count > 0;
        public bool HasErrors => Errors.Count > 0;
        public bool HasWarnings => Warnings.Count > 0;
        public void ClearMessages()
        {
            Messages.Clear();
        }
        public void ClearErrors()
        {
            Errors.Clear();
        }
        public void ClearWarnings()
        {
            Warnings.Clear();
        }
        public void ClearAll()
        {
            ClearMessages();
            ClearErrors();
            ClearWarnings();
        }

        public void AddMessage(string message)
        {
            Messages.Add(message);
        }
        public void AddError(string error)
        {
            Errors.Add(error);
        }
        public void AddWarning(string warning)
        {
            Warnings.Add(warning);
        }
        public ICollection<string> GetMessages()
        {
            return Messages;
        }
        public ICollection<string> GetErrors()
        {
            return Errors;
        }
        public ICollection<string> GetWarnings()
        {
            return Warnings;
        }

    }
}
