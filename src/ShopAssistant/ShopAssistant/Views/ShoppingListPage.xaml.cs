using System;
using ShopAssistant.Domain;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAssistant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingListPage : ContentPage
    {
        public ShoppingListPage()
        {
            InitializeComponent();
            //BindingContext = new ProductListViewModel() { Navigation = this.Navigation };
        }
        protected override void OnAppearing()
        {
            productsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Product selectedProduct = (Product) e.SelectedItem;
            ProductAddingPage productAddingPage = new ProductAddingPage();
            productAddingPage.BindingContext = selectedProduct;
            await Navigation.PushAsync(productAddingPage);
        }

        private async void CreateProduct(object sender, EventArgs e)
        {
            Product friend = new Product();
            ProductAddingPage productAddingPage = new ProductAddingPage();
            productAddingPage.BindingContext = friend;
            await Navigation.PushAsync(productAddingPage);
        }
    }
}