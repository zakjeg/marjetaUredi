using marjetaUredi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class AddUserView : UserControl, INotifyPropertyChanged
    {
        public AddUserView()
        {
            InitializeComponent();
            DataContext = this;
        }
        AddUserViewModel addUserListViewModel = new AddUserViewModel();
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                OnPropertyChanged();
            }
        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            //Klic insert metode v UserRepozitoriju
        }

        //Metoda za bolj preprost klic OnPropChang.(), (Ni treba vnašat ime spremenlivke)
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
