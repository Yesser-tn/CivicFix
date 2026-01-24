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
                MessageBox.Show("Account created successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show(_viewModel.ErrorMessage, "Error");
            }
        }

    }
}
