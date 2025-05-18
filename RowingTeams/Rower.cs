using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowingTeams
{
    [DebuggerDisplay("{Name}")]
    internal class Rower(string name, int age, Sex sex)
    {
       
        public string Name { get; } = name;

        public int Age { get; set; } = age;

        public Sex Sex { get; set; } = sex;
    }
}
