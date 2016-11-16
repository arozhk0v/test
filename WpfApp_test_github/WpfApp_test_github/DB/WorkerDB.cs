using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_test_github.Model;

namespace WpfApp_test_github.DB
{

    /// <summary>
    /// Класс для работы с БД.
    /// </summary>
    public class WorkerDB
    {
        private string json;
        public static string Json { get; set; }

        public static Product Product_ { get; set; }


        /// <summary>
        /// Конструктор в который нужно передать нужный url.
        /// </summary>
        /// <param name="url"></param>
        public WorkerDB(string url)
        {
            Json = RequestSend.GET(url);
            Product_ = JsonConvert.DeserializeObject<Product>(Json);
        }

        public void AddNewProduct()
        {
            ProductContext context = new ProductContext();

            // Добавить в DbSet
            context.Products.Add(Product_);

            // Сохранить изменения в базе данных
            context.SaveChanges();
        }

    }
}
