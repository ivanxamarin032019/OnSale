using OnSale.Common.Services;
using OnSale.Prism.ViewModels;
using OnSale.Prism.Views;
using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using System;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace OnSale.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzA4NTUxQDMxMzgyZTMyMmUzMGdtZmtxYXc5MmVvVURoTHBXaWFPY2hLbWtaTVJmRDl1eUVodWw1V1NQNWM9");

            InitializeComponent();

            NavigationService.NavigateAsync($"{nameof(OnSaleMasterDetailPage)}/NavigationPage/{nameof(ProductsPage)}");
        }

        private object Products()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductDetailPage, ProductDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<OnSaleMasterDetailPage, OnSaleMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ShowCarPage, ShowCarPageViewModel>();
            containerRegistry.RegisterForNavigation<ShowHistoryPage, ShowHistoryPageViewModel>();
            containerRegistry.RegisterForNavigation<ModifyUserPage, ModifyUserPageViewModel>();
        }
    }
}
