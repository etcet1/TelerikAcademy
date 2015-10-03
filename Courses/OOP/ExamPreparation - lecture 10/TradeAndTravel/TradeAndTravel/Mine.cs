using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Mine : GatheringLocation
    {
        public Mine(string name)
            : base(name, LocationType.Mine, ItemType.Iron, ItemType.Armor)
        {
        }

        public override Item ProduceItem(string itemname)
        {
            return new Iron(itemname, null);
        }
    }
}
