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
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public MainViewModel()
        {
            LoadMenu();
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();


        }

    }
}
