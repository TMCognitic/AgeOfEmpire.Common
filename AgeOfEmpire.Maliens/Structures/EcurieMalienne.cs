using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Maliens.Unites;

namespace AgeOfEmpire.Maliens.Structures
{
    public class EcurieMalienne : Ecurie
    {
        public override Cavalier CreerCavalier()
        {
            return new Sofa();
        }
    }
}