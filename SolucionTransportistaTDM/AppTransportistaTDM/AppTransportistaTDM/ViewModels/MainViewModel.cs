using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportistaTDM.ViewModels
{
    public  class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public LoginViewModel NewLogin { get; set; }
        //public  NewLogin 
        #endregion

        public MainViewModel()
        {
            LoadMenu();
            //Create Views
            NewLogin = new LoginViewModel();
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
        }

    }
}
