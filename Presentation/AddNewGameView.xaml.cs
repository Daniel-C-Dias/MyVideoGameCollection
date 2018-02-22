using System.Windows;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for AddNewGameView.xaml
    /// </summary>
    public partial class AddNewGameView : Window
    {
        public AddNewGameView()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}