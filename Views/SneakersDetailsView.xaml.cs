using System;
using System.Collections.Generic;
using SneakersUIDemo.ViewModels;
using Xamarin.Forms;

namespace SneakersUIDemo.Views
{
    public partial class SneakersDetailsView : ContentPage
    {
        public SneakersDetailsView()
        {
            InitializeComponent();
            BindingContext = new SneakersViewModel();
        }
    }
}
