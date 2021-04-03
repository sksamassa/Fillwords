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

namespace Fillwords
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

        private void Btstart_Click(object sender, RoutedEventArgs e)
        {
            StartWindow startwindow = new StartWindow();
            startwindow.Show();
        }

        private void Btcontinue_Click(object sender, RoutedEventArgs e)
        {
            ContinueWindow continuewindow = new ContinueWindow();
            continuewindow.Show();
        }

        private void Btrecord_Click(object sender, RoutedEventArgs e)
        {
            StaticsWindow staticswindow = new StaticsWindow();
            staticswindow.Show();
        }

        private void Btsettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingswindow = new SettingsWindow();
            settingswindow.Show();
        }
    }
}
