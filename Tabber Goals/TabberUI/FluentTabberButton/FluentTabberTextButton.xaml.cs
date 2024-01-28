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

namespace Tabber_Goals.TabberUI.FluentTabberButton
{
    /// <summary>
    /// Interaction logic for FluentTabberButton.xaml
    /// </summary>
    public partial class FluentTabberTextButton : UserControl
    {
        public FluentTabberTextButton()
        {
            InitializeComponent();
        }

        #region Settings

        #region Button Style

        //Hover Colour
        public SolidColorBrush FluentTabberTextButton_BackgroundHoverColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberTextButton_BackgroundHoverColourProperty); }
            set { SetValue(FluentTabberTextButton_BackgroundHoverColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_BackgroundHoverColourProperty = DependencyProperty.Register("FluentTabberTextButton_BackgroundHoverColour", typeof(SolidColorBrush), typeof(FluentTabberTextButton));

        //Default Colour
        public SolidColorBrush FluentTabberTextButton_BackgroundDefaultColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberTextButton_BackgroundDefaultColourProperty); }
            set { SetValue(FluentTabberTextButton_BackgroundDefaultColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_BackgroundDefaultColourProperty = DependencyProperty.Register("FluentTabberTextButton_BackgroundDefaultColour", typeof(SolidColorBrush), typeof(FluentTabberTextButton));

        //Background Colour
        public SolidColorBrush FluentTabberTextButton_BackgroundColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberTextButton_BackgroundColourProperty); }
            set { SetValue(FluentTabberTextButton_BackgroundColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_BackgroundColourProperty = DependencyProperty.Register("FluentTabberTextButton_BackgroundColour", typeof(SolidColorBrush), typeof(FluentTabberTextButton));

        //Corner Radius
        public int FluentTabberTextButton_CornerRadius
        {
            get { return (int)GetValue(FluentTabberTextButton_CornerRadiusProperty); }
            set { SetValue(FluentTabberTextButton_CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_CornerRadiusProperty = DependencyProperty.Register("FluentTabberTextButton_CornerRadius", typeof(int), typeof(FluentTabberTextButton));
        #endregion

        #region Text Style

        //Text
        public string FluentTabberTextButton_Text
        {
            get { return (string)GetValue(FluentTabberTextButton_TextProperty); }
            set { SetValue(FluentTabberTextButton_TextProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_TextProperty = DependencyProperty.Register("FluentTabberTextButton_Text", typeof(string), typeof(FluentTabberTextButton));

        //Text Size
        public int FluentTabberTextButton_TextSize
        {
            get { return (int)GetValue(FluentTabberTextButton_TextSizeProperty); }
            set { SetValue(FluentTabberTextButton_TextSizeProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_TextSizeProperty = DependencyProperty.Register("FluentTabberTextButton_TextSize", typeof(int), typeof(FluentTabberTextButton));

        //Text Font
        public FontFamily FluentTabberTextButton_TextFont
        {
            get { return (FontFamily)GetValue(FluentTabberTextButton_TextFontProperty); }
            set { SetValue(FluentTabberTextButton_TextFontProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_TextFontProperty = DependencyProperty.Register("FluentTabberTextButton_TextFont", typeof(FontFamily), typeof(FluentTabberTextButton));

        //Text Colour
        public SolidColorBrush FluentTabberTextButton_TextColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberTextButton_TextColourProperty); }
            set { SetValue(FluentTabberTextButton_TextColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_TextColourProperty = DependencyProperty.Register("FluentTabberTextButton_TextColour", typeof(SolidColorBrush), typeof(FluentTabberTextButton));

        //Text Hover Colour
        public SolidColorBrush FluentTabberTextButton_TextHoverColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberTextButton_TextHoverColourProperty); }
            set { SetValue(FluentTabberTextButton_TextHoverColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_TextHoverColourProperty = DependencyProperty.Register("FluentTabberTextButton_TextHoverColour", typeof(SolidColorBrush), typeof(FluentTabberTextButton));

        //Text Default Colour
        public SolidColorBrush FluentTabberTextButton_TextDefaultColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberTextButton_TextDefaultColourProperty); }
            set { SetValue(FluentTabberTextButton_TextDefaultColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberTextButton_TextDefaultColourProperty = DependencyProperty.Register("FluentTabberTextButton_TextDefaultColour", typeof(SolidColorBrush), typeof(FluentTabberTextButton));
        #endregion

        #endregion

        #region Events

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            FluentTabberTextButton_BackgroundColour = FluentTabberTextButton_BackgroundHoverColour;
            FluentTabberTextButton_TextColour = FluentTabberTextButton_TextHoverColour;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            FluentTabberTextButton_BackgroundColour = FluentTabberTextButton_BackgroundDefaultColour;
            FluentTabberTextButton_TextColour = FluentTabberTextButton_TextDefaultColour;
        }

        //Click Event
        public event EventHandler Click;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Raise the Click event when the button is clicked
            Click?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
