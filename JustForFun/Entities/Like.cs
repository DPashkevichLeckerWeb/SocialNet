using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Like : IEntity<long>
    {
        public long Id { get; set; }

        public User FromUser { get; set; }
    }
}
