using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System.Collections.Generic;

namespace AVL.Domain.Concrete
{
    public class EFBankRepo : IBankRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Bank> Bank
        {
            get { return context.Bank; }
        }

        public void SaveBank(Bank Bank)
        {

            if (Bank.BankId == 0)
            {
                context.Bank.Add(Bank);
            }
            else
            {
                Bank dbEntry = context.Bank.Find(Bank.BankId);
                if (dbEntry != null)
                {
                    dbEntry.BankId = Bank.BankId;
                    dbEntry.BankName = Bank.BankName;
                }
            }
            context.SaveChanges();
        }

        public Bank DeleteBank(long BankID)
        {
            Bank dbEntry = context.Bank.Find(BankID);
            if (dbEntry != null)
            {
                context.Bank.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
