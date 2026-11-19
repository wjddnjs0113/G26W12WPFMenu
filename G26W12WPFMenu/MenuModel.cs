using System.Windows.Media;

namespace G26W12WPFMenu;

public class MenuModel {
    public Brush BackgroundBrush { get; private set; } = Brushes.White;

    public bool IsWhiteSelected { get; private set; } = true;

    public void SelectColor(string color) {
        switch (color) {
            case "Red":
                BackgroundBrush = Brushes.Red;
                break;
            case "Green":
                BackgroundBrush = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                break;
            case "Blue":
                BackgroundBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
                break;
            default:
                BackgroundBrush = Brushes.White;
                break;
        }
        IsWhiteSelected = color == "White";
    }
}