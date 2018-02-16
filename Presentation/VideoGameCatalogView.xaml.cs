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
        private List<TabItem> tabList = new List<TabItem>();

        public VideoGameCatalogView(VideoGameCatalog videoGameCatalog)
        {
            InitializeComponent();

            // to change when tab issue is resolved
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
                    tab.Content = listBox;

                    // add new tab to TabList
                    this.tabList.Add(tab);
                }
            }

            foreach (TabItem tabItem in this.tabList)
            {
                tabControlPanel.Items.Add(tabItem);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented Yet");
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