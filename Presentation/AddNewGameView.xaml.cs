using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MyVideoGameCollection;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for AddNewGameView.xaml
    /// </summary>
    public partial class AddNewGameView : Window
    {
        private string directoryOfFile;

        public AddNewGameView(string fileDirectory)
        {
            InitializeComponent();
            directoryOfFile = fileDirectory;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtTitle.Text == null || txtTitle.Text == "")
            {
                MessageBox.Show("Please Insert The Title of the Game to Add");
                txtTitle.BorderBrush = Brushes.Red;
                txtTitle.Focusable = true;
                Keyboard.Focus(txtTitle);
            }
            else
            {
                this.DialogResult = true;
                VideoGame newVideoGame = new VideoGame(txtTitle.Text, txtPlatform.Text, txtForm.Text);
                WriteOnExcel.insertVideoGame(newVideoGame, directoryOfFile);
            }
        }
    }
}