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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Package_Manager.View;

namespace Package_Manager
{
    /// <summary>
    /// Interaction logic for ParentWindow.xaml
    /// </summary>
    public partial class ParentWindow : MetroWindow
    {
        public ParentWindow()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            this.DataContext = new MainContentView(NavigateToView);
        }

        private void NavigateToView(UserControl view)
        {
            MainArea.Content = view;
        }

        private void btnNewPackage_Click(object sender, RoutedEventArgs e)
        {
            //TODO:HANDLE NEW PACKAGE BTN CLICK
            new MainContentView(NavigateToView).NavigateToNewPackageControl();
        }

        private void btnLoginLogout_Click(object sender, RoutedEventArgs e)
        {
            //TODO:HANDLE LOGIN / LOGOUT BTN CLICK
            new MainContentView(NavigateToView).Initializate();
        }
    }
}
