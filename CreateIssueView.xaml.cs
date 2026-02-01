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

            _viewModel = new CreateIssueViewModel(userId);
            DataContext = _viewModel;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // Location validation
            if (string.IsNullOrWhiteSpace(_viewModel.Location))
            {
                MessageBox.Show("Please enter a location.");
                return;
            }

            // Optional extra validation (recommended)
            if (string.IsNullOrWhiteSpace(_viewModel.Title))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            if (_viewModel.SelectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            _viewModel.Create();

            MessageBox.Show("Issue reported successfully ✅");
            this.Close();
        }

    }
}
