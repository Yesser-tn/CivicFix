using CivicFix.ViewModel.Auth;
using System.Windows;

namespace CivicFix.UI
{
    public partial class LoginView : Window
    {
        private readonly LoginViewModel _viewModel;

        public LoginView()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel();
            DataContext = _viewModel;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Password = PasswordBox.Password;

            var user = _viewModel.Authenticate();

            if (user == null)
            {
                MessageBox.Show("Invalid credentials", "Error");
                return;
            }

            Window dashboard = null;

            switch (user.Role.Name)
            {
                case "Admin":
                    dashboard = new AdminDashboard();
                    break;

                case "Agent":
                    dashboard = new AgentDashboard();
                    break;

                case "Citizen":
                    dashboard = new CitizenDashboard(user);
                    break;
            }

            dashboard.Show();
            this.Close();
        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            var registerView = new RegisterView();
            registerView.ShowDialog();
        }


    }
}
