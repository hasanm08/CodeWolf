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
    /// Interaction logic for CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public string Message { get; set; }
        public CustomMessageBox(string message)
        {
            Message = message;
            InitializeComponent();
        }

        private void CloseWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Hide();
            Close();
        }

        private void MinimizeWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void Move_window(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            messageTB.Text = Message;

        }

        private void okClicked(object sender, RoutedEventArgs e)
        {
            Hide();
            Close();
        }
    }
}
