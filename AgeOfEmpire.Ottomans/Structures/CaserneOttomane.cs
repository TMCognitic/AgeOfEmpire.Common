using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Ottomans.Unites;

namespace AgeOfEmpire.Ottomans.Structures
{
    public class CaserneOttomane : Caserne
    {
        public override Guerrier CreerGuerrier()
        {
            return new Lancier();
        }
    }
}