﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF___MVVM.Core
{
    public class IViewModelBase : INotifyPropertyChanged
    {
        #region INotifyProperty Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies change property (based on a name) to all references.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
