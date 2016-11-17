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
        public static string Json { get; set; }

        public static Product Product_ { get; set; }


        /// <summary>
        /// Метод удаления всех строк в таблице
        /// </summary>
        public static void DeleteAllRows(string TableName)
        {
            ProductContext context = new ProductContext();

            context.Database.ExecuteSqlCommand("TRUNCATE TABLE [" + TableName + "]");
        }


        /// <summary>
        /// Добавление нового элемента в таблицу
        /// </summary>
        /// <param name="url"></param>
        public static void AddNewProduct(string url)
        {
            Json = RequestSend.GET(url);
            Product_ = JsonConvert.DeserializeObject<Product>(Json);

            ProductContext context = new ProductContext();

            // Добавить в DbSet
            context.Products.Add(Product_);

            // Сохранить изменения в базе данных
            context.SaveChanges();
        }


        /// <summary>
        /// Добавление новых элементов в таблицу.
        /// </summary>
        public static void AddNewProducts(DateTime date1, DateTime date2)
        {
            for (var currentDay = date1; currentDay <= date2; currentDay = currentDay.AddDays(1))
            {
                AddNewProduct("http://api.fixer.io/" + currentDay.Year + "-" + currentDay.ToString("MM") + "-" + currentDay.ToString("dd"));
            }
            
        }




    }
}
