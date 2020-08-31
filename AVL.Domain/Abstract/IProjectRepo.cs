using System.Collections.Generic;
using AVL.Domain.Entities;

namespace AVL.Domain.Abstract
{
    public interface IProjectRepo
    {
        IEnumerable<Project> Project { get; }
        void SaveProject(Project Project);
        Project DeleteProject(long ProjectID);
    }
}
