#if NetFX
using System.Web;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///   Performs a response redirect and allows the url to be populated with string format parameters.
        /// </summary>
        /// <param name = "response">The HttpResponse to perform on.</param>
        /// <param name = "urlFormat">The URL including string.Format placeholders.</param>
        /// <param name = "endResponse">If set to <c>true</c> the response will be terminated.</param>
        /// <param name = "values">The values to the populated.</param>
        public static void Redirect(this HttpResponse response, string urlFormat, bool endResponse,
            params object[] values)
        {
            var url = string.Format(urlFormat, values);
            response.Redirect(url, endResponse);
        }

        /// <summary>
        ///   Performs a response redirect and allows the url to be populated with a query string.
        /// </summary>
        /// <param name = "response">The HttpResponse to perform on.</param>
        /// <param name = "url">The URL.</param>
        /// <param name = "queryString">The query string.</param>
        public static void Redirect(this HttpResponse response, string url, UriQueryString queryString)
        {
            response.Redirect(url, queryString, true);
        }

        /// <summary>
        ///   Performs a response redirect and allows the url to be populated with a query string.
        /// </summary>
        /// <param name = "response">The HttpResponse to perform on.</param>
        /// <param name = "url">The URL.</param>
        /// <param name = "queryString">The query string.</param>
        /// <param name = "endResponse">If set to <c>true</c> the response will be terminated.</param>
        public static void Redirect(this HttpResponse response, string url, UriQueryString queryString,
            bool endResponse)
        {
            url = queryString.ToString(url);
            response.Redirect(url, endResponse);
        }

        /// <summary>
        ///   Returns a 404 to the client and ends the response.
        /// </summary>
        /// <param name = "response">The HttpResponse to perform on.</param>
        public static void SetFileNotFound(this HttpResponse response)
        {
            response.SetFileNotFound(true);
        }

        /// <summary>
        ///   Returns a 404 to the client and optionally ends the response.
        /// </summary>
        /// <param name = "response">The HttpResponse to perform on.</param>
        /// <param name = "endResponse">If set to <c>true</c> the response will be terminated.</param>
        public static void SetFileNotFound(this HttpResponse response, bool endResponse)
        {
            response.SetStatus(404, "Not Found", endResponse);
        }

        /// <summary>
        ///   Returns a 500 to the client and ends the response.
        /// </summary>
        /// <param name = "response">The HttpResponse to perform on.</param>
        public static void SetInternalServerError(this HttpResponse response)
        {
            response.SetInternalServerError(true);
        }

        /// <summary>
        ///   Returns a 500 to the client and optionally ends the response.
        /// </summary>
        /// <param name = "response">The HttpResponse to perform on.</param>
        /// <param name = "endResponse">If set to <c>true</c> the response will be terminated.</param>
        public static void SetInternalServerError(this HttpResponse response, bool endResponse)
        {
            response.SetStatus(500, "Internal Server Error", endResponse);
        }
    }
}
#endif