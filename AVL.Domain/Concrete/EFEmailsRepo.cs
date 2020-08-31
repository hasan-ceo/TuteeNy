using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System.Collections.Generic;

namespace AVL.Domain.Concrete
{
    public class EFEmailsRepo : IEmailsRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Emails> Emails
        {
            get { return context.Emails; }
        }

        public void SaveEmails(Emails Emails)
        {

            if (Emails.EmailsID == 0)
            {
                context.Emails.Add(Emails);
            }
            else
            {
                Emails dbEntry = context.Emails.Find(Emails.EmailsID);
                if (dbEntry != null)
                {
                    dbEntry.EmailsID = Emails.EmailsID;
                    dbEntry.FromName = Emails.FromName;
                    dbEntry.FromEmail = Emails.FromEmail;
                    dbEntry.PhoneNumber = Emails.PhoneNumber;
                    dbEntry.Message = Emails.Message;


                }
            }
            context.SaveChanges();
        }

        public Emails DeleteEmails(long EmailsID)
        {
            Emails dbEntry = context.Emails.Find(EmailsID);
            if (dbEntry != null)
            {
                context.Emails.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
