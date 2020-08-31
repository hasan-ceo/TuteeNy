using System.Collections.Generic;
using AVL.Domain.Entities;

namespace AVL.Domain.Abstract
{
    public interface IAccountHeadsRepo
    {
        IEnumerable<AccountHeads> AccountHeads { get; }
        void SaveAccountHeads(AccountHeads AccountHeads);
        AccountHeads DeleteAccountHeads(long AccountHeadsID);
    }
}
