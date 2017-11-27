﻿using AppTransportistaTDM.Models;
using AppTransportistaTDM.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppTransportistaTDM.ViewModels
{
    public class LoginViewModel
    {
        #region Attributes
        public DataService dataService;
        public NavigationService navigationService { get; set; }

        public DialogService dialogService { get; set; }

        private ApiService apiService;
        #endregion

        #region Properties
        public string User { get; set; }
        public string Password { get; set; }
        public bool IsRemembered { get; set; }
        //public bool IsRunning //servira para el activity indicator 
        //{
        //    set
        //    {
        //        if (isRunning != value)
        //        {
        //            isRunning = value;
        //            /* if (PropertyChanged!=null) {
        //                 PropertyChanged(this, new PropertyChangedEventArgs("IsRunning"));
        //             }*///es lo mismo que lo de abajo
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
        //        }
        //    }
        //    get
        //    {
        //        return isRunning;
        //    }
        //}
        #endregion

        #region Methods
        public LoginViewModel()
        {
         
                dialogService = new DialogService();
                navigationService = new NavigationService();
                dataService = new DataService();
                apiService = new ApiService();
                //IsRemembered = true;

        }
        #endregion


        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }

        private async void Login()
        {
            if (string.IsNullOrEmpty(User))
            {
                await dialogService.ShowMessage("Error", "Debes Ingresar un Usuario");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await dialogService.ShowMessage("Error", "Debes Ingresar una Contraseña");
                return;
            }

            //IsRunning = true;
            var response = new Response();//video 118 para logear ssin conexion.
                                          //if (netService.IsConnected())
                                          //{
                                          //    response = await apiService.Login(User, Password);
                                          //}
                                          //else
                                          //{
                                          //    response = dataService.Login(User, Password);
                                          //}
            response = await apiService.Login(User, Password);
            //IsRunning = false;

            if (!response.IsSuccess)
            {
                await dialogService.ShowMessage("Error", response.Message);
                return;
            }
            //var user = (User)response.Result;
            //user.IsRemembered = IsRemembered;
            //user.Password = Password;

            //dataService.InsertUser(user);

            navigationService.SetMainPage();
        }
        #endregion

    }
}
