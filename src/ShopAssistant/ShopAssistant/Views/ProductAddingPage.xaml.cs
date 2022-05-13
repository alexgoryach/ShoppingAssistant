using System;
using ShopAssistant.Domain;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAssistant.Views
{
    /// <summary>
    /// Product adding page.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductAddingPage : ContentPage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
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
