using marjetaUredi.Commands;
using marjetaUredi.Data.DataModels;
using marjetaUredi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using marjetaUredi.Commands;

namespace marjetaUredi.ViewModels
{
    public class UserListViewModel : BaseViewModel
    {
        public ObservableCollection<User> usersList { get; set; }
        public UserListViewModel()
        {
            UsersRepository usersRepository = new UsersRepository();
            usersList = usersRepository.getUsersList();

            AddUserCommand addUserCommand = new AddUserCommand();
        }
 

        private User _SelectedItem;

        public User SelectedItem
        {
            get { return _SelectedItem; }
            set 
            {
                _SelectedItem = value;
                OnPropertyChanged();
            }
        }

        public ICommand addUser { get; set; }
        public ICommand removeUser { get; set; }

        

    }
}
