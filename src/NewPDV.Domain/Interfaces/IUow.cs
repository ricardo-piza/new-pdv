namespace NewPDV.Domain.Interfaces
{
    public interface IUow
    {
        Task BeginTransactionAsync();
        void Commit();
        Task<bool> SaveAsync();
        void Rollback();
        void Dispose();
    }
}
