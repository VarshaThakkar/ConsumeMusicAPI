using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeMusicAPI.Models
{
    public class IRepository
    {
        IEnumerable<MusicFile> musicFiles { get; }
    }
}
