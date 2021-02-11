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

namespace ProgrammingSchool.Windowses
{
    /// <summary>
    /// Interaction logic for AboutUs.xaml
    /// </summary>
    public partial class AboutUs : Window
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void Back_Clicked(object sender, RoutedEventArgs e)
        {
            Hide();
            Close();
        }

        private void AboutUs_Loading(object sender, RoutedEventArgs e)
        {
            aboutUsLabel.Content = "Mainstream media may claim that the demise of human labor is upon\n";
            aboutUsLabel.Content += "us, but the future is quite the opposite. Humans will always be a critical\n";
            aboutUsLabel.Content += "part of the innovation journey, but the same cannot be said for\n";
            aboutUsLabel.Content += "organizations who play it safe.";
        }
    }
}
