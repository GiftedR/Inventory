using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_Inventory
{
    internal class baseballglove : Ishippable
    {
        double cost = 3.23;
        string product = "Baseball Glove";

        double Ishippable.CostToShip { get => cost; }
        string Ishippable.Product { get => product; }
    }
}
