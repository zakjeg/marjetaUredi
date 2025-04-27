using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.IO;
using System.Diagnostics;

namespace marjetaUredi.Views
{
    /// <summary>
    /// Interaction logic for UserListView.xaml
    /// </summary>
    public partial class UserListView : UserControl
    {
        public UserListView()
        {
            InitializeComponent();

            string connectionCredentials = (System.IO.Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Assets") + System.IO.Path.DirectorySeparatorChar) + "databaseConnection.txt";
            if (File.Exists(connectionCredentials))
            {
                Debug.WriteLine($"File found - {connectionCredentials}");
            }
            else
            {
                Debug.WriteLine($"File not found - {connectionCredentials}");
            }





            string connectionString = File.ReadAllText(connectionCredentials);

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand command = new MySqlCommand("SELECT * FROM users", connection);

            connection.Open();

            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());

            connection.Close();

            dtGrid.DataContext = dataTable; 
        }
    }
}
