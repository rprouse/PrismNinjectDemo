using Prism.Ninject;
using PrismNinjectDemo.Views;

namespace PrismNinjectDemo
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnInitialized()
        {
            NavigationService.Navigate("MainNavigationPage/ViewA?message=Hello%20From%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Kernel.RegisterTypeForNavigation<MainNavigationPage>();
            Kernel.RegisterTypeForNavigation<ViewA>();
            Kernel.RegisterTypeForNavigation<ViewB>();
        }
    }
}
