using System.Collections.Generic;
using AVL.Domain.Entities;

namespace AVL.Domain.Abstract
{
    public interface IAccountParentRepo
    {
        IEnumerable<AccountParent> AccountParent { get; }
        void SaveAccountParent(AccountParent AccountParent);
        AccountParent DeleteAccountParent(long AccountParentID);
    }
}
