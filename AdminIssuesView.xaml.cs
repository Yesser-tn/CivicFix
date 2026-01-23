using CivicFix.ViewModel.Issues;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CivicFix.UI
{
    public partial class AdminIssuesView : Window
    {
        private readonly int _adminId;

        public AdminIssuesView(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
            DataContext = new AdminIssuesViewModel();
        }

        private void Issues_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (((DataGrid)sender).SelectedItem is IssueRow issue)
            {
                var view = new ValidateIssueView(issue.Id, _adminId);
                view.ShowDialog();

                // Refresh after validation
                DataContext = null;
                DataContext = new AdminIssuesViewModel();
            }
        }
    }
}
