using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment : IEntity<long>, IContentHolder, ICommentable
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public User FromUser { get; set; }
        public DateTime SendTime { get; set; }

        public List<Comment> Comments { get; set; }

        public List<IContent> Contents { get; set; }
    }
}
