// "(C) 2024 Joshua Koshy."

using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;
using EmbeddedSend.Views;

namespace EmbeddedSend
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e) // overriding this because getting "into" this state is pretty helpful
        {
            MainWindow window = new MainWindow();
            window.Show();

            window.viewModel.SettingsMenuEvent += ShowSettingsWindow;
            window.viewModel.AboutMenuEvent += ShowAboutWindow;

            base.OnStartup(e);
        }

        private static void ShowSettingsWindow(object? sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new();
            settingsWindow.ShowDialog();
        }

        private static void ShowAboutWindow(object? sender, EventArgs e)
        {
            Debug.WriteLine("Show About Window Called");
        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }

}
