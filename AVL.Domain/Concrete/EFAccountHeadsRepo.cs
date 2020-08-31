using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System.Collections.Generic;

namespace AVL.Domain.Concrete
{
    public class EFAccountHeadsRepo : IAccountHeadsRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<AccountHeads> AccountHeads
        {
            get { return context.AccountHeads; }
        }

        public void SaveAccountHeads(AccountHeads AccountHeads)
        {

            if (AccountHeads.AccountHeadsId == 0)
            {
                context.AccountHeads.Add(AccountHeads);
            }
            else
            {
                AccountHeads dbEntry = context.AccountHeads.Find(AccountHeads.AccountHeadsId);
                if (dbEntry != null)
                {
                    dbEntry.AccountHeadsId = AccountHeads.AccountHeadsId;
                    dbEntry.Name = AccountHeads.Name;
                    dbEntry.AccountParentId = AccountHeads.AccountParentId;
                    dbEntry.AccountTypeId = AccountHeads.AccountTypeId;
                    dbEntry.REFlag = AccountHeads.REFlag;
                    dbEntry.AutoAc = AccountHeads.AutoAc;
                }
            }
            context.SaveChanges();
        }

        public AccountHeads DeleteAccountHeads(long AccountHeadsID)
        {
            AccountHeads dbEntry = context.AccountHeads.Find(AccountHeadsID);
            if (dbEntry != null)
            {
                context.AccountHeads.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
