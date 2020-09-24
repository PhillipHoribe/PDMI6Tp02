using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tp022.ViewModel
{
    class GerenciadorViewModel
    {
        public ICommand GerenciadorCommand
        {
            get;
            set;
        }
        public ICommand EstiloPadraoCommand
        {
            get;
            set;
        }
        public ICommand EstiloDinamicoCommand
        {
            get;
            set;
        } public ICommand DataCommand
        {
            get;
            set;
        }
        public ICommand EstiloEventTriggresCommand
        {
            get;
            set;
        }
        public ICommand EstiloGlobalCommand
        {
            get;
            set;
        }
        public ICommand ClasseComplexaCommand
        {
            get;
            set;
        }
        public ICommand HomeCommand
        {
            get;
            set;
        }
        public ICommand ProdutoCommand
        {
            get;
            set;
        }
        public ICommand SimplesCommand
        {
            get;
            set;
        }
        //Home page
        string id;
        public class Contato{
            public string nome { get; set; }
            public int idade { get; set; }
            public string profissao { get; set; }
            public string pais { get; set; }
            public override string ToString()
            {
                return Contato;
            }
        }
        public class Produto
        {
            public string id { get; set; }
            public int descricao { get; set; }
            public string categoria { get; set; }
            public string quantidade { get; set; }
            public string preco { get; set; }
            public override string ToString()
            {
                return Produto;
            }
        }


        private readonly Services.INavigationService _navigationService;

        public GerenciadorViewModel()
        {
            this.GerenciadorCommand = new Command(this.Gerenciador);
            this.EstiloPadraoCommand = new Command(this.EstiloPadrao);
            this.EstiloDinamicoCommand = new Command(this.EstiloDinamico);
            this.EstiloEventTriggresCommand = new Command(this.EstiloEventTriggres);
            this.EstiloGlobalCommand = new Command(this.EstiloGlobal);
            this.ClasseComplexaCommand = new Command(this.ClasseComplexa);
            this.ProdutoCommand = new Command(this.Produto);
            this.HomeCommand = new Command(this.Home);
            this.DataCommand = new Command(this.Data);
            this.SimplesCommand = new Command(this.Simples);

            this._navigationService = DependencyService.Get<Services.INavigationService>();
        }
        private void Gerenciador()
        {
            this._navigationService.NavigateToGerenciadorView();
        }private void EstiloPadrao()
        {
            this._navigationService.NavigateToEstiloPadraoView();
        }
        private void EstiloDinamico()
        {
            this._navigationService.NavigateToEstiloDinamicoView();
        }
        private void Data()
        {
            DateTime LocalData = DateTime.Now;
        }
        private void EstiloEventTriggres()
        {
            this._navigationService.NavigateToEstiloEventTriggresView();
        }
        private void EstiloGlobal()
        {
            this._navigationService.NavigateToEstiloGlobalView();
        }
        private void Home()
        {
            this._navigationService.NavigateToHomeView();
        }
        private void Cadastro()
        {
            this._navigationService.NavigateToCadastroView();
        }

        private void ClasseComplexa()
        {
            this._navigationService.NavigateToClasseComplexaView();
        }
        private void Produto()
        {
            this._navigationService.NavigateProdutoView();
        }
        private void Simples()
        {
            this._navigationService.NavigateSimplesView();
        }
    }
}
