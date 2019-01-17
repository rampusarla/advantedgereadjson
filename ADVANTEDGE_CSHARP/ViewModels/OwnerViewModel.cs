using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADVANTEDGE_CSHARP.ViewModels
{
    public class OwnerViewModel
    {
        public string Gender { get; set; }
        public IEnumerable<string> Owners { get; set; }
    }
}
