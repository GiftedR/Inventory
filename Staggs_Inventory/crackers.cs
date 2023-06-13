using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_Inventory
{
    internal class crackers : Ishippable
    {
        double cost = 0.57;
        string product = "Crackers";

        double Ishippable.CostToShip { get => cost; }
        string Ishippable.Product { get => product; }
    }
}
