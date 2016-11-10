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
            //Здесь нужно вставить свой запрос к API.
            var xmlDoc = XDocument.Load("http://svcs.ebay.com/services/search/FindingService/v1?OPERATION-NAME=findItemsByKeywords&SERVICE-VERSION=1.0.0&SECURITY-APPNAME=AlexRozh-testApp-PRD-b45f64428-459236e4&RESPONSE-DATA-FORMAT=XML&REST-PAYLOAD&keywords=harry%20potter%20phoenix&itemFilter.name=MaxPrice&itemFilter.value=10&paginationInput.entriesPerPage=12");
            return xmlDoc;
        }
    }
}
