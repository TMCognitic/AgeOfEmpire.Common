using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Ottomans.Unites;

namespace AgeOfEmpire.Ottomans.Structures
{
    public class PortOttoman : Port
    {
        public override BateauPecheur CreerBateauPecheur()
        {
            return new BateauPecheurOttomans();
        }

        public override Galere CreerGalere()
        {
            return new Ponton();
        }
    }
}