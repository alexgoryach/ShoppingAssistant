using System;
using System.IO;
using ShopAssistant.Infrastructure.DataAccess;
using ShopAssistant.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ShopAssistant
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "products.db";
        public static ProductRepository database;
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
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}