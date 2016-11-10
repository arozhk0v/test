using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WpfApp_test_github.Model
{
    /// <summary>
    /// Класс для отправки запроса на api ebay.
    /// </summary>
    class RequestSend
    {
        private XDocument xml_document;
        public XDocument Xml_document { get { return xml_document; } set { xml_document = value; } }

        public RequestSend()
        {
            Xml_document = xml_document;
        }

        /// <summary>
        /// Отправить запрос к API.
        /// </summary>
        public static XDocument Request()   
        {
            var xmlDoc = XDocument.Load("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
            return xmlDoc;
        }
    }
}
