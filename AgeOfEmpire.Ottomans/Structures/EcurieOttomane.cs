using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Ottomans.Unites;

namespace AgeOfEmpire.Ottomans.Structures
{
    public class EcurieOttomane : Ecurie
    {
        public override Cavalier CreerCavalier()
        {
            return new Sipahi();
        }
    }
}