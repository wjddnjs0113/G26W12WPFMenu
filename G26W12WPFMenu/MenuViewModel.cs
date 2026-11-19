using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media;

namespace G26W12WPFMenu;

public partial class MenuViewModel(
    MenuModel model
) : ObservableObject {
    [ObservableProperty]
    private Brush _backgroundBrush = Brushes.White;

    [ObservableProperty]
    private bool _isWhiteSelected = true;

    [ObservableProperty]
    private bool _isRedSelected = false;

    [ObservableProperty]
    private bool _isGreenSelected = false;

    [ObservableProperty]
    private bool _isBlueSelected = false;

    [RelayCommand]
    private void SetColor(string color) {
        model.SelectColor(color);
        BackgroundBrush = model.BackgroundBrush;
        IsWhiteSelected = model.IsWhiteSelected;
        //IsWhiteSelected = color == "White";

        IsRedSelected = color == "Red";
        IsGreenSelected = color == "Green";
        IsBlueSelected = color == "Blue";
    }
}
