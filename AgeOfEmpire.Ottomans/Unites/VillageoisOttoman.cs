using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Ottomans.Structures;

namespace AgeOfEmpire.Ottomans.Unites
{
    public class VillageoisOttoman : Villageois
    {
        public override CampBucheron CreerCampBucheron()
        {
            return new CampBucheronOttoman();
        }

        public override CampMineur CreerCampMineur()
        {
            return new CampMineurOttoman();
        }

        public override Caserne CreerCaserne()
        {
            return new CaserneOttomane();
        }

        public override Champ CreerChamp()
        {
            return new ChampOttoman();
        }

        public override Ecurie CreerEcurie()
        {
            return new EcurieOttomane();
        }

        public override Maison CreerMaison()
        {
            return new MaisonOttomane();
        }

        public override Moulin CreerMoulin()
        {
            return new MoulinOttoman();
        }

        public override Port CreerPort()
        {
            return new PortOttoman();
        }
    }
}