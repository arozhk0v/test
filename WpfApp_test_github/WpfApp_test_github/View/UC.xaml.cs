using System;
using System.Collections.Generic;
using System.Linq;
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
using WpfApp_test_github.DB;
using System.Data.Entity;

namespace WpfApp_test_github.View
{
    /// <summary>
    /// Interaction logic for UC.xaml
    /// </summary>
    public partial class UC : UserControl
    {

        ProductContext db;
        public UC()
        {
            InitializeComponent();
            db = new ProductContext();
            db.Products.Load();
            productsGrid.ItemsSource = null;
            productsGrid.ItemsSource = db.Products.Local.ToBindingList();  //привязка к кэшу
            WorkerDB.DeleteAllRows("Products");
        }

    }
}
