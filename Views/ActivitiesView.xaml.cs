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


            string connectionCredentials = (System.IO.Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Assets") + System.IO.Path.DirectorySeparatorChar) + "databaseConnection.txt";
            if (!File.Exists(connectionCredentials))
            {
                Debug.WriteLine($"File not found - {connectionCredentials}");
            }


            string connectionString = File.ReadAllText(connectionCredentials);

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand command = new MySqlCommand("SELECT * FROM workshops", connection);

            connection.Open();

            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());

            connection.Close();

            dtGrid.DataContext = dataTable;

        }
    }
}
