using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeMusicAPI.Models
{
    public class Repository:IRepository
    {
        private Dictionary<int, MusicFile> items;
        public IEnumerable<MusicFile> musicFiles => items.Values;
    }
}
