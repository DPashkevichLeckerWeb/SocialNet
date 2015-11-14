using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public interface IPicturable
    {
        Picture CurrentPicture { get; set; }
        List<Picture> Pictures { get; set; }
    }
}
