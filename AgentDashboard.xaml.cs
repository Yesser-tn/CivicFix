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
            _agentId = agentId;
            DataContext = new AgentIssuesViewModel(_agentId);
        }

        private void Issue_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is DataGrid grid && grid.SelectedItem is IssueRow issue)
            {
                var view = new UpdateIssueStatusView(issue.Id);
                view.ShowDialog();

                DataContext = new AgentIssuesViewModel(_agentId);
            }
        }
    }
}
