using AgeOfEmpire.Common.Unites;

namespace AgeOfEmpire.Common.Structures
{
    public abstract class Port
    {
        public abstract BateauPecheur CreerBateauPecheur();
        public abstract Galere CreerGalere();
    }
}