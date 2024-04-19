using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProjectFlag
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void contryCBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = this.contryCBox.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
            {
                string country = selectedItem.Content.ToString().Trim().ToLower();
                switch (country)
                {
                    case "italy":
                        SetColors(Colors.Green, Colors.White, Colors.Red);
                        selectWerHor(false);
                        break;
                    case "france":
                        SetColors(Colors.Blue, Colors.White, Colors.Red);
                        selectWerHor(false);
                        break;
                    case "belgium":
                        SetColors(Colors.Black, Colors.Yellow, Colors.Red);
                        selectWerHor(false);
                        break;
                    case "germany":
                        SetHorizontalColors(Colors.Black, Colors.Red, Colors.Yellow);
                        selectWerHor(true);
                        break;
                    case "austria":
                        SetHorizontalColors(Colors.Red, Colors.White, Colors.Red);
                        selectWerHor(true);
                        break;
                    case "romania":
                        SetColors(Colors.Blue, Colors.Yellow, Colors.Red);
                        selectWerHor(false);
                        break;
                }
            }
        }

        private void selectWerHor(bool isVer)
        {
            Frame01.Visibility = isVer ? Visibility.Collapsed : Visibility.Visible;
            Frame02.Visibility = isVer ? Visibility.Visible : Visibility.Collapsed;
        }

        // Sets colors for vertical flags
        private void SetColors(Color left, Color center, Color right)
        {
            LeftPart.Fill = new SolidColorBrush(left);
            CenterPart.Fill = new SolidColorBrush(center);
            RightPart.Fill = new SolidColorBrush(right);
        }

        // Sets colors for horizontal flags
        private void SetHorizontalColors(Color top, Color middle, Color bottom)
        {
            TopPart.Fill = new SolidColorBrush(top);
            MiddlePart.Fill = new SolidColorBrush(middle);
            BottomPart.Fill = new SolidColorBrush(bottom);
        }
    }
}

