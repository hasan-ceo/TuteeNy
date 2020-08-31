using System.Collections.Generic;
using AVL.Domain.Entities;

namespace AVL.Domain.Abstract
{
    public interface IBasicInfoRepo
    {
        IEnumerable<BasicInfo> BasicInfo { get; }
        void SaveBasicInfo(BasicInfo BasicInfo);
        BasicInfo DeleteBasicInfo(long BasicInfoID);
    }
}
