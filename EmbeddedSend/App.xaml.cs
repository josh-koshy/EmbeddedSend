// "(C) 2024 Joshua Koshy."

using System.Configuration;
using System.Data;
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
            

            base.OnStartup(e);
        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }

}
