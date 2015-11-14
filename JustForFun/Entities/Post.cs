using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Post : IEntity<long>, IContentHolder, ICommentable, ILikeable
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public User FromUser { get; set; }
        public DateTime SendTime { get; set; }

        public List<Comment> Comments { get; set; }

        public List<IContent> Contents { get; set; }

        public List<Like> Likes { get; set; }
    }
}
