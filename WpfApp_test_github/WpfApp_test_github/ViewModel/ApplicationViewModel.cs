using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using WpfApp_test_github.DB;
using WpfApp_test_github.ViewModel;
using WpfApp_test_github.View;
using System.Windows.Input;
using System.Data.Entity;


namespace WpfApp_test_github
{
    /// <summary>
    /// View Model
    /// </summary>
    class ApplicationViewModel : DependencyObject
    {
        
        //private DateTime _startDate = DateTime.Now;
        //private DateTime _endDate = DateTime.Now;

        //public DateTime StartDate 
        //{
        //    get { return _startDate; }
        //    set { _startDate = value; OnPropertyChanged("StartDate"); } 
        //}

        //public DateTime EndDate
        //{
        //    get { return _endDate; }
        //    set { _endDate = value; OnPropertyChanged("EndDate"); }
        //}


        //public void OnPropertyChanged(string name)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //        handler(this, new PropertyChangedEventArgs(name));
        //}


        public DateTime StartDate
        {
            get { return (DateTime)GetValue(StartDateProperty); }
            set { SetValue(StartDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StartDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartDateProperty =
            DependencyProperty.Register("StartDate", typeof(DateTime), typeof(ApplicationViewModel), new PropertyMetadata(DateTime.Now, StartDate_Changed));

        private static void StartDate_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as ApplicationViewModel;
            if (current != null)
            {
                WorkerDB.AddNewProducts(current.StartDate, current.EndDate);
            }
        }

        public DateTime EndDate
        {
            get { return (DateTime)GetValue(EndDateProperty); }
            set { SetValue(EndDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EndDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EndDateProperty =
            DependencyProperty.Register("EndDate", typeof(DateTime), typeof(ApplicationViewModel), new PropertyMetadata(DateTime.Now, EndDate_Changed));

        private static void EndDate_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as ApplicationViewModel;
            if (current != null)
            {
                WorkerDB.AddNewProducts(current.StartDate, current.EndDate);
            }
        }


        /// <summary>
        /// Конструктор.
        /// </summary>
        public ApplicationViewModel()
        {

            // Добавление нового значения в таблицу Products.
            //WorkerDB.AddNewProduct("http://api.fixer.io/latest");
            
            //Удаление всех строк из таблице.
            WorkerDB.DeleteAllRows("Products");
            //var date1 = new DateTime(2000,01,01);
            //var date2 = new DateTime(2000,01,05);
            ClickCommand = new Command(arg => ClickMethod());

            //WorkerDB.AddNewProducts(StartDate, EndDate);
        }


        #region Commands

        /// <summary>
        /// Get or set ClickCommand.
        /// </summary>
        public ICommand ClickCommand { get; set; }

        #endregion


        #region Methods

        /// <summary>
        /// Click method.
        /// </summary>
        private void ClickMethod()
        {
            WorkerDB.AddNewProducts(StartDate, EndDate);
            MessageBox.Show("This is click command.");

            
            //MainWindow mw = new MainWindow();
            //UC ui = new UC();
            //ui.DataContext = 
            //G1.Children.Add(ui);
            //Grid.SetRow(ui, 2);
        }

        #endregion
    }
}
