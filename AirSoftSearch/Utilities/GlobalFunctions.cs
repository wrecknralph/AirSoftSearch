using System.Net;

namespace AirSoftSearch.Utilities
{
    public static class GlobalFunctions
    {
        public static string CreateUrlImage(string sUrl)
        {          

            string url = $"https://api.screenshotone.com/take?url={WebUtility.UrlEncode(sUrl)}&full_page=false&format=png&block_cookie_banners=true&access_key=VI6y_F5Ub0cNRw";
            return url;
        }        
    }
}
