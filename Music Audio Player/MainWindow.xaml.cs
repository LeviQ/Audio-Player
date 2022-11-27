using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Music_Audio_Player
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Home - work in progress");

        }

        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Search - work in progress");
        }

        private void Button_Click_Playlists(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Playlists - work in progress");
        }

        private void Button_Click_Albums(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Albums - work in progress");
        }

        private void Button_Click_Artists(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Artists - work in progress");
        }

        private void Button_Click_Radio(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Radio - work in progress");
        }

        private void Button_Click_Foryou(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("For you - work in progress");
        }

        private void Button_Click_Import(object sender, RoutedEventArgs e)
        {

        }
    }
}
