using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System.Collections.Generic;

namespace AVL.Domain.Concrete
{
    public class EFAccountTypeRepo : IAccountTypeRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<AccountType> AccountType
        {
            get { return context.AccountType; }
        }

        public void SaveAccountType(AccountType AccountType)
        {

            if (AccountType.AccountTypeId == 0)
            {
                context.AccountType.Add(AccountType);
            }
            else
            {
                AccountType dbEntry = context.AccountType.Find(AccountType.AccountTypeId);
                if (dbEntry != null)
                {
                    dbEntry.AccountTypeId = AccountType.AccountTypeId;
                    dbEntry.AccountTypeName = AccountType.AccountTypeName;
                }
            }
            context.SaveChanges();
        }

        public AccountType DeleteAccountType(long AccountTypeID)
        {
            AccountType dbEntry = context.AccountType.Find(AccountTypeID);
            if (dbEntry != null)
            {
                context.AccountType.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
