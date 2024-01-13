using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Tabber_Goals.Utilities
{
    public static class WindowUtilities
    {
        public static void HideWindow(object sender)
        {
            if (sender != null)
            {
                // Get the window that the sender is located in.
                Window CurrentWindow = Window.GetWindow((DependencyObject)sender);

                if (CurrentWindow != null)
                {
                    // Close the current window.
                    CurrentWindow.Hide();
                }
            }
        }

        public static void CloseWindow(object sender)
        {
            if (sender != null)
            {
                // Get the window that the sender is located in.
                Window CurrentWindow = Window.GetWindow((DependencyObject)sender);

                if (CurrentWindow != null)
                {
                    // Close the current window.
                    CurrentWindow.Close();
                }
            }
        }

        public static void MinimizeWindow(object sender)
        {        
            if (sender != null)
            {
                // Get the window that the sender is located in.
                Window CurrentWindow = Window.GetWindow((DependencyObject)sender);

                if (CurrentWindow != null)
                {
                    // Minimize the current window.
                    CurrentWindow.WindowState = WindowState.Minimized;
                }
            }
        }

        public static void MaximizeWindow(object sender)
        {
            if (sender != null)
            {
                // Get the window that the sender is located in.
                Window CurrentWindow = Window.GetWindow((DependencyObject)sender);

                if (CurrentWindow != null)
                {
                    // Mazimize the current window.
                    CurrentWindow.WindowState = WindowState.Maximized;
                }
            }
        }

        public static void CollapseWindow(object sender)
        {
            if (sender != null)
            {
                // Get the window that the sender is located in.
                Window CurrentWindow = Window.GetWindow((DependencyObject)sender);

                if (CurrentWindow != null)
                {
                    // Collapse the current window.
                    CurrentWindow.WindowState = WindowState.Normal;
                }
            }
        }

        public static void MoveWindow(object sender)
        {
            if (sender != null)
            {
                // Get the window that the sender is located in.
                Window CurrentWindow = Window.GetWindow((DependencyObject)sender);

                if (CurrentWindow != null)
                {
                    // Move the current window.
                    CurrentWindow.DragMove();
                }
            }
        }

        public static void ApplicationShutdown()
        {
            // Shutdown application
            Application.Current.Shutdown();
        }
    }
}
