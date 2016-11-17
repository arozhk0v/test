using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_test_github.Model
{
    /// <summary>
    /// Класс для сериализации
    /// </summary>
    public class Product
    {

        public int Id { get; set; }
        public string @Base { get; set; }

        public DateTime Date { get; set; }

        public Rates rates { get; set; }

    }
}
