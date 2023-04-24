using System.ComponentModel;
using VSACDEMO.ViewModels;
using Xamarin.Forms;

namespace VSACDEMO.Views
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