using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public interface IContent
    {
        IContentHolder Holder { get; set; }
    }
}
