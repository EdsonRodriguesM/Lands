using Lands.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infrastructure
{
    public class InstaceLocator
    {
        public MainViewModel Main
        {
            get;
            set;
        }

        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
