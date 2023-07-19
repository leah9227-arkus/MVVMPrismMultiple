using MVVMPrismP2.ViewModels;
using MVVMPrismP2.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace MVVMPrismP2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindowView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // register the user control navigation (view -> view model).
            containerRegistry.RegisterForNavigation<UsersView, UsersViewModel>();
            containerRegistry.RegisterForNavigation<AccountsView, AccountsViewModel>();
        }
    }
}
