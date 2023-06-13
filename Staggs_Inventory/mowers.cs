using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_Inventory
{
    internal class mowers : Ishippable
    {
        double cost = 24.00;
        string product = "Lawn Mowers";

        double Ishippable.CostToShip { get => cost; }
        string Ishippable.Product { get => product; }
    }
}
