﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop2.Prism.Models;
using SuperShop2.Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SuperShop2.Prism.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;
        private ObservableCollection<ProductResponse> _products;
        private bool _isRunning;
        private string _search;
        private List<ProductResponse> _myProducts;
        private DelegateCommand _searchCommand;

        public ProductsPageViewModel(
            INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            _navigationService = navigationService;
            _apiService = apiService;
            Title = "Products Page";
            LoadProductsAsync();
        }

        public DelegateCommand SearchCommand => _searchCommand ?? (_searchCommand = new DelegateCommand(ShowProducts));

        public string Search
        {
            get => _search;
            set
            {
                SetProperty(ref _search, value);
                ShowProducts();
            }
        }

        public bool IsRunning
        {
            get => _isRunning;
            set => SetProperty(ref _isRunning, value);
        }

        public ObservableCollection<ProductResponse> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }


        private async void LoadProductsAsync()
        {
            string url = App.Current.Resources["UrlAPI"].ToString();

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Check internet connection", "Accept");
                });

                return;
            }

            IsRunning = true;
                
            Response response = await _apiService.GetListAsync<ProductResponse>(url, "/api", "/Products"); 
            
            IsRunning = false;

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            _myProducts = (List<ProductResponse>)response.Result;
            ShowProducts();
        }

        private void ShowProducts()
        {
            if (string.IsNullOrEmpty(Search))
            {
                Products = new ObservableCollection<ProductResponse>(_myProducts);
            }
            else
            {
                Products = new ObservableCollection<ProductResponse>(
                    _myProducts.Where(p => p.Name.ToLower().Contains(Search.ToLower())));
            }
        }
    }
}
