using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
    public class Program
    {
        IWebCollector myWebCollector = new WebCollector();
        IWebCalculator myWebCalculator = new WebCalculator();

        public string CheckWord { get; set; }

        /// <summary>
        /// Save the URL
        /// </summary>
        /// <param name="website"></param>
        public void SaveWebAddress(string website)
        {
            myWebCollector.GetHTMLFromUrl(website);
        }

        /// <summary>
        /// sends the saved URL and the "keyword" to match with the content
        /// </summary>
        /// <returns>total amount of matches from the keyword</returns>
        public int Calc()
        {
            int count = myWebCalculator.CalculateNumberOfHits(myWebCollector, CheckWord);
            return count;
        }
    }
}
