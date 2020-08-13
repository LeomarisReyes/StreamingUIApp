using System;
using System.Collections.Generic;
using StreamingUIApp.ViewModels;
using Xamarin.Forms;

namespace StreamingUIApp.Views
{
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }
    }
}
