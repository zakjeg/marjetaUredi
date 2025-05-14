using marjetaUredi.Data.DataModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marjetaUredi.Data.Repositories
{
    public class WorkshopsRepository
    {
        private string _connectionCredentials;
        private string _tableName = "workshops";

        public WorkshopsRepository()
        {
            _connectionCredentials = getConnectionString();
        }


        public ObservableCollection<Workshop> getWorkshopsList()
        {
            MySqlConnection connection = new MySqlConnection(_connectionCredentials);
            MySqlCommand command = new MySqlCommand($"SELECT * FROM {_tableName}", connection);

            DataTable workshops = new DataTable();

            connection.Open();
            workshops.Load(command.ExecuteReader());
            connection.Close();

            return WorkshopDataTableToCollection(workshops);

        }

        private ObservableCollection<Workshop> WorkshopDataTableToCollection(DataTable Workshop)
        {
            ObservableCollection<Workshop> _workshops = new ObservableCollection<Workshop>();

            foreach (DataRow row in Workshop.Rows)
            {
                Workshop workshop = new Workshop(
                    Convert.ToInt32(row["ID"]),
                    row["Name"].ToString(),
                    row["About"].ToString(),
                    row["Mentor"].ToString(),
                    Convert.ToInt32(row["AgeLimit"]),
                    Convert.ToInt32(row["AgeRequirement"])
                    );
                Debug.WriteLine($"--- workshop: {workshop.Name}, {workshop.Mentor} added ;)");
            }

            return _workshops;
        }



        private string getConnectionString()
        {
            string connectionCredentials = (System.IO.Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Assets") + System.IO.Path.DirectorySeparatorChar) + "databaseConnection.txt";


            Debug.WriteLine($"--- Connection string path: {connectionCredentials}");

            if (!File.Exists(connectionCredentials))
            {
                Debug.WriteLine($"File not found - {connectionCredentials}");
            }
            string connectionString = File.ReadAllText(connectionCredentials);

            return connectionString;
        }
    }
}
