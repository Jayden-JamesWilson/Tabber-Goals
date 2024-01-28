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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tabber_Goals.TabberUI.FluentTabberButton;

namespace Tabber_Goals.TabberUI.FluentTabberSeperator
{
    /// <summary>
    /// Interaction logic for FluentTabberSeperator.xaml
    /// </summary>
    public partial class FluentTabberSeperator : UserControl
    {
        public FluentTabberSeperator()
        {
            InitializeComponent();
        }

        #region Settings

        #region Seperator Style

        //Background Colour
        public SolidColorBrush FluentTabberSeperator_BackgroundColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberSeperator_BackgroundColourProperty); }
            set { SetValue(FluentTabberSeperator_BackgroundColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberSeperator_BackgroundColourProperty = DependencyProperty.Register("FluentTabberSeperator_BackgroundColour", typeof(SolidColorBrush), typeof(FluentTabberSeperator));

        #endregion 

        #endregion
    }
}
