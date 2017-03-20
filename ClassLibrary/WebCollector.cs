using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
    public class WebCollector : IWebCollector
    {
        WebClient client = new WebClient();
        private string _htmlCode;
        public string HtmlCode
        {
            get
            {
                return _htmlCode;
            }
            set
            {
                _htmlCode = value;
            }
        }

        /// <summary>
        /// get and save the URL specified by the user
        /// </summary>
        /// <param name="url"></param>
        public void GetHTMLFromUrl(string url)
        {
            if (url == null || !(url.Contains("http")) || (url.Count() < 0))
                _htmlCode = string.Empty;
            else
                _htmlCode = client.DownloadString(url);
                //_htmlCode = url;
        }
    }
}
