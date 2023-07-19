using System;
using System.Windows;
using MVVMPrism.ViewModels;
using MVVMPrism.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Mvvm;

namespace MVVMPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            //ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            //{
            //    var prefix = viewType.FullName.Replace(".Views.", ".ViewModels.");
            //    var viewAssemblyName = viewType.GetType().Assembly.FullName;
            //    var viewModelName = $"{prefix}ViewModels,{viewAssemblyName}";
            //    return Type.GetType(viewModelName);
            //});
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Registers all the screens to be able to navigate inside a region.
            containerRegistry.RegisterForNavigation<ViewUsers, UsersViewModel>();
            containerRegistry.RegisterForNavigation<ViewSettings, SettingsViewModel>();
        }
    }
}
