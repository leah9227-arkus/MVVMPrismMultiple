using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF___MVVM.Business;

namespace WPF___MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static DatabasConnection _dbConnection = new DatabasConnection();

        internal static DatabasConnection DbConnection { get => _dbConnection; set => _dbConnection = value; }
    }
}
