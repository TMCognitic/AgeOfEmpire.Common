using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Maliens.Structures;

namespace AgeOfEmpire.Maliens.Unites
{
    public class VillageoisMalien : Villageois
    {
        public override CampBucheron CreerCampBucheron()
        {
            return new CampBucheronMalien();
        }

        public override CampMineur CreerCampMineur()
        {
            return new CampMineurMalien();
        }

        public override Caserne CreerCaserne()
        {
            return new CaserneMalienne();
        }

        public override Champ CreerChamp()
        {
            return new ChampMalien();
        }

        public override Ecurie CreerEcurie()
        {
            return new EcurieMalienne();
        }

        public override Maison CreerMaison()
        {
            return new MaisonMalienne();
        }

        public override Moulin CreerMoulin()
        {
            return new MoulinMalien();
        }

        public override Port CreerPort()
        {
            return new PortMalien();
        }
    }
}