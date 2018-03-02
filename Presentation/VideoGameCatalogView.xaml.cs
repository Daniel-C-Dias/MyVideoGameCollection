using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MyVideoGameCollection;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for VideoGameCatalogView.xaml
    /// </summary>
    public partial class VideoGameCatalogView : Window
    {
        private string directoryOfFile;
        private List<TabItem> tabList = new List<TabItem>();

        public VideoGameCatalogView(VideoGameCatalog videoGameCatalog, string fileDirectory)
        {
            InitializeComponent();

            directoryOfFile = fileDirectory;

            foreach (VideoGame game in videoGameCatalog.getVideoGameList())
            {
                if ((tabList.Exists(x => x.Name == game.Platform)) == false)
                {
                    // create new tab item
                    TabItem tab = new TabItem();
                    tab.Header = string.Format("{0}", game.Platform);
                    tab.Name = string.Format("{0}", game.Platform);

                    // add controls to tab item
                    ListBox listBox = new ListBox();
                    listBox.Name = "ListBox";

                    foreach (VideoGame videoGame in videoGameCatalog.getVideoGameList())
                    {
                        if ((string)tab.Header == videoGame.Platform)
                        {
                            listBox.Items.Add(videoGame.Name + "\t\t\t\t\t\t\t\t\t\t\t" + videoGame.Form);
                        }
                    }

                    tab.Content = listBox;

                    // add new tab to TabList
                    this.tabList.Add(tab);
                }
            }

            foreach (TabItem tabItem in this.tabList)
            {
                tabControlPanel.Items.Add(tabItem);
            }

            /*
             * How to acess information within the list box:
             *  var x = tabList[0].Content as ListBox;
                var y = x.Items;

                 foreach (var item in y)
                 {
                // TODO
                 }
             *
             *
             */
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewGameView addNewGameView = new AddNewGameView(directoryOfFile);

            // get existing header text
            string selectedTabHeader = this.tabControlPanel.SelectedItem.ToString();
            // to delete anything before PlayStation
            int i = selectedTabHeader.IndexOf(" PlayStation2");
            if (i >= 0) selectedTabHeader = selectedTabHeader.Substring(i + 1);

            addNewGameView.txtPlatform.Text = selectedTabHeader;

            if (addNewGameView.ShowDialog() == true)
            {
                MessageBox.Show("Video Game Added");
                this.tabControlPanel.Items.Refresh();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented Yet");
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented Yet");
        }
    }
}