using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Maliens.Unites;

namespace AgeOfEmpire.Maliens.Structures
{
    public class CaserneMalienne : Caserne
    {
        public override Guerrier CreerGuerrier()
        {
            return new Donso();
        }
    }
}