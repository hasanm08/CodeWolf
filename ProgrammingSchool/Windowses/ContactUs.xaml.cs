using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for ContactUs.xaml
    /// </summary>
    public partial class ContactUs : Window
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void Back_Clicked(object sender, RoutedEventArgs e)
        {
            Hide();
            Close();
        }

        private void Telegram_Clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://t.me/hasanm08");
        }

        private void Gmail_clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto:hasanmahani08@gmail.com");
        }

        private void Instagram_Clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.instagram.com/hasanm108/");
        }

        private void Twitter_Clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/hasanm08");
        }

        private void Linkedin_Clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://linkedin.com/in/hasanm08/");
        }

        private void Whatsapp_Clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://wa.me/+989910187797");
        }
    }
}
