using System;
using System.Windows;
using MVVMPrismP1.ViewModels;
using MVVMPrismP1.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Mvvm;

namespace MVVMPrismP1
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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // register the user control navigation.
            containerRegistry.RegisterForNavigation<DocumentsView, DocumentsViewModel>();
            containerRegistry.RegisterForNavigation<NotesView, NotesViewModel>();
        }
    }
}
