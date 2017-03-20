using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BreakingNews;
using Moq;

namespace BreakingNewsTest
{
    [TestFixture]
    public class WebCollectorTest
    {
        [Test]
        public void GetHTMLFromUrlTest1()
        {
            IWebCollector myWebCollector = new WebCollector();
            string url = null;
            myWebCollector.GetHTMLFromUrl(url);
            var result = myWebCollector.HtmlCode;
            Assert.AreEqual(string.Empty, result);
        }
        [Test]
        public void GetHTMLFromUrlTest2()
        {
            IWebCollector myWebCollector = new WebCollector();
            string url = "";
            myWebCollector.GetHTMLFromUrl(url);
            var result = myWebCollector.HtmlCode;
            Assert.AreEqual(string.Empty, result);
        }
        [Test]
        public void GetHTMLFromUrlTest3()
        {
            IWebCollector myWebCollector = new WebCollector();
            string url = "www.google.se";
            myWebCollector.GetHTMLFromUrl(url);
            var result = myWebCollector.HtmlCode;
            Assert.AreEqual(string.Empty, result);
        }
        [Test]
        public void GetHTMLFromUrlTest4()
        {
            //if a proper URL is sent then the result will be much larger than 20
            IWebCollector myWebCollector = new WebCollector();
            string url = "http://www.aftonbladet.se";
            myWebCollector.GetHTMLFromUrl(url);
            var result = myWebCollector.HtmlCode;
            Assert.IsTrue (result.Count() > 20);
        }
    }
}
