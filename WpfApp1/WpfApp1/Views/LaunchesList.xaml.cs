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
using WpfApp1.Models;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for LaunchesList.xaml
    /// </summary>
    public partial class LaunchesList : UserControl
    {
        public LaunchesList()
        {
            InitializeComponent();
        }

        private void LaunchesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LaunchViewModel selectedLaunch = (LaunchViewModel)LaunchesListView.SelectedItem;
            if (selectedLaunch != null)
            {
                LaunchSelectedTextBlock.Text = selectedLaunch.Details;
            }
        }
    }
}
