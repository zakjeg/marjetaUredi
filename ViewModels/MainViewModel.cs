using marjetaUredi.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace marjetaUredi.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedVidwModel; 

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedVidwModel; }
            set 
            { 
                _selectedVidwModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }


        public ICommand updateViewCommand { get; set; } 
        public MainViewModel()
        {
            updateViewCommand = new UpdateViewCommand(this);
        }

    }
}
