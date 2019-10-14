using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    class Developer : IEmployee
    {
        public int LinesPerHour { get; set; }
        public string PreferredLanguage { get; set; }
        public Bio Bio { get; set; }

        public Developer()
        {
            Bio = new Bio();
        }

        public IEmployee Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            //return MemberwiseClone() as IEmployee;

            // Deep Copy: all objects are duplicated
            var clone = MemberwiseClone() as IEmployee;
            clone.Bio = Bio.Clone() as Bio;
            return clone;
        }

        public string GetDetails()
        {
            return string.Format($"{Bio.Name} / {Bio.Role} / {PreferredLanguage} / {LinesPerHour}");
        }
    }
}
