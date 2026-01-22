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

        // 👇 THIS METHOD WAS MISSING
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Password = PasswordBox.Password;

            if (_viewModel.Login())
            {
                MessageBox.Show("Login successful!", "CivicFix");
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Error");
            }
        }
    }
}
