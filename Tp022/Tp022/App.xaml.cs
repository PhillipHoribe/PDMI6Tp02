using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp022
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ViewModel.Services.INavigationService, View.Services.NavigationService>();
            MainPage = new NavigationPage(new View.GerenciadorView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
