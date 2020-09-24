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
    public partial class EstiloEventTriggresView : ContentPage
    {
        public EstiloEventTriggresView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.EstiloEventTriggresViewModel();
        }
    }
}