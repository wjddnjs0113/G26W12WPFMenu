using Microsoft.Win32;
using System.Windows;
using System.Windows.Input;

namespace G26W12WPFMenu;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        DataContext = new MenuViewModel(new MenuModel());
    }

    private void OnFileOpen(object sender, ExecutedRoutedEventArgs e) {
        OpenFileDialog dialog = new() {
            FileName = "이미지",
            DefaultExt = ".jpg",
            Filter = "Images (.jpg)|*.jpg"
        };

        if (dialog.ShowDialog() == true) {
            MessageBox.Show(dialog.FileName);
        }
    }
}