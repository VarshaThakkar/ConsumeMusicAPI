using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeMusicAPI.Models
{
    public class MusicFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long? FileSize { get; set; }
        public string Track { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
    }
}
