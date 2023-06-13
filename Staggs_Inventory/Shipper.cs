using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_Inventory
{
    internal class Shipper
    {
        Ishippable[] shippingList = new Ishippable[0];
        public Shipper() { }
        public string add(int itemID)
        {
            if(shippingList.Length >= 10)
            {
                return "ITEM NOT ADDED";
            }
            switch(itemID)
            {
                case 1:
                    shippingList.Append(new bicycle());
                    break;
                case 2:
                    shippingList.Append(new mowers());
                    break;
                case 3:
                    shippingList.Append(new baseballglove());
                    break;
                case 4:
                    shippingList.Append(new crackers());
                    break;
            }
            return "Item added to shopping list";
        }
        public string list()
        {
            int[] counts = new int[4];//Bicycles Baseball Lawn Crackers
            string ItemQuant = string.Empty;
            foreach (Ishippable i in shippingList) 
            {
                if(i.GetType() == typeof(bicycle))
                {
                    counts[0]++;
                }
                else if (i.GetType() == typeof(mowers))
                {
                    counts[1]++;
                }
                else if (i.GetType() == typeof(baseballglove))
                {
                    counts[2]++;
                }
                else if (i.GetType() == typeof(crackers))
                {
                    counts[3]++;
                }
            }
            ItemQuant = "Shipping manifest: \n" + counts[0] + " Bicycles \n" + counts[1] + " Baseball Glove \n" + counts[2] + " Lawn Mowers \n" + counts[3] + " Crackers \n";
            return ItemQuant;
            
        }
        public double compute()
        {
            return 0.5;
        }
    }
}
