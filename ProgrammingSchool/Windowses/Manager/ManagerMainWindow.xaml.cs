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

namespace ProgrammingSchool.Windowses.Manager
{
    /// <summary>
    /// Interaction logic for ManagerMainWindow.xaml
    /// </summary>
    public partial class ManagerMainWindow : Window
    {
        public ManagerMainWindow()
        {
            InitializeComponent();
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();

            UserControl usc;
            //switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            //{
            //    case "ShowUsers":
            //        usc = new UserControlHome();
            //        GridMain.Children.Add(usc);
            //        break;
            //    case "AddUser":
            //        usc = new UserControlCreate();
            //        GridMain.Children.Add(usc);
            //        break;
            //    case "AddCourse":
            //        usc = new UserControlCreate();
            //        GridMain.Children.Add(usc);
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
