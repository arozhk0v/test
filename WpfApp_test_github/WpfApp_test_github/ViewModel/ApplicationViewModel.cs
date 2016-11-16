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
        private Person person;

        public static Product Product_ { get; set; }
        private string json;

        public static string Json { get; set; }
        public ObservableCollection<Person> Persons { get; set; }

        public ApplicationViewModel()
        {
            Json = RequestSend.GET("http://api.fixer.io/latest?symbols=USD,GBP");

            Product_ = JsonConvert.DeserializeObject<Product>(Json);

            //ProductContext context = new ProductContext();

            //// Добавить в DbSet
            //context.Products.Add(Product_);

            //// Сохранить изменения в базе данных
            //context.SaveChanges();

            Persons = new ObservableCollection<Person>
            {
                new Person { Name = "Григорий" },
                new Person { Name = "Сергей" },
                new Person { Name = "Петр" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        



        

    }
}
