using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tp022.View.Services
{
    class NavigationService : ViewModel.Services.INavigationService
    {
         public async System.Threading.Tasks.Task NavigateToCadastroView()
        {
            await Tp022.App.Current.MainPage.Navigation.PushAsync(new View.CadastroView());
        }

        public async System.Threading.Tasks.Task NavigateToClasseComplexaView()
        {
            await Tp022.App.Current.MainPage.Navigation.PushAsync(new View.ClasseComplexaView());
        }

        public async System.Threading.Tasks.Task NavigateToEstiloDinamicoView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.EstiloDinamicoView());
        }

        /*public async System.Threading.Tasks.Task NavigateToEstiloEventTriggres()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.EstiloEventTriggresView());
        }*/

        public async System.Threading.Tasks.Task NavigateToEstiloEventTriggresView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.EstiloEventTriggresView());
        }

        public async System.Threading.Tasks.Task NavigateToEstiloGlobalView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.EstiloGlobalView());
        }

        public async System.Threading.Tasks.Task NavigateToEstiloPadraoView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.EstiloPadraoView());
        }

        public async System.Threading.Tasks.Task NavigateToGerenciadorView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.GerenciadorView());
        }

            public async System.Threading.Tasks.Task NavigateToHomeView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.HomeView());
        }

        public async System.Threading.Tasks.Task NavigateToMessagingCenterView()
        { 
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.MessagingCenterView()); 
        }

        public async System.Threading.Tasks.Task NavigateToProdutoView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.ProdutoView());
        }

        public async System.Threading.Tasks.Task NavigateToSimplesView()
        {
            Tp022.App.Current.MainPage.Navigation.PushAsync(new View.SimplesView());
        }
    }
}

