using System.Data;

namespace Parcial.Common.Application
{
    public interface IUnitOfWork
    {
        bool BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
        void Commit(bool commit);
        void Rollback(bool rollback);
    }
}
