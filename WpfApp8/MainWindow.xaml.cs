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
using WpfApp8.ViewModel;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel1 _mainViewModel;
        
        public MainWindow()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel1();
            this.DataContext = _mainViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var person = new Model.Person1
            {
                Id = 1,
                FirstName = "Sumit",
                LastName = "Kumar",
                Salary = Convert.ToDecimal("8000")
            };
            _mainViewModel.AddPerson(person);
        }
    }
}
