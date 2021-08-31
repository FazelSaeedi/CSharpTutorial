using LibraryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LibraryManagement.Tests.Integration
{
    public class RealDatabaseFixture : IDisposable
    {
        public EFContext EFContext;
        private readonly TransactionScope _transactionScope;
        public RealDatabaseFixture()
        {

            var options = new DbContextOptionsBuilder<EFContext>()
                   .UseSqlServer("Data Source =.; Initial Catalog=aspLibrary; Persist Security Info=True; User ID=fff; Password=123456789")
                   .Options;

            this.EFContext = new EFContext(options);
            _transactionScope = new TransactionScope();
        }

        public void Dispose()
        {
            EFContext.Dispose();
            _transactionScope.Dispose();
        }
    }
}
