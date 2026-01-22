using CivicFix.ViewModel.Issues;
using System.Windows;

namespace CivicFix.UI
{
    public partial class CreateIssueView : Window
    {
        private readonly CreateIssueViewModel _viewModel;

        public CreateIssueView(int userId)
        {
            InitializeComponent();

            _viewModel = new CreateIssueViewModel
            {
                UserId = userId
            };

            DataContext = _viewModel;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.Create())
            {
                MessageBox.Show("Issue reported successfully.");
                this.Close();
            }
        }
    }
}
