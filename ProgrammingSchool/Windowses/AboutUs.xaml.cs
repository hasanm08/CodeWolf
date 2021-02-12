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
            aboutUsLabel.Content = "رسانه های جریان اصلی ممکن است ادعا کنند که از بین رفتن نیروی انسانی بر دوش ما است ، " + "\n";
            aboutUsLabel.Content += "اما آینده کاملاً برعکس است. انسانها همیشه بخش مهمی از سفر نوآوری خواهند بود ، اما در مورد " + "\n";
            aboutUsLabel.Content += "سازمانهایی که این کار را ایمن انجام می دهند نمی توان همین را گفت";
        }
    }
}
