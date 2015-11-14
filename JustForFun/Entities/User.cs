using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IdentityUser, IEntity<string>, IPostable, IPicturable, IFollowable
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public List<Message> IncomingMessages { get; set; }
        public List<Message> OutgouingMessages { get; set; }
        public List<User> Friends { get; set; }
        public List<Audio> Audios { get; set; }
        public List<Video> Videos { get; set; }
        public Picture CurrentPicture { get; set; }
        public List<Picture> Pictures { get; set; }
        public List<User> Followers { get; set; }
        public List<Post> Posts { get; set; }

        
        public DateTime? Created { get; set; }
        public string Language { get; set; }
    }
}
