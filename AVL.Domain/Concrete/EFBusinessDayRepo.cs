using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL.Domain.Concrete
{
    public class EFBusinessDayRepo : IBusinessDayRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<BusinessDay> BusinessDay
        {
            get { return context.BusinessDay; }
        }

        public void SaveBusinessDay(BusinessDay BusinessDay)
        {

            if (BusinessDay.BusinessDayID == 0)
            {
                context.BusinessDay.Add(BusinessDay);
            }
            else
            {
                BusinessDay dbEntry = context.BusinessDay.Find(BusinessDay.BusinessDayID);
                if (dbEntry != null)
                {
                    dbEntry.BusinessDayID = BusinessDay.BusinessDayID;
                    dbEntry.WorkDate = BusinessDay.WorkDate;
                    dbEntry.DayClose = BusinessDay.DayClose;
                }
            }
            context.SaveChanges();
        }

        public BusinessDay DeleteBusinessDay(long BusinessDayID)
        {
            BusinessDay dbEntry = context.BusinessDay.Find(BusinessDayID);
            if (dbEntry != null)
            {
                context.BusinessDay.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
