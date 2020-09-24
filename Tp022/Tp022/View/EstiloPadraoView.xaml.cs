using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp022.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstiloPadraoView : ContentPage
    {
        public EstiloPadraoView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.EstiloPadraoViewModel();
        }
    }
}