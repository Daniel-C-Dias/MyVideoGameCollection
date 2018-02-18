namespace Presentation
{
    using System.Windows;
    using Microsoft.Win32;
    using MyVideoGameCollection;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadExcelFileOnClick(object sender, RoutedEventArgs e)
        {
            string fileDirectory = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                fileDirectory = openFileDialog1.FileName;
                VideoGameCatalog videoGameCatalog = ReadFromExcel.getVideoGames(fileDirectory);

                VideoGameCatalogView videoGameCatalogView = new VideoGameCatalogView(videoGameCatalog);

                App.Current.MainWindow = videoGameCatalogView;
                this.Close();
                videoGameCatalogView.Show();
            }
        }

        private void CreateNewCatalogOnClick(object sender, RoutedEventArgs e)
        {
            CreateNewCatalogView createNewCatalogView = new CreateNewCatalogView();

            App.Current.MainWindow = createNewCatalogView;
            this.Close();
            createNewCatalogView.Show();
        }
    }
}