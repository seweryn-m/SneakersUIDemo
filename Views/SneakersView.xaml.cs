using System;
using System.Collections.Generic;
using SneakersUIDemo.ViewModels;
using Xamarin.Forms;

namespace SneakersUIDemo.Views
{
    public partial class SneakersView : ContentPage
    {
        public SneakersView()
        {
            InitializeComponent();
            BindingContext = new SneakersViewModel();
        }
    }
}
