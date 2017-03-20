using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;

namespace BreakingNews
{
    public class WebCalculator : IWebCalculator
    {
        //WebClient client = new WebClient();

        /// <summary>
        /// Get the URL and Keuwrod specified by the user
        /// Here we also download all the vontent from the URL
        /// so we can match it with the keyword and get something to return
        /// </summary>
        /// <param name="webColl"></param>
        /// <param name="keyword"></param>
        /// <returns>int containing the amount of matches</returns>
        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            int wordCount;
            if (!(webColl == null))
            {
                if (webColl.HtmlCode == null || webColl.HtmlCode == string.Empty)
                {
                    return wordCount = -1;
                }
                else if (keyword == null || keyword == string.Empty)
                {
                    return wordCount = -1;
                }
                else
                {
                    return wordCount = Regex.Matches(webColl.HtmlCode, keyword).Count;
                }
                //string content = client.DownloadString(webColl.HtmlCode);
                //int wordCount = Regex.Matches(content, keyword).Count;
            }
            else
            {
                return wordCount = -1;
            }
        }
    }
}