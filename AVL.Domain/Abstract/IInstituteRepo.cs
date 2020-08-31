using AVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL.Domain.Abstract
{
    public interface IInstituteRepo
    {
        IEnumerable<Institute> Institute { get; }
        void SaveInstitute(Institute Institute);
        Institute DeleteInstitute(long InstituteId);
    }
}
