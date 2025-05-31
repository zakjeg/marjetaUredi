using marjetaUredi.Commands;
using marjetaUredi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using marjetaUredi.Commands;

namespace marjetaUredi.ViewModels
{
    // we need INofityPropertyChanged?
    internal class AddUserViewModel : BaseViewModel
    {
        UsersRepository usersRepository;
        public RelayCommand AddCommand => new RelayCommand(execute => AddUser(UserName, LastName, UserClass, UserAge));
        public AddUserViewModel() 
        {
            this.usersRepository = new UsersRepository();
        }

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
        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                OnPropertyChanged();
            }
        }
        private int _UserAge;
        public int UserAge
        {
            get { return _UserAge; }
            set
            {
                _UserAge = value;
                OnPropertyChanged();
            }
        }
        private int _UserClass;
        public int UserClass
        {
            get { return _UserClass; }
            set
            {
                _UserClass = value;
                OnPropertyChanged();
            }
        }

        private void AddUser(string FirstName, string LastName, int UserClass, int UserAge)
        {
            usersRepository.addUser(FirstName, LastName, UserClass, UserAge);
        }





        //private string _BoundText;

        //public event PropertyChangedEventHandler? PropertyChanged;

        //public string BoundText
        //{ 
        //	get { return _BoundText; }
        //	set 
        //	{	
        //		_BoundText = value;
        //		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
        //	}
        //}


    }
}
