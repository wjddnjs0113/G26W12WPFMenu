using System.Windows;

namespace G26W12WPFMenu;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        // Model을 만들어 ViewModel에 주입 후 DataContext로 설정
        DataContext = new MenuViewModel(new MenuModel());
    }
}