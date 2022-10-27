using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Maliens.Unites;

namespace AgeOfEmpire.Maliens.Structures
{
    public class PortMalien : Port
    {
        public override BateauPecheur CreerBateauPecheur()
        {
            return new BateauPecheurMalien();
        }

        public override Galere CreerGalere()
        {
            return new CanoeDeGuerre();
        }
    }
}