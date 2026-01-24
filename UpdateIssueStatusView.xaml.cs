using CivicFix.ViewModel.Issues;
using System.Windows;

namespace CivicFix.UI
{
    public partial class UpdateIssueStatusView : Window
    {
        public UpdateIssueStatusView(int issueId)
        {
            InitializeComponent();
            DataContext = new UpdateIssueStatusViewModel(issueId);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ((UpdateIssueStatusViewModel)DataContext).Save();
            Close();
        }
    }
}
