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

namespace marjetaUredi.ViewModels
{
    // we need INofityPropertyChanged?
    class AddUserViewModel : BaseViewModel
    {

        UsersRepository usersRepository = new UsersRepository();


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
