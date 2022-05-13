using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAssistant.Views
{
    /// <summary>
    /// Main page of application.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
