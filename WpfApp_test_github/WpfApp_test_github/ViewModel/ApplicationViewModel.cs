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

namespace WpfApp_test_github
{
    /// <summary>
    /// View Model
    /// </summary>
    class ApplicationViewModel : INotifyPropertyChanged
    {

        public ApplicationViewModel()
        {
            //Тестирование запроса и сериализации.
            //Json = RequestSend.GET("http://api.fixer.io/latest?symbols=USD,GBP");
            //Product_ = JsonConvert.DeserializeObject<Product>(Json);


            // Добавление нового значения в БД.
            //WorkerDB add = new WorkerDB("http://api.fixer.io/2000-01-03");
            //add.AddNewProduct();

        }





        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        



        

    }
}
