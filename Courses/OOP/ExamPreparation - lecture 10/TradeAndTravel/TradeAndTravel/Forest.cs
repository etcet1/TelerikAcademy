using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Forest : GatheringLocation
    {
        public Forest(string name)
            : base(name, LocationType.Forest, ItemType.Wood, ItemType.Weapon)
        {
        }

        public override Item ProduceItem(string itemname)
        {
            return new Wood(itemname, null);
        }
    }
}
