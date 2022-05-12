using System;
using ShopAssistant.Domain;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAssistant.Views
{
    /// <summary>
    /// Page with shopping list.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingListPage : ContentPage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ShoppingListPage()
        {
            InitializeComponent();
        }

        /// <inheritdoc />
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