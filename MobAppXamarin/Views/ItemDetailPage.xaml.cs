using MobAppXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobAppXamarin.Views
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