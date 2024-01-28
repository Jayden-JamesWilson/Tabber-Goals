using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Tabber_Goals.Main;
using Tabber_Goals.Utilities;

namespace Tabber_Goals.Loading
{
    public class LoadingScreenClass
    {
        LoadingService LoadingService = new LoadingService();
        MainWindow MainWindow = new MainWindow();

        #region Window Events
        public void TitlebarButtons_Click(object sender)
        {
            WindowUtilities.TitlebarButtons_Click(sender);
        }

        public void MoveWindow(object sender)
        {
            WindowUtilities.MoveWindow(sender);
        }
        #endregion

        #region Loading
        public void Loading(int SecondsDelay, Window LoadingWindow, Window MainWindow)
        {
            LoadingService.Loading(SecondsDelay, LoadingWindow, MainWindow);
        }
        #endregion
    }
}
