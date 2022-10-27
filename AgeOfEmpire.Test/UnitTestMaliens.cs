using AgeOfEmpire.Common.Structures;

namespace AgeOfEmpire.Test
{
    [TestClass]
    public class UnitTestMaliens
    {
        private Forum _forum;

        [TestInitialize]
        public void Initialize()
        {
            _forum = new ForumMalien();
        }

        [TestMethod]
        public void TestForumType()
        {
            Assert.IsInstanceOfType(_forum, typeof(ForumMalien));
        }

        [TestMethod]
        public void TestVillageoisType()
        {
            Villageois villageois = _forum.CreerVillageois();
            Assert.IsInstanceOfType(villageois, typeof(VillageoisMalien));
        }

        [TestMethod]
        public void TestCaserneType()
        {
            Villageois villageois = _forum.CreerVillageois();
            Caserne caserne = villageois.CreerCaserne();            
            Assert.IsInstanceOfType(caserne, typeof(CaserneMalienne));
        }
    }
}