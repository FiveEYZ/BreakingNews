namespace BreakingNews
{
    public interface IWebCollector
    {
        /// <summary>
        /// Html code from last search
        /// </summary>
        string HtmlCode { get; set; }

        /// <summary>
        /// Save html code from given URL to htmlCode property
        /// If url is NULL, empty or not containing "http", save string.Empty
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        void GetHTMLFromUrl(string url);
    }
}