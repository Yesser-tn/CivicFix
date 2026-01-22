using CivicFix.ViewModel.Auth;
using System.Windows;

namespace CivicFix.UI
{
    public partial class RegisterView : Window
    {
        private readonly RegisterViewModel _viewModel;

        public RegisterView()
        {
            InitializeComponent();
            _viewModel = new RegisterViewModel();
            DataContext = _viewModel;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Password = PasswordBox.Password;

            if (_viewModel.Register())
            {
                MessageBox.Show("Registration successful! You can now log in.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email already exists.", "Error");
            }
        }
    }
}
