using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using marjetaUredi.ViewModels;


namespace marjetaUredi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            
            DataContext = new MainViewModel(); 
        }



        //Osnovne funkcije za opravljanje z oknom 
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e){ DragMove(); }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }else
            {
                WindowState = WindowState.Maximized;
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close(); //zapre okno
                     //Application.Current.Shutdown(); //zapre celotno aplicacijo
        }

        private void btnUnused_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUnused_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gumb še ni bindan");

        }
    }
}