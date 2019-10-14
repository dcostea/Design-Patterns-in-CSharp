using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    class Tester : IEmployee
    {
        public int TestsPerHour { get; set; }
        public Bio Bio { get; set; }

        public Tester()
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
            return string.Format($"{Bio.Name} / {Bio.Role} / {TestsPerHour}");
        }
    }
}
