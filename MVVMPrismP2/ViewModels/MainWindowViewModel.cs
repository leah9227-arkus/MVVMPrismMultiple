using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace MVVMPrismP2.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager;

        private string _navigationRegionName = "NavigationRegionName";
        public string NavigationRegionName { get => _navigationRegionName; }

        public DelegateCommand<string> NavigateCommand { get; set; }
        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate(_navigationRegionName, uri, HandleErrorNavigation);
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
            NavigateCommand = new DelegateCommand<string>(Navigate);
            _regionManager = regionManager;
        }
    }
}
