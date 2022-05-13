using System;
using System.IO;
using ShopAssistant.Infrastructure.DataAccess;
using ShopAssistant.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ShopAssistant
{
    /// <summary>
    /// Application class.
    /// </summary>
    public partial class App : Application
    {
        private const string DATABASE_NAME = "products.db";
        private static ProductRepository database;

        /// <summary>
        /// Product repository.
        /// </summary>
        public static ProductRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProductRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        /// <inheritdoc />
        protected override void OnStart()
        {
        }

        /// <inheritdoc />
        protected override void OnSleep()
        {
        }

        /// <inheritdoc />
        protected override void OnResume()
        {
        }
    }
}
