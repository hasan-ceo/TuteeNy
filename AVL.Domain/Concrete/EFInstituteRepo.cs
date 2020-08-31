using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL.Domain.Concrete
{
    public class EFInstituteRepo : IInstituteRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Institute> Institute
        {
            get { return context.Institute; }
        }

        public void SaveInstitute(Institute Institute)
        {

            if (Institute.InstituteID == 0)
            {
                context.Institute.Add(Institute);
            }
            else
            {
                Institute dbEntry = context.Institute.Find(Institute.InstituteID);
                if (dbEntry != null)
                {
                    dbEntry.InstituteID = Institute.InstituteID;
                    dbEntry.InstituteName = Institute.InstituteName;
                                  
                }
            }
            context.SaveChanges();
        }

        public Institute DeleteInstitute(long InstituteID)
        {
            Institute dbEntry = context.Institute.Find(InstituteID);
            if (dbEntry != null)
            {
                context.Institute.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
