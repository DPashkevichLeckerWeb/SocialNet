using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IEntity<long>, IPostable, IPicturable, IFollowable
    {        
        public List<Message> IncomingMessages { get; set; }
        public List<Message> OutgouingMessages { get; set; }
        public List<User> Friends { get; set; }
        public List<Audio> Audios { get; set; }
        public List<Video> Videos { get; set; }

        public Picture CurrentPicture { get; set; }

        public List<Picture> Pictures { get; set; }

        public List<User> Followers { get; set; }

        public List<Post> Posts { get; set; }        

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Language { get; set; }
        
    }
}
