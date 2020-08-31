using AVL.Domain.Abstract;
using AVL.Domain.Entities;
using System.Collections.Generic;

namespace AVL.Domain.Concrete
{
    public class EFProjectRepo : IProjectRepo
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Project> Project
        {
            get { return context.Project; }
        }

        public void SaveProject(Project Project)
        {

            if (Project.ProjectId == 0)
            {
                context.Project.Add(Project);
            }
            else
            {
                Project dbEntry = context.Project.Find(Project.ProjectId);
                if (dbEntry != null)
                {
                    dbEntry.ProjectId = Project.ProjectId;
                    dbEntry.ProjectName = Project.ProjectName;
                    dbEntry.ShortDescription = Project.ShortDescription;
                    dbEntry.Slug = Project.Slug;
                    dbEntry.Thumbnail = Project.Thumbnail;
                }
            }
            context.SaveChanges();
        }

        public Project DeleteProject(long ProjectID)
        {
            Project dbEntry = context.Project.Find(ProjectID);
            if (dbEntry != null)
            {
                context.Project.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
