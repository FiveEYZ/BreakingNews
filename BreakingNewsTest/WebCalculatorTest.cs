using BreakingNews;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNewsTest
{
    [TestFixture]
    class WebCalculatorTest
    {
        [Test]
        public void CalculateNumberOfHitsTest1()
        {
            var myTestWebCollector = new Mock<IWebCollector>();

            var myTestWebCalculator = new Mock<WebCalculator>();

            IWebCalculator myWebCalculator = new WebCalculator();

            myTestWebCollector.SetupAllProperties();
            myTestWebCollector.Object.HtmlCode = "trumptrumptrump";

            string keyword = "trump";
            var result = myTestWebCalculator.Object.CalculateNumberOfHits(myTestWebCollector.Object, keyword);

            Assert.AreEqual(3, result);
        }
        [Test]
        public void CalculateNumberOfHitsTest2()
        {
            var myTestWebCollector = new Mock<IWebCollector>();

            var myTestWebCalculator = new Mock<WebCalculator>();

            IWebCalculator myWebCalculator = new WebCalculator();

            myTestWebCollector.SetupAllProperties();
            myTestWebCollector.Object.HtmlCode = null;

            string keyword = "trump";
            var result = myTestWebCalculator.Object.CalculateNumberOfHits(myTestWebCollector.Object, keyword);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void CalculateNumberOfHitsTest3()
        {
            var myTestWebCollector = new Mock<IWebCollector>();

            var myTestWebCalculator = new Mock<WebCalculator>();

            IWebCalculator myWebCalculator = new WebCalculator();

            myTestWebCollector.SetupAllProperties();
            myTestWebCollector.Object.HtmlCode = string.Empty;

            string keyword = "trump";
            var result = myTestWebCalculator.Object.CalculateNumberOfHits(myTestWebCollector.Object, keyword);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void CalculateNumberOfHitsTest4()
        {
            var myTestWebCollector = new Mock<IWebCollector>();

            var myTestWebCalculator = new Mock<WebCalculator>();

            IWebCalculator myWebCalculator = new WebCalculator();

            myTestWebCollector.SetupAllProperties();
            myTestWebCollector.Object.Equals(null);

            string keyword = "trump";
            var result = myTestWebCalculator.Object.CalculateNumberOfHits(myTestWebCollector.Object, keyword);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void CalculateNumberOfHitsTest5()
        {
            var myTestWebCollector = new Mock<IWebCollector>();

            var myTestWebCalculator = new Mock<WebCalculator>();

            IWebCalculator myWebCalculator = new WebCalculator();

            myTestWebCollector.SetupAllProperties();
            myTestWebCollector.Object.HtmlCode = "trumptrumptrump";

            string keyword = null;
            var result = myTestWebCalculator.Object.CalculateNumberOfHits(myTestWebCollector.Object, keyword);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void CalculateNumberOfHitsTest6()
        {
            var myTestWebCollector = new Mock<IWebCollector>();

            var myTestWebCalculator = new Mock<WebCalculator>();

            IWebCalculator myWebCalculator = new WebCalculator();

            myTestWebCollector.SetupAllProperties();
            myTestWebCollector.Object.HtmlCode = "trumptrumptrump";

            string keyword = string.Empty;
            var result = myTestWebCalculator.Object.CalculateNumberOfHits(myTestWebCollector.Object, keyword);

            Assert.AreEqual(-1, result);
        }
    }
}
