using AppTaxi.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppTaxi.Views
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