using CivicFix.ViewModel.Issues;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CivicFix.UI
{
    public partial class AgentDashboard : Window
    {
        private readonly int _agentId;

        public AgentDashboard(int agentId)
        {
            InitializeComponent();
            _agentId = agentId; // ✅ FIX 1
            DataContext = new AgentIssuesViewModel(_agentId);
        }

        private void Issue_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is DataGrid grid && grid.SelectedItem is AgentIssueRow issue)
            {
                var detailsView = new IssueDetailsView(issue.Id, canUpdateStatus: true);
                detailsView.ShowDialog();

                DataContext = new AgentIssuesViewModel(_agentId);
            }
        }

    }
}
