﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace HSNXT
{
    public class WebScrapper
    {
        private readonly List<Cookie> _cookies = new List<Cookie>();

        public string Get(string url, IDictionary<string, string> queryStringParameters)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url));

            var fullUrl = BuildUrl(url, queryStringParameters);
            return MakeRequest(fullUrl, null);
        }

        public string Post(string url, IDictionary<string, string> formParameters,
            IDictionary<string, string> queryStringParameters)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url));

            var fullUrl = BuildUrl(url, queryStringParameters);
            return MakeRequest(fullUrl, request =>
            {
                var formQuery = BuildQueryString(formParameters);
                var formQueryBytes = Encoding.UTF8.GetBytes(formQuery);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = formQueryBytes.Length;

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(formQueryBytes, 0, formQueryBytes.Length);
                    requestStream.Flush();
                }
            });
        }

        public IEnumerable<Cookie> Cookies => _cookies;

        public string UserAgent { get; set; }

        private void SetupRequest(HttpWebRequest request)
        {
            request.AllowAutoRedirect = false;
            request.UserAgent = UserAgent;
        }

        private static string BuildUrl(string url, IEnumerable<KeyValuePair<string, string>> queryStringParameters)
        {
            var builder = new StringBuilder(url);
            var queryString = BuildQueryString(queryStringParameters);
            if (queryString != null)
                builder.Append("?").Append(queryString);

            return builder.ToString();
        }

        private static string BuildQueryString(IEnumerable<KeyValuePair<string, string>> queryStringParameters)
        {
            var akvp = queryStringParameters as KeyValuePair<string, string>[] ?? queryStringParameters?.ToArray();
            if (akvp == null || !akvp.Any())
                return null;

            var queryString = new StringBuilder();
            foreach (var kvp in akvp)
                queryString.AppendFormat("{0}={1}&", kvp.Key, Uri.EscapeUriString(kvp.Value));
            queryString.Remove(queryString.Length - 1, 1);
            return queryString.ToString();
        }

        private string MakeRequest(string url, Action<HttpWebRequest> requestInitializer)
        {
            var cookieContainer = new CookieContainer();
            foreach (var cookie in _cookies)
                cookieContainer.Add(cookie);

            var request = (HttpWebRequest) WebRequest.Create(url);
            SetupRequest(request);
            request.CookieContainer = cookieContainer;
            requestInitializer?.Invoke(request);

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                var responseCookies = response.Cookies;
                foreach (Cookie cookie in responseCookies)
                    _cookies.Add(cookie);

                if (response.StatusCode == HttpStatusCode.Moved || response.StatusCode == HttpStatusCode.Redirect)
                {
                    var location = response.Headers[HttpResponseHeader.Location];
                    return Get(location, null);
                }

                using (var responseStream = response.GetResponseStream())
                using (var reader = new StreamReader(responseStream ?? throw new InvalidOperationException()))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }

    public static class QueryString
    {
        public static IDictionary<string, string> Create(string key, string value)
        {
            var dictionary = new Dictionary<string, string>
            {
                {key, value}
            };
            return dictionary;
        }

        public static IDictionary<string, string> Append(this IDictionary<string, string> dictionary, string key,
            string value)
        {
            if (dictionary == null)
                throw new ArgumentNullException(nameof(dictionary));
            dictionary.Add(key, value);
            return dictionary;
        }
    }
}