using System;
using System.Linq;
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

        public void Put(AccountTransaction operation)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                if (operation is null)
                {
                    throw new ArgumentNullException(nameof(operation));
                }

                var senderAccount = _context.Accounts.SingleOrDefault(x => x.Id == operation.SenderAccountId);

                if (senderAccount == default
                    || senderAccount.ClientId != operation.SenderClientId
                    || operation.Operation != Operation.Put)
                {
                    throw new ArgumentException(nameof(operation));
                }
                else if (operation.Sum <= 0)
                {
                    throw new InvalidOperationException(nameof(operation.Sum));
                }

                senderAccount.Balance -= operation.Sum;

                _dbSet.Add(operation);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: operation is null {ex.Message}");
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message} {ex.ParamName}");
                Console.ResetColor();
            }
            catch(InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Сумма меньше нуля {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message}");
                Console.ResetColor();
            }
        }

        public void Transfer(AccountTransaction operation)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                if (operation is null)
                {
                    throw new ArgumentNullException(nameof(operation));
                }

                var senderAccount = _context.Accounts.SingleOrDefault(x => x.Id == operation.SenderAccountId);
                var recipientAccount = _context.Accounts.SingleOrDefault(x => x.Id == operation.RecipientAccountId);

                if (recipientAccount == default || senderAccount == default
                    || recipientAccount.ClientId != operation.RecipientClientId
                    || senderAccount.ClientId != operation.SenderClientId
                    || operation.Operation != Operation.Transfer)
                {
                    throw new ArgumentException(nameof(operation));
                }

                if (senderAccount.Balance < operation.Sum)
                {
                    throw new InvalidOperationException(nameof(operation.Sum));
                }

                senderAccount.Balance -= operation.Sum;
                recipientAccount.Balance += operation.Sum;

                _dbSet.Add(operation);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: operation is null {ex.Message}");
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message} {ex.ParamName}");
                Console.ResetColor();
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"У вас недостаточно средств {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message}");
                Console.ResetColor();
            }
        }

        public void Withdraw(AccountTransaction operation)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                if (operation is null)
                {
                    throw new ArgumentNullException(nameof(operation));
                }

                var senderAccount = _context.Accounts.SingleOrDefault(x => x.Id == operation.SenderAccountId);

                if (senderAccount == default
                    || senderAccount.ClientId != operation.SenderClientId
                    || operation.Operation != Operation.Withdraw)
                {
                    throw new ArgumentException(nameof(operation));
                }
                else if (senderAccount.Balance < operation.Sum)
                {
                    throw new InvalidOperationException(nameof(operation.Sum));
                }

                senderAccount.Balance -= operation.Sum;

                _dbSet.Add(operation);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: operation is null {ex.Message}");
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message} {ex.ParamName}");
                Console.ResetColor();
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"У вас недостаточно средств {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
