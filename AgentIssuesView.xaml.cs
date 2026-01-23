using CivicFix.ViewModel.Issues;
using System.Windows;

namespace CivicFix.UI
{
    public partial class AgentIssuesView : Window
    {
        public AgentIssuesView()
        {
            InitializeComponent();
            DataContext = new AgentIssuesViewModel();
        }

        private void Issues_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (((System.Windows.Controls.DataGrid)sender).SelectedItem is IssueRow issue)
            {
                var view = new UpdateIssueStatusView(issue.Id);
                view.ShowDialog();

                // 🔥 FORCE reload from database
                DataContext = null;
                DataContext = new AgentIssuesViewModel();
            }
        }
    }
}
