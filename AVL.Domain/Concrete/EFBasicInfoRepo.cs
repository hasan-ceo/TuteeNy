using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System.Collections.Generic;

namespace AVL.Domain.Concrete
{
    public class EFBasicInfoRepo : IBasicInfoRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<BasicInfo> BasicInfo
        {
            get { return context.BasicInfo; }
        }

        public void SaveBasicInfo(BasicInfo BasicInfo)
        {

            if (BasicInfo.BasicInfoID == 0)
            {
                context.BasicInfo.Add(BasicInfo);
            }
            else
            {
                BasicInfo dbEntry = context.BasicInfo.Find(BasicInfo.BasicInfoID);
                if (dbEntry != null)
                {
                    dbEntry.BasicInfoID = BasicInfo.BasicInfoID;
                    dbEntry.SiteName = BasicInfo.SiteName;
                    dbEntry.logo = BasicInfo.logo;
                    dbEntry.ContactNumber = BasicInfo.ContactNumber;
                    dbEntry.Facebook = BasicInfo.Facebook;
                    dbEntry.twitter = BasicInfo.twitter;
                    dbEntry.Title = BasicInfo.Title;
                    dbEntry.Keywords = BasicInfo.Keywords;
                    dbEntry.Description = BasicInfo.Description;
                    dbEntry.Slide01 = BasicInfo.Slide01;
                    dbEntry.Slide01Link = BasicInfo.Slide01Link;
                    dbEntry.Slide02 = BasicInfo.Slide02;
                    dbEntry.Slide02Link = BasicInfo.Slide02Link;
                    dbEntry.Slide03 = BasicInfo.Slide03;
                    dbEntry.Slide03Link = BasicInfo.Slide03Link;
                }
            }
            context.SaveChanges();
        }

        public BasicInfo DeleteBasicInfo(long BasicInfoID)
        {
            BasicInfo dbEntry = context.BasicInfo.Find(BasicInfoID);
            if (dbEntry != null)
            {
                context.BasicInfo.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
