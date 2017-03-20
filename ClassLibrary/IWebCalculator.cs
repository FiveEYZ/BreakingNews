using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
    public interface IWebCalculator
    {
        /// <summary>
        /// Calculates the number of occurences for given keyword in given html code.
        /// Takes a IWebCollector as a parameter
        /// Returns -1 if webcoll is NULL or Webcollector.Htmlcode property is
        /// NULL/empty or if the keyword is NULL/empty
        /// </summary>
        int CalculateNumberOfHits(IWebCollector webColl, string keyword);
    }
}
