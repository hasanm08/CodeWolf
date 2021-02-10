using System.Windows;

namespace ProgrammingSchool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void CloseWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tmp = sender as System.Windows.Shapes.Ellipse;
            Window parentWindow = Window.GetWindow(tmp);
            parentWindow.Hide();
            parentWindow.Close();
        }

        private void MinimizeWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tmp = sender as System.Windows.Shapes.Ellipse;
            Window parentWindow = Window.GetWindow(tmp);
            parentWindow.WindowState = WindowState.Minimized;
        }


        private void Move_window(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tmp = sender as System.Windows.Controls.Border;
            Window parentWindow = Window.GetWindow(tmp);
            parentWindow.DragMove();
        }
    }
}
