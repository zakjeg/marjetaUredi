using marjetaUredi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace marjetaUredi.Views
{
    /// <summary>
    /// Interaction logic for AddUserView.xaml
    /// </summary>
    public partial class AddUserView : UserControl
    {
        public AddUserView()
        {
            InitializeComponent();
            AddUserViewModel vm = new AddUserViewModel();
            DataContext = vm;
        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            //Klic insert metode v UserRepozitoriju
            Debug.WriteLine("Test");
        }

    }
}
