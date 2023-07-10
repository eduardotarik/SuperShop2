using Prism;
using Prism.Ioc;
using SuperShop2.Prism.Services;
using SuperShop2.Prism.ViewModels;
using SuperShop2.Prism.Views;
using Syncfusion.Licensing;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace SuperShop2.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MjU1ODQxNkAzMTM5MmUzMjJlMzBmbEkwcXprN2lZZXllS3hramtOSlNOUnhXOGRIY2xiMzB3UitlL0VOK0RJPQ==");

            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/ProductsPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage>();
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();
                       
        }
    }
}
