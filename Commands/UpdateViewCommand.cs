﻿using marjetaUredi.ViewModels;
using System;
using System.Collections.Generic;
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
            Console.WriteLine("Executing UpdateViewCommand with parameter!!");
            MessageBox.Show("To kao laufa :shrug: ");

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
            else
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
        }
    }
}
