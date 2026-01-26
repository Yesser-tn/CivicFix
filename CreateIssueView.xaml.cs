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
            // 🛑 BASIC VALIDATION (important)
            if (string.IsNullOrWhiteSpace(_viewModel.Title) ||
                _viewModel.SelectedCategoryId == 0)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            _viewModel.Create();

            MessageBox.Show("Issue reported successfully ✅");
            this.Close();
        }
    }
}
