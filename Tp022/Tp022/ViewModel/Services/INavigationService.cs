using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tp022.ViewModel.Services
{
    public interface INavigationService
    {
        Task NavigateToClasseComplexaView();
        Task NavigateToEstiloDinamicoView();
        Task NavigateToEstiloEventTriggresView();
        Task NavigateToEstiloGlobalView();
        Task NavigateToEstiloPadraoView();
        Task NavigateToGerenciadorView();
        Task NavigateToHomeView();
        Task NavigateToMessagingCenterView();
        Task NavigateToProdutoView();
        Task NavigateToSimplesView();
        Task NavigateToCadastroView();
    }
}
