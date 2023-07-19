using Prism.Ioc;
using PrismDemoPluralSightAuto.Views;
using System.Windows;

namespace PrismDemoPluralSightAuto
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
