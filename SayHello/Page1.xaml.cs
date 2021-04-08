using BusinessLogic;
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

namespace SayHello
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        public Test test;
        public Page1()
        {
            InitializeComponent();
             test= new Test();
            var cars = new List<Car>();
            for(int i=0; i<10; i++)
            {
                cars.Add(new Car() { Speed = i * 10 });
            }
            DataContext = cars;

        }
    }
    public class Test
    {
        public int Speed { get; set; }
        public Test()
        {
            Speed = 10;
        }
    }
}
