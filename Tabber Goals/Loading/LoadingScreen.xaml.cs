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
using Tabber_Goals.Main;
using Tabber_Goals.Utilities;

namespace Tabber_Goals.Loading
{
    /// <summary>
    /// Interaction logic for LoadingScreen.xaml
    /// </summary>
    public partial class LoadingScreen : Window
    {
        #region Classes
        LoadingScreenClass LoadingScreenClass = new LoadingScreenClass();
        #endregion

        public LoadingScreen()
        {
            InitializeComponent();

            MainWindow MainWindow = new MainWindow();
            LoadingScreenClass.Loading(5, this, MainWindow);
        }

        #region Window Based Events
        public void TitlebarButtons_Click(object sender, EventArgs e)
        {
            LoadingScreenClass.TitlebarButtons_Click(sender);
        }

        private void LoadingWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoadingScreenClass.MoveWindow(sender);
        }
        #endregion
    }
}
