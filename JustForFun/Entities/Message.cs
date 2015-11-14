using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Message : IEntity<long>, IContentHolder
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public DateTime SendTime { get; set; }
        public bool IsReaded { get; set; }

        public List<IContent> Contents { get; set; } 
    }
}
