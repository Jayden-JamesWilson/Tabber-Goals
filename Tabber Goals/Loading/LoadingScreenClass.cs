using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Tabber_Goals.Utilities;

namespace Tabber_Goals.Loading
{
    public class LoadingScreenClass
    {
        public void CloseWindow(object sender)
        {
            WindowUtilities.CloseWindow(sender);
        }

        public void MoveWindow(object sender)
        {
            WindowUtilities.MoveWindow(sender);
        }

        #region Loading
        public void Loading(int SecondsDelay, Window LoadingWindow)
        {

            DispatcherTimer DispatcherTimer = new DispatcherTimer();
            DispatcherTimer.Interval = TimeSpan.FromSeconds(SecondsDelay);

            // Unique custom tick event for dispatcher timer
            DispatcherTimer.Tick += (sender, e) => DispatcherTimer_Tick(sender, LoadingWindow);

            DispatcherTimer.Start();

        }

        private void DispatcherTimer_Tick(object sender, Window LoadingWindow)
        {
            DispatcherTimer DispatcherTimer = (DispatcherTimer)sender;
            DispatcherTimer.Stop();

            WindowUtilities.HideWindow(LoadingWindow);

            try
            {
                // Show Main Window
                throw new Exception("Could not load main window"); // Remove when main window logic is added
            }
            catch(Exception ex)
            {
                WindowUtilities.ApplicationShutdown();
                MessageBox.Show(ex.Message, "Error Loading");
            }
        }
        #endregion
    }
}
