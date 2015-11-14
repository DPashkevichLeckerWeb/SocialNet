using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Group : IEntity<long>, IPostable, IPicturable, IFollowable
    {
        public User Admin { get; set; }
        public long Id { get; set; }
        public bool IsPrivate { get; set; }

        public Picture CurrentPicture { get; set; }

        public List<User> Followers { get; set; }

        public List<Picture> Pictures { get; set; }

        public List<Post> Posts { get; set; }
    }
}
