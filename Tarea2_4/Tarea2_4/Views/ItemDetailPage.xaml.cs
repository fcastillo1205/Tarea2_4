using System.ComponentModel;
using Tarea2_4.ViewModels;
using Xamarin.Forms;

namespace Tarea2_4.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}