using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop2.Prism.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop2.Prism.ViewModels
{
    public class ModifyUserPageViewModel : ViewModelBase
    {
        public ModifyUserPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ModifyUser;
        }
    }
}
