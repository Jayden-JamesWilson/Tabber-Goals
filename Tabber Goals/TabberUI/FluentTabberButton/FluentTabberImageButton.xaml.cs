using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Tabber_Goals.TabberUI.FluentTabberButton
{
    public partial class FluentTabberImageButton : UserControl
    {
        public FluentTabberImageButton()
        {
            InitializeComponent();
        }

        #region Settings

        #region Button Style

        //Hover Colour
        public SolidColorBrush FluentTabberImageButton_BackgroundHoverColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberImageButton_BackgroundHoverColourProperty); }
            set { SetValue(FluentTabberImageButton_BackgroundHoverColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberImageButton_BackgroundHoverColourProperty = DependencyProperty.Register("FluentTabberImageButton_BackgroundHoverColour", typeof(SolidColorBrush), typeof(FluentTabberImageButton));

        //Default Colour
        public SolidColorBrush FluentTabberImageButton_BackgroundDefaultColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberImageButton_BackgroundDefaultColourProperty); }
            set { SetValue(FluentTabberImageButton_BackgroundDefaultColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberImageButton_BackgroundDefaultColourProperty = DependencyProperty.Register("FluentTabberImageButton_BackgroundDefaultColour", typeof(SolidColorBrush), typeof(FluentTabberImageButton));

        //Background Colour
        public SolidColorBrush FluentTabberImageButton_BackgroundColour
        {
            get { return (SolidColorBrush)GetValue(FluentTabberImageButton_BackgroundColourProperty); }
            set { SetValue(FluentTabberImageButton_BackgroundColourProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberImageButton_BackgroundColourProperty = DependencyProperty.Register("FluentTabberImageButton_BackgroundColour", typeof(SolidColorBrush), typeof(FluentTabberImageButton));

        //Corner Radius
        public int FluentTabberImageButton_CornerRadius
        {
            get { return (int)GetValue(FluentTabberImageButton_CornerRadiusProperty); }
            set { SetValue(FluentTabberImageButton_CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty FluentTabberImageButton_CornerRadiusProperty = DependencyProperty.Register("FluentTabberImageButton_CornerRadius", typeof(int), typeof(FluentTabberImageButton));
        #endregion

        #region Image

        // Image
        public ImageSource FluentTabberImageButton_ImageSource
        {
            get { return (ImageSource)GetValue(FluentTabberImageButton_ImageSourceProperty); }
            set { SetValue(FluentTabberImageButton_ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty FluentTabberImageButton_ImageSourceProperty = DependencyProperty.Register("FluentTabberImageButton_ImageSource", typeof(ImageSource), typeof(FluentTabberImageButton));

        #endregion

        #endregion

        #region Events

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            FluentTabberImageButton_BackgroundColour = FluentTabberImageButton_BackgroundHoverColour;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            FluentTabberImageButton_BackgroundColour = FluentTabberImageButton_BackgroundDefaultColour;
        }

        // Click Event
        public event EventHandler Click;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Raise the Click event when the button is clicked
            Click?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
