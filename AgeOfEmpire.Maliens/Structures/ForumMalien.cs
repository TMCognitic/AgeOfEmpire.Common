using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Maliens.Unites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfEmpire.Maliens.Structures
{
    public class ForumMalien : Forum
    {
        public override Eclaireur CreerEclaireur()
        {
            return new EclaireurMalien();
        }

        public override Villageois CreerVillageois()
        {
            return new VillageoisMalien();
        }
    }
}
