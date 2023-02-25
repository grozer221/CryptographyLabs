
using System.Windows;
using System.Windows.Media;

namespace Cryptography
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;

            MainFrame.Source = ClickedButton.NavUri;
            ColorActiveNavButton();
        }

        private void ColorActiveNavButton()
        {
            foreach (var button in StackPanelNav.Children)
            {
                NavButton navButton = button as NavButton;
                if (navButton != null)
                {
                    var mainFrameUri = MainFrame.Source.ToString();
                    var buttonUri = navButton.NavUri.ToString();
                    if (mainFrameUri.Contains(buttonUri))
                        navButton.Background = Brushes.LightGray;
                    else
                        navButton.Background = Brushes.White;
                }
            }
        }
    }
}
