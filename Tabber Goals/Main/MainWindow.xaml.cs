using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tabber_Goals.Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Classes
        MainWindowClass MainWindowClass = new MainWindowClass();
        #endregion 

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Window Based Events

        private void TitlebarButtons_Click(object sender, EventArgs e)
        {
            MainWindowClass.TitlebarButtons_Click(sender);
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindowClass.MoveWindow(sender);
        }
        #endregion
    }
}
