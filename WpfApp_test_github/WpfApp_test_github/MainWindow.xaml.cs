using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp_test_github.View;

namespace WpfApp_test_github
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UC ui = new UC();
            G1.Children.Add(ui);
            Grid.SetRow(ui, 2);
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    UC ui = new UC();
        //    StackPanel1.Children.Add(ui);
        //}

    }
}
