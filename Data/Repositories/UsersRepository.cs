using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using marjetaUredi.Data.DataModels;
using System.Windows.Navigation;
using System.Diagnostics;
using System.IO;

namespace marjetaUredi.Data.Repositories
{
    public class UsersRepository
    {
        private string _connectionCredentials;
        private string _tableName = "users";
        public UsersRepository()
        {
            _connectionCredentials = getConnectionString(); ;
        }

        public ObservableCollection<User> getUsersList()
        {
            //vrne seznam uporabnikov iz baze (DataTable)
            MySqlConnection connection = new MySqlConnection(_connectionCredentials);
            MySqlCommand command = new MySqlCommand($"SELECT * FROM {_tableName}", connection);

            DataTable users = new DataTable();

            connection.Open();
            users.Load(command.ExecuteReader());
            connection.Close();

            return UserDataTableToCollection(users);
        }

        //METHOD FOR TEST PURPOSES
        public void addUser(string FirstName, string LastName, int UserClass, int Age)
        {
            MySqlConnection connection = new MySqlConnection(_connectionCredentials);
            MySqlCommand command = new MySqlCommand($"INSERT INTO {_tableName} (FirstName, LastName, Class, Age, FotoPermit, AddInfo, RfidUID) VALUES (@FirstName, @LastName, @Class, @Age, @FotoPermit, @AddInfo, @RfidUID)", connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Class", UserClass);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@FotoPermit", 1);
            command.Parameters.AddWithValue("@AddInfo", "no add info");
            command.Parameters.AddWithValue("@RfidUID", 0923467);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private ObservableCollection<User> UserDataTableToCollection(DataTable users)
        {
            //pretvori DataTable v ObservableCollection in ga vrne
            ObservableCollection<User> _users = new ObservableCollection<User>();
            foreach (DataRow row in users.Rows)
            {
                User user = new User(
                    Convert.ToInt32(row["ID"]),
                    row["FirstName"].ToString(),
                    row["LastName"].ToString(),
                    Convert.ToInt32(row["Class"]),
                    Convert.ToInt32(row["Age"]),
                    Convert.ToByte(row["FotoPermit"]),
                    row["AddInfo"].ToString(),
                    row["RfidUID"].ToString()
                );
                Debug.WriteLine($"--- User: {user.FirstName} {user.LastName} - {user.ID}");
                _users.Add(user);
            }
            return _users;
        }

        //public void AddUser(User user)
        //{
        //    //doda uporabnika v bazo
        //    MySqlConnection connection = new MySqlConnection(_connectionCredentials);
        //    MySqlCommand command = new MySqlCommand($"INSERT INTO {_tableName} (FirstName, LastName, Class, Age, FotoPermit, AddInfo, RfidUID) VALUES (@FirstName, @LastName, @Class, @Age, @FotoPermit, @AddInfo, @RfidUID)", connection);
        //    command.Parameters.AddWithValue("@FirstName", user.FirstName);
        //    command.Parameters.AddWithValue("@LastName", user.LastName);
        //    command.Parameters.AddWithValue("@Class", user.Class);
        //    command.Parameters.AddWithValue("@Age", user.Age);
        //    command.Parameters.AddWithValue("@FotoPermit", user.FotoPermit);
        //    command.Parameters.AddWithValue("@AddInfo", user.AddInfo);
        //    command.Parameters.AddWithValue("@RfidUID", user.RfidUID);    
        //    connection.Open();
        //    command.ExecuteNonQuery();
        //    connection.Close();
        //}

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
