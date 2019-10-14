using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    public class Bio : ICloneable
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
