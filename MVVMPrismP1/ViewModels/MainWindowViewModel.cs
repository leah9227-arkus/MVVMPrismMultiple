using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrismP1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager { get; set; }
        public DelegateCommand<string> NavigateCommand { get; set; }

        private string navigationRegion = "NavigationRegion";
        public string NavigationRegion { get => navigationRegion; }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate(NavigationRegion, uri, HandleErrorNavigation);
        }

        private Action<NavigationResult> HandleErrorNavigation = (NavigationResult nr) =>
        {
            if (nr.Result != true)
            {
                // to do something with this error.
                var error = nr.Error;
            }
        };

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
    }
}
