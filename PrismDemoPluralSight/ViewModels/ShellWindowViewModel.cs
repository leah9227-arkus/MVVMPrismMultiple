using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismDemo.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismDemoPluralSight.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {
        private IApplicationCommands _applicationCommands;
        public IApplicationCommands ApplicationCommands
        {
            get { return _applicationCommands; }
            set { SetProperty(ref _applicationCommands, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; set; }

        private IRegionManager _regionManager;

        public ShellWindowViewModel(IApplicationCommands applicationCommands, IRegionManager regionManager)
        {
            //_applicationCommands = applicationCommands;
            NavigateCommand = new DelegateCommand<string>(Navigate);

            _regionManager = regionManager;
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
        }
    }
}
