using MillApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MillApp.Views
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