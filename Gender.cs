using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD07
{
    public enum Gender
    {
        Male,
        Female
    }

    [Flags]
    public enum SecurrityLevel
    {
        Guest = 1,
        Developer = 2,
        Secertary = 4,
        DBA = 8,

    }
}
