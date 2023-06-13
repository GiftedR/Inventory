using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_Inventory
{
    internal class bicycle : Ishippable
    {
        double cost = 9.5;
        string product = "Bicycle";

        double Ishippable.CostToShip { get => cost; }
        string Ishippable.Product { get => product; }
    }
}
