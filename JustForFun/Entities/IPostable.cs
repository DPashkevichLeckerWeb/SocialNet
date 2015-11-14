using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public interface IPostable
    {
        List<Post> Posts { get; set; }
    }
}
