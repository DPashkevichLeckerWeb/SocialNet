using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Audio : IEntity<long>, IContent, ILikeable, ICommentable
    {
        public long Id { get; set; }
        public string Url { get; set; }

        public List<Comment> Comments { get; set; }

        public IContentHolder Holder { get; set; }        

        public List<Like> Likes { get; set; }
    }
}
