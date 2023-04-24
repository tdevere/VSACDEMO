using System;
using System.Collections.Generic;
using System.ComponentModel;
using VSACDEMO.Models;
using VSACDEMO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VSACDEMO.Views
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