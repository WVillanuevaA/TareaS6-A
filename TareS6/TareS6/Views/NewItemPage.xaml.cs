using System;
using System.Collections.Generic;
using System.ComponentModel;
using TareS6.Models;
using TareS6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareS6.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}