using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login
        {
            get;
            set;
        }

        public LandsViewModel Lands
        {
            get;
            set;
        }

        public LandViewModel Land
        {
            get;
            set;
        }

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        public MainViewModel(LandItemViewModel landItemViewModel)
        {
            this.landItemViewModel = landItemViewModel;
        }

        private static MainViewModel instance;
        private LandItemViewModel landItemViewModel;

        public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
    }
}
