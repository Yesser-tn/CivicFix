using CivicFix.ViewModel.Issues;
using System.Windows;
using System.Windows.Controls;

namespace CivicFix.UI
{
    public partial class AgentDashboard : Window
    {
        public AgentDashboard()
        {
            InitializeComponent();
            DataContext = new AgentIssuesViewModel();
        }

        private void Issue_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (((DataGrid)sender).SelectedItem is IssueRow row)
            {
                var view = new UpdateIssueStatusView(row.Id);
                view.ShowDialog();
            }
        }
    }
}
    