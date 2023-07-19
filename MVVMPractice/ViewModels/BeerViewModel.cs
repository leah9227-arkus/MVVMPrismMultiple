using MVVMPractice.Core;
using MVVMPractice.Core.Commands;
using MVVMPractice.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MVVMPractice.ViewModels
{
    public class BeerViewModel : ViewModelBase
    {
        private Beer beer = new Beer();

        public Beer Beer {
            get => beer;
            set {
                beer = value;
                RaisePropertyChanged("Beer");
            }
        }

        public BeerViewModel()
        {
            Beer = new Beer()
            {
                Brand = "First test brand",
                Description = "First test desc",
                Id = 1,
                Name = "Beer name test first"
            };
        }

        #region GenerateRandombeerCommand
        ICommand _generateRandomBeerCommand;
        public ICommand GenerateRandomBeerCommand {
            get
            {
                if (_generateRandomBeerCommand == null)
                    _generateRandomBeerCommand = new RelayCommand(GenerateRandomBeer);

                return _generateRandomBeerCommand;
            }
        }


        public void GenerateRandomBeer()
        {
            Beer = App.UOF.Repositories.BeerRepository.GetRandomBeer();
        }
        #endregion

        #region CloseWindowCommand
        ICommand _closeWindowCommand;
        public ICommand CloseWindowCommand {
            get
            {
                if (_closeWindowCommand == null)
                    _closeWindowCommand = new RelayCommand(CloseWindow);

                return _closeWindowCommand;
            }
        }

        private void CloseWindow()
        {
            //MessageBox.Show("I shold close me xD");
            //(o) => ((Window)o).Close();
        }
        #endregion
    }
}
