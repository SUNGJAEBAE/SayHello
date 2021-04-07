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

namespace BikeShop
{
    /// <summary>
    /// Contact.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Contact : Page
    {
        public Contact()
        {
            InitializeComponent();
            var h = new Human();
            h.FirstName = "Nick";
            h.HasDrivingLiscense = true;

            var c = new Car();
            c.Speed = 100;
            c.Color = Colors.Red;
            c.Driver = h;
        }
        private void Greet(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello");

        }
    }
}
