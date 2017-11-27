using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportistaTDM.ViewModels
{
    public class LoginViewModel
    {
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
    }
}
