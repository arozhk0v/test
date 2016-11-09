using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_test_github.Model
{
    /// <summary>
    /// Тестовый класс Персона.
    /// </summary>
    class Person : INotifyPropertyChanged
    {
        private string name;

        public string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }

        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
