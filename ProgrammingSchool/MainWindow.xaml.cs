using ProgrammingSchool.Windowses;
using System.Windows;
namespace ProgrammingSchool
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

        private void LoginClicked(object sender, RoutedEventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Show();
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            if (usernameTB.Text.Length > 0 && passwordTB.Password.Length > 0)
            {
                CustomMessageBox mbox = new CustomMessageBox($"نام کاربری:{usernameTB.Text}\nرمز عبور:{passwordTB.Password}");
                mbox.Show();
            }
            else
            {
                CustomMessageBox mbox = new CustomMessageBox("خواهشا رمز عبور یا نام کاربری را وارد کنید.");
                mbox.Show();
            }
        }
    }
}
