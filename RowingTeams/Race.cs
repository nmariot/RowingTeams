using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowingTeams
{
    [DebuggerDisplay("{Name}")]
    internal class Race(int number, string name, RaceType rt, int nbRowers, RaceCategory category)
    {
        public string Name { get; } = name;

        public int Number { get; } = number;

        public int NbRowers { get; } = nbRowers;

        public RaceCategory Category { get; } = category;

        public RaceType Type { get; } = rt;
    }
}
