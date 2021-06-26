using System;
using ConsoleAppTest.Data;
using ConsoleAppTest.Data.Model;
using ConsoleAppTest.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest
{
    public class TransactionQueryHandler : IQueryTransaction
    {
        private ApplicationDbContext _context;
        private DbSet<AccountTransaction> _dbSet;

        public TransactionQueryHandler(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<AccountTransaction>();
        }

        public void Put()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }

        public void Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
