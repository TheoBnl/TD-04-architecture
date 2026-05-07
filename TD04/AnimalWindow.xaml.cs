using System.Windows;


namespace Views
{
    /// <summary>
    /// Logique d'interaction pour AnimalWindow.xaml
    /// </summary>
    public partial class AnimalWindow : Window
    {
        public AnimalWindow()
        {
            InitializeComponent();
            // todo initialize the binding
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
