using CivicFix.ViewModel.Issues;
using System.Windows;

namespace CivicFix.UI
{
    public partial class IssueDetailsView : Window
    {
        private readonly IssueDetailsViewModel _viewModel;

        public IssueDetailsView(int issueId, bool canUpdateStatus = false)
        {
            InitializeComponent();
            _viewModel = new IssueDetailsViewModel(issueId, canUpdateStatus);
            DataContext = _viewModel;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Save();
            MessageBox.Show("Issue updated successfully.");
            Close();
        }
    }
}
