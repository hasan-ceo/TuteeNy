using System.Collections.Generic;
using AVL.Domain.Entities;

namespace AVL.Domain.Abstract
{
    public interface IBankRepo
    {
        IEnumerable<Bank> Bank { get; }
        void SaveBank(Bank Bank);
        Bank DeleteBank(long BankID);
    }
}
