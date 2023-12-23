using System.Windows;
using WpfApp2;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, RoutedEventArgs e)
        {
            TextWindow textWindow = new TextWindow();
            textWindow.Show();
            this.Close();
        }

        private void IWB_Click(object sender, RoutedEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow();
            imageWindow.Show();
            this.Close();
        }
      
        private void OpenVideoWindow_Click(object sender, RoutedEventArgs e)
        {
            VideoWindow imageWindow = new VideoWindow();
            imageWindow.Show();
            this.Close();
        }
    }
}
