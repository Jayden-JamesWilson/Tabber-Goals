using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using System.Drawing;
using Tabber_Goals.TabberUI.FluentTabberButton;

namespace Tabber_Goals.Utilities
{
    public static class WindowUtilities
    {
        public static void HideWindow(object sender)
        {
            if (sender is DependencyObject Button && Window.GetWindow(Button) is Window CurrentWindow)
            {
                // Hide the current window.
                CurrentWindow.Hide();
            }
        }

        public static void CloseWindow(object sender)
        {

            if (sender is DependencyObject Button && Window.GetWindow(Button) is Window CurrentWindow) 
            {
                // Close the current window.
                CurrentWindow.Close();
            }
        }

        public static void MinimizeWindow(object sender)
        {
            if (sender is DependencyObject Button && Window.GetWindow(Button) is Window CurrentWindow)
            {
                // Minimize the current window.
                CurrentWindow.WindowState = WindowState.Minimized;
            }
        }
        
        public static void MaximizeWindow(object sender)
        {
            if (sender is DependencyObject Button && Window.GetWindow(Button) is Window CurrentWindow)
            {
                // Maximize the current window if collapsed  and collapse the current window if maximized.
                if (CurrentWindow.WindowState == WindowState.Normal)
                {

                    CurrentWindow.WindowState = WindowState.Maximized;
                }
                else
                {
                    CurrentWindow.WindowState = WindowState.Normal;
                }
            }
        }

        public static void MoveWindow(object sender)
        {
            // TODO
            // Important to note this is awkward and unstable on a multiple monitor setup
            // as when CurrentWindow is collapsed and location is set, the CurrentWindows
            // location is on the primary monitor. 

            if (sender is DependencyObject Button && Window.GetWindow(Button) is Window CurrentWindow)
            {
                // Move the current window.
                if (CurrentWindow.WindowState == WindowState.Maximized)
                {
                    CurrentWindow.WindowState = WindowState.Normal; ;

                    // Adjust the window position
                    Point cursorPosition = Mouse.GetPosition(CurrentWindow);

                    CurrentWindow.Left = cursorPosition.X - (CurrentWindow.Width / 2);
                    CurrentWindow.Top = cursorPosition.Y - 20;
                }

                CurrentWindow.DragMove();
            }
        }

        public static void ApplicationShutdown()
        {
            // Shutdown application
            Application.Current.Shutdown();
        }

        public static void TitlebarButtons_Click(object sender)
        {
            FluentTabberTextButton TitleBarButton = (FluentTabberTextButton)sender;

            switch (TitleBarButton.Name)
            {
                case "CloseButton":
                    CloseWindow(sender);
                    break;

                case "MinimizeButton":
                    MinimizeWindow(sender);
                    break;

                case "MaximizeButton":
                    MaximizeWindow(sender);
                    break;

                case "ShutdownButton":
                    ApplicationShutdown();
                    break;
            }

        }

    }
}
