using AgeOfEmpire.Common.Structures;

namespace AgeOfEmpire.Test
{
    [TestClass]
    public class UnitTestOttomans
    {
        private Forum _forum;

        [TestInitialize]
        public void Initialize()
        {
            _forum = new ForumOttoman();
        }

        [TestMethod]
        public void TestForumType()
        {
            Assert.IsInstanceOfType(_forum, typeof(ForumOttoman));
        }

        [TestMethod]
        public void TestVillageoisType()
        {
            Villageois villageois = _forum.CreerVillageois();
            Assert.IsInstanceOfType(villageois, typeof(VillageoisOttoman));
        }

        [TestMethod]
        public void TestCaserneType()
        {
            Villageois villageois = _forum.CreerVillageois();
            Caserne caserne = villageois.CreerCaserne();
            Assert.IsInstanceOfType(caserne, typeof(CaserneOttomane));
        }
    }
}