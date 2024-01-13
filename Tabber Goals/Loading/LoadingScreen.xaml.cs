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

            LoadingScreenClass.Loading(5, this);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            LoadingScreenClass.CloseWindow(sender);
        }

        private void LoadingWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoadingScreenClass.MoveWindow(sender);
        }
    }
}
