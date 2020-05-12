﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App35.Views
{
    [QueryProperty(nameof(Count), "count")]
    public partial class Page2 : ContentPage
    {
        string count = "";
        public string Count
        {
            get => count;
            set
            {
                count = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        public Page2()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..?backdata=from page2");
        }

        private async void ButtonBackAndPage3_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../page3?data=from page2 and last page is now page1");
        }
    }
}