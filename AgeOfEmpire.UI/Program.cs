using AgeOfEmpire.Common.Structures;
using AgeOfEmpire.Common.Unites;
using AgeOfEmpire.Maliens.Structures;

namespace AgeOfEmpire.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forum forum = new ForumMalien();
            Villageois villageois = forum.CreerVillageois();
            Console.WriteLine(villageois);
            Console.WriteLine(villageois.CreerMoulin());
            Console.WriteLine(villageois.CreerCampBucheron());
        }
    }
}