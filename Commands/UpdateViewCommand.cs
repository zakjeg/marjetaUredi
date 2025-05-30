﻿using marjetaUredi.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace marjetaUredi.Commands
{
    public class UpdateViewCommand : ICommand
    {

        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true; 
        }

        public void Execute(object? parameter)
        {
            Debug.WriteLine("Executing UpdateViewCommand with parameter!!");

            if (parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "UserList")
            {
                viewModel.SelectedViewModel = new UserListViewModel();
            }
            else if (parameter.ToString() == "UserInfo")
            {
                viewModel.SelectedViewModel = new UserInfoViewModel();
            }
            else if (parameter.ToString() == "Activities")
            {
                viewModel.SelectedViewModel = new ActivitiesViewModel();
            }
            else if (parameter.ToString() == "AddUser")
            {
                viewModel.SelectedViewModel = new AddUserViewModel();
            }
            else
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
        }
    }
}
