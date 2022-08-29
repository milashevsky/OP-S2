using System.Windows;

namespace Prj_Soft_Protection
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void StudyModeBtn_Click(object sender, RoutedEventArgs e)
        {
            StudyModeWindow studyModeWindow = new StudyModeWindow();
            Hide();
            studyModeWindow.Show();
        }
        private void ProtectionModeBtn_Click(object sender, RoutedEventArgs e)
        {
            ProtectionModeWindow protectionModeWindow =
            new ProtectionModeWindow();
            Hide();
            protectionModeWindow.Show();
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
