using ADVANTEDGE_CSHARP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADVANTEDGE_CSHARP.Repository
{
    public interface IJsonOperations
    {
        IEnumerable<OwnerViewModel> GetJsonData();
    }
}
