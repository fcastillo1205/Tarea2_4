using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tarea2_4.Models;
using Tarea2_4.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_4.Views
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