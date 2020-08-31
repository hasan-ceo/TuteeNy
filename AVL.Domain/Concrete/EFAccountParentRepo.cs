using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System.Collections.Generic;

namespace AVL.Domain.Concrete
{
    public class EFAccountParentRepo : IAccountParentRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<AccountParent> AccountParent
        {
            get { return context.AccountParent; }
        }

        public void SaveAccountParent(AccountParent AccountParent)
        {

            if (AccountParent.AccountParentId == 0)
            {
                context.AccountParent.Add(AccountParent);
            }
            else
            {
                AccountParent dbEntry = context.AccountParent.Find(AccountParent.AccountParentId);
                if (dbEntry != null)
                {
                    dbEntry.AccountParentId = AccountParent.AccountParentId;
                    dbEntry.AccountParentName = AccountParent.AccountParentName;
                }
            }
            context.SaveChanges();
        }

        public AccountParent DeleteAccountParent(long AccountParentID)
        {
            AccountParent dbEntry = context.AccountParent.Find(AccountParentID);
            if (dbEntry != null)
            {
                context.AccountParent.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
