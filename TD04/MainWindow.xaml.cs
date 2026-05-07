using System;
using System.Windows;
using System.Windows.Input;

namespace Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
             // todo initialize the model, the view-model, the binding  
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            try
            {
                // todo create an animal, its viewmodel, the view to edit and show the view
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            // todo remove from the viewmodel
        }

        private void Edit(object sender, MouseButtonEventArgs e)
        {
            // todo edit the current animal
        }
    }
}
