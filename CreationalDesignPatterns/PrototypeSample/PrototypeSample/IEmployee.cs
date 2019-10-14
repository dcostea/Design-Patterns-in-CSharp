using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    public interface IEmployee
    {
        Bio Bio { get; set; }

        string GetDetails();
        IEmployee Clone();
    }
}
