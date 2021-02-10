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
            MessageBox.Show(usernameTB.Text + " : " + passwordTB.Password);
        }
    }
}
