using System.Windows;

namespace CivicFix.UI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var login = new LoginView();
            login.Show();
        }
    }
}
