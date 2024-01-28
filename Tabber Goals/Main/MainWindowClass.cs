using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using Tabber_Goals.Utilities;

namespace Tabber_Goals.Main
{
    public class MainWindowClass
    {
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
    }
}
