using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop2.Prism.Helpers;
using SuperShop2.Prism.ItemViewModels;
using SuperShop2.Prism.Models;
using SuperShop2.Prism.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SuperShop2.Prism.ViewModels
{
    public class SuperShop2MasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public SuperShop2MasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
        }

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        private void LoadMenus()
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "ic_card_giftcard",
                    PageName = $"{nameof(ProductsPage)}",
                    Title = Languages.Products
                },

                new Menu
                {
                    Icon = "ic_shopping_cart",
                    PageName = $"{nameof(ShowCartPage)}",
                    Title = Languages.ShowShoppingCart
                },

                new Menu
                {
                    Icon = "ic_history",
                    PageName = $"{nameof(ShowHistoryPage)}",
                    Title = Languages.ShowPurchaseHistory,
                    IsLoginRequired = true
                },

                new Menu
                {
                    Icon = "ic_person",
                    PageName = $"{nameof(ModifyUserPage)}",
                    Title = Languages.ModifyUser,
                    IsLoginRequired = true
                },

                new Menu
                {
                    Icon = "ic_exit_to_app",
                    PageName = $"{nameof(LoginPage)}",
                    Title = Languages.Login
                }
            };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title,
                    IsLoginRequired = m.IsLoginRequired,
                }).ToList());
        }
    }
}
