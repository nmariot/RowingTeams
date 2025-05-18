using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowingTeams
{
    internal class Boat
    {
        public Boat(IEnumerable<Rower> rowers)
        {
            Rowers.AddRange(rowers);
        }

        public List<Rower> Rowers { get; } = [];
    }
}
