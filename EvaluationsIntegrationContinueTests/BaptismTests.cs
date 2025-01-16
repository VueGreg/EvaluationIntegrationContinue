using EvaluationIntegrationContinue;
using Moq;

namespace EvaluationsIntegrationContinueTests
{

    [TestClass]
    public class BaptismTests
    {
        private ClergyMember _clergyMember;

        [TestInitialize]
        public void Init()
        {
            _clergyMember = new ClergyMember();
        }

        [TestMethod]
        public void CanBeBaptizedByPriest_Test()
        {
            _clergyMember.IsPriest = true;

            var baptizm = new Baptizm(_clergyMember);

            var result = baptizm.CanBeBaptizedBy(_clergyMember);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedByPope_Test()
        {
            _clergyMember.IsPope = true;

            var baptizm = new Baptizm(_clergyMember);

            var result = baptizm.CanBeBaptizedBy(_clergyMember);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeTeachedByPope_Test()
        {
            _clergyMember.IsPope = true;

            var baptizm = new Baptizm(_clergyMember);

            var result = baptizm.CanBeTeachedBy(_clergyMember);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeTeachedByPriest_Test()
        {
            _clergyMember.IsPriest = true;

            var baptizm = new Baptizm(_clergyMember);

            var result = baptizm.CanBeTeachedBy(_clergyMember);

            Assert.IsTrue(result);
        }
    }

}
