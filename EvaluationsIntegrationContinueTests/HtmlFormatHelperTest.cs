using EvaluationIntegrationContinue;

namespace EvaluationsIntegrationContinueTests
{
    [TestClass]
    public class HtmlFormatHelperTest
    {
        // Initialisation des méthodes à tester
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void GetStrongFormat_WithPersonnalText_Test()
        {
            var content = "C'est un peu gras içi !";

            var result = _htmlFormatHelper.GetStrongFormat(content);

            Assert.AreEqual("<strong>C'est un peu gras içi !</strong>", result);
        }

        [TestMethod]
        public void GetItalicFormat_WithPersonnalText_Test()
        {
            var content = "C'est un peu penché içi !";

            var result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual("<i>C'est un peu penché içi !</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_WhenListContainsThreeItems_Test()
        {
            var contents = new List<string> { "Item 1", "Item 2", "Item 3" };

            var result = _htmlFormatHelper.GetFormattedListElements(contents);

            var expected = "<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>";
            Assert.AreEqual(expected, result);
        }
    }
}
