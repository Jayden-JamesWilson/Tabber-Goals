using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Tabber_Goals.Main;
using Tabber_Goals.Utilities;

namespace Tabber_Goals.Loading
{
    public class LoadingService
    {
        #region Loading Service
        public void Loading(int SecondsDelay, Window LoadingWindow, Window MainWindow)
        {

            DispatcherTimer DispatcherTimer = new DispatcherTimer();
            DispatcherTimer.Interval = TimeSpan.FromSeconds(SecondsDelay);

            // Unique custom tick event for dispatcher timer
            DispatcherTimer.Tick += (sender, e) => DispatcherTimer_Tick(sender, LoadingWindow, MainWindow);

            DispatcherTimer.Start();

        }

        private void DispatcherTimer_Tick(object sender, Window LoadingWindow, Window MainWindow)
        {
            DispatcherTimer DispatcherTimer = (DispatcherTimer)sender;
            DispatcherTimer.Stop();

            WindowUtilities.HideWindow(LoadingWindow);

            try
            {
                // Show Main Window
                MainWindow.Show();
            }
            catch (Exception ex)
            {
                WindowUtilities.ApplicationShutdown();
                MessageBox.Show(ex.Message, "Error Loading");
            }
        }
        #endregion
    }
}
