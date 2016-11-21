using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfApp_test_github.DB;
using WpfApp_test_github.Model;
using WpfApp_test_github.View;


namespace WpfApp_test_github
{
    /// <summary>
    /// View Model
    /// </summary>
    class ApplicationViewModel 
    {


        public ApplicationViewModel()
        {

            // Добавление нового значения в таблицу Products.
            //WorkerDB.AddNewProduct("http://api.fixer.io/latest");
            
            //Удаление всех строк из таблице.
            WorkerDB.DeleteAllRows("Products");
            var date1 = new DateTime(2000,01,01);
            var date2 = new DateTime(2000,01,05);

            WorkerDB.AddNewProducts(date1, date2);
        }  

    }
}
