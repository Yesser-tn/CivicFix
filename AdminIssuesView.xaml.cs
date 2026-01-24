using CivicFix.ViewModel.Admin;
using CivicFix.ViewModel.Issues;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CivicFix.UI
{
    public partial class AdminIssuesView : Window
    {
        public AdminIssuesView()
        {
            InitializeComponent();
            DataContext = new AdminIssuesViewModel();
        }

        private void Issues_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is DataGrid grid && grid.SelectedItem is CivicFix.ViewModel.Admin.IssueRow issue)
            {
                var view = new UpdateIssueStatusView(issue.Id);
                view.ShowDialog();

                // Reload list
                DataContext = new AdminIssuesViewModel();
            }
        }
    }
}
