using Prism.Commands;
using Prism.Navigation;
using SuperShop2.Prism.Models;
using SuperShop2.Prism.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperShop2.Prism.ItemViewModels
{
    public class MenuItemViewModel : Menu
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectMenuCommand;

        public MenuItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectMenuCommand =>
            _selectMenuCommand ??
            (_selectMenuCommand = new DelegateCommand(SelectMenuAsync));


        private async void SelectMenuAsync()
        {
            await _navigationService.NavigateAsync
                ($"/{nameof(SuperShop2MasterDetailPage)}/NavigationPage/{PageName}");
        }
    }
}
