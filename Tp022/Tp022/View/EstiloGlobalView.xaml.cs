﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp022.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstiloGlobalView : ContentPage
    {
        public EstiloGlobalView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.EstiloGlobalViewModel();
        }
    }
}