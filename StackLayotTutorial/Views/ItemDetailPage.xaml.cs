using StackLayotTutorial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StackLayotTutorial.Views
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