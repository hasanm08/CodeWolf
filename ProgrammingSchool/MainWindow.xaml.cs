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
            if (usernameTB.Text.Length > 0 && passwordTB.Password.Length > 0)
            {
                CustomMessageBox mbox = new CustomMessageBox($"username:{usernameTB.Text}\npassword:{passwordTB.Password}");
                mbox.Show();
            }
            else
            {
                CustomMessageBox mbox = new CustomMessageBox("please enter username & password");
                mbox.Show();
            }
        }
    }
}
