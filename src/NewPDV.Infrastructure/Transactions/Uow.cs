using Microsoft.EntityFrameworkCore.Storage;
using NewPDV.Domain.Interfaces;
using NewPDV.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Infrastructure.Transactions
{
    public class Uow : IUow
    {
        private readonly NewPDVContext _context;
        private IDbContextTransaction _currentTransaction;

        public Uow(NewPDVContext context)
        {
            _context = context;
        }
        public async Task BeginTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                throw new InvalidOperationException("A transaction is already in progress.");
            }

            _currentTransaction = await _context.Database.BeginTransactionAsync();
        }

        public void Commit()
        {
            if (_currentTransaction == null)
            {
                throw new InvalidOperationException("No transaction in progress to commit.");
            }

            _currentTransaction.Commit();
            DisposeTransaction();
        }

        public void Rollback()
        {
            if (_currentTransaction == null)
            {
                throw new InvalidOperationException("No transaction in progress to roll back.");
            }

            _currentTransaction.Rollback();
            DisposeTransaction();
        }

        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void Dispose()
        {
            DisposeTransaction();
            _context.Dispose();
        }
        private void DisposeTransaction()
        {
            _currentTransaction?.Dispose();
            _currentTransaction = null;
        }
    }
}
