using AVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL.Domain.Abstract
{
    public interface IBusinessDayRepo
    {
        IEnumerable<BusinessDay> BusinessDay { get; }
        void SaveBusinessDay(BusinessDay BusinessDay);
        BusinessDay DeleteBusinessDay(long BusinessDayId);
    }
}
