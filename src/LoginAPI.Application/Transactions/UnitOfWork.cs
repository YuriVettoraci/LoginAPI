using LoginAPI.Application.Transactions.Interfaces;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Application.Transactions
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ISession session;
        private ITransaction transaction;
        public UnitOfWork(ISession session)
        {
            this.session = session;
        }

        public void BeginTransaction()
        {
            this.transaction = session.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null && transaction.IsActive)
                transaction.Commit();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            if (transaction != null && transaction.IsActive)
                transaction.Rollback();

        }
    }
}
