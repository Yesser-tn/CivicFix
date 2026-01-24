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
            if (user == null || user.Role == null)
            {
                MessageBox.Show("Invalid credentials");
                return;
            }

            Window window = null;

            switch (user.Role.Name)
            {
                case "Admin":
                    window = new AdminDashboard(user.Id);

                    break;

                case "Agent":
                    window = new AgentDashboard(user.Id);
                    break;

                case "Citizen":
                    window = new CitizenDashboard(user);
                    break;
            }

            window.Show();
            this.Close();
        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            new RegisterView().ShowDialog();
        }



    }
}
