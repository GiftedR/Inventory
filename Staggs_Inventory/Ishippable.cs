using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_Inventory
{
    internal interface Ishippable
    {
        double CostToShip { get; }
        string Product { get; }
    }
}
