using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp_test_github.Model;

namespace WpfApp_test_github
{
    /// <summary>
    /// View Model
    /// </summary>
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private Person person;
        public ObservableCollection<Person> Persons { get; set; }

        public ApplicationViewModel()
        {
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
