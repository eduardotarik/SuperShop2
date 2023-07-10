using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop2.Prism.Models;
using SuperShop2.Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop2.Prism.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        private readonly IApiService _apiService;
        private List<ProductResponse> _products;

        public ProductsPageViewModel(
            INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            _apiService = apiService;
            Title = "Products Page";
            LoadProductsAsync();
        }

        public List<ProductResponse> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }


        private async void LoadProductsAsync()
        {
            string url = App.Current.Resources["UrlAPI"].ToString();

            Response response = await _apiService.GetListAsync<ProductResponse>(url, "/api", "/Products");

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
            }

            Products = (List<ProductResponse>)response.Result;
        }
    }
}
