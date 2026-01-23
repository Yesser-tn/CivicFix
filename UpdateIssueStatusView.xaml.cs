using CivicFix.ViewModel.Issues;
using System.Windows;

namespace CivicFix.UI
{
    public partial class UpdateIssueStatusView : Window
    {
        private readonly UpdateIssueStatusViewModel _vm;

        public UpdateIssueStatusView(int issueId)
        {
            InitializeComponent();
            _vm = new UpdateIssueStatusViewModel(issueId);
            DataContext = _vm;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _vm.Save();
            Close();
        }
    }
}
