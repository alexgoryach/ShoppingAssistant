using System;
using ShopAssistant.Domain;
using ShopAssistant.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAssistant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductAddingPage : ContentPage
    {
        //public ProductViewModel ViewModel { get; private set; }

        /*public ProductAddingPage(ProductViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            this.BindingContext = ViewModel;
        }*/

        public ProductAddingPage()
        {
            InitializeComponent();
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            if (!String.IsNullOrEmpty(product.Name))
            {
                App.Database.SaveItem(product);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteProduct(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            App.Database.DeleteItem(product.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}