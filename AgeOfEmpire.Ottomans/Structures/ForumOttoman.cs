using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Ottomans.Unites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfEmpire.Ottomans.Structures
{
    public class ForumOttoman : Forum
    {
        public override Eclaireur CreerEclaireur()
        {
            return new EclaireurOttoman();
        }

        public override Villageois CreerVillageois()
        {
            return new VillageoisOttoman();
        }
    }
}
