using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public abstract class Addition : Building
    {
        public Building theBuilding;

        public Addition(Building theBuilding)
        {
            this.theBuilding = theBuilding;
        }
    }
}
