using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
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
using Newtonsoft.Json;
using marjetaUredi.ViewModels;


namespace marjetaUredi.Views
{
    /// <summary>
    /// Interaction logic for ActivitiesView.xaml
    /// </summary>
    public partial class ActivitiesView : UserControl
    {
        public ActivitiesView()
        {
            InitializeComponent();

            ActivitiesViewModel activitiesViewModel = new ActivitiesViewModel();

            dtGrid.DataContext = activitiesViewModel.WorkshopsList;


            Debug.WriteLine("----------- Test če program pride do tu-------------");




        }

    }
}
