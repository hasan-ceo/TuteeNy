using System.Collections.Generic;
using AVL.Domain.Entities;

namespace AVL.Domain.Abstract
{
    public interface IAccountTypeRepo
    {
        IEnumerable<AccountType> AccountType { get; }
        void SaveAccountType(AccountType AccountType);
        AccountType DeleteAccountType(long AccountTypeID);
    }
}
