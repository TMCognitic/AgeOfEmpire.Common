using AgeOfEmpire.Common.Structures;

namespace AgeOfEmpire.Common.Unites
{
    public abstract class Villageois
    {
        public abstract Maison CreerMaison();
        public abstract Moulin CreerMoulin();
        public abstract Champ CreerChamp();
        public abstract CampBucheron CreerCampBucheron();
        public abstract CampMineur CreerCampMineur();
        public abstract Caserne CreerCaserne();
        public abstract Ecurie CreerEcurie();
        public abstract Port CreerPort();
    }
}