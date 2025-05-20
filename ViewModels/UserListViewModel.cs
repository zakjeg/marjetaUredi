using marjetaUredi.Data.DataModels;
using marjetaUredi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace marjetaUredi.ViewModels
{
    public class UserListViewModel : BaseViewModel
    {
        public ObservableCollection<User> usersList { get; set; }
        public UserListViewModel()
        {
            UsersRepository usersRepository = new UsersRepository();
            usersList = usersRepository.getUsersList();
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


    }
}
