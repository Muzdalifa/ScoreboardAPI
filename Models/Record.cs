using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreboardAPI.Models
{
    public class Record
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Win { get; set; }
        public int Loose { get; set; }
    }
}
