using System.ComponentModel;
using TareS6.ViewModels;
using Xamarin.Forms;

namespace TareS6.Views
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