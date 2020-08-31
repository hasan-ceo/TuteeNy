using System.Collections.Generic;
using AVL.Domain.Entities;

namespace AVL.Domain.Abstract
{
    public interface IEmailsRepo
    {
        IEnumerable<Emails> Emails { get; }
        void SaveEmails(Emails Emails);
        Emails DeleteEmails(long EmailsID);
    }
}
