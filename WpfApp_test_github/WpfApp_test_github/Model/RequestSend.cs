using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WpfApp_test_github.ViewModel
{
    /// <summary>
    /// Класс для отправления запроса на сторонний API.
    /// </summary>
    class RequestSend
    {

        /// <summary>
        /// Метод для получения api.
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string GET(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }
    }
}
