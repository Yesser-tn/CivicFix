using System.Windows;

namespace CivicFix.UI
{
    public partial class AdminDashboard : Window
    {
        private readonly int _adminId;

        public AdminDashboard(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
        }

        private void ValidateIssues_Click(object sender, RoutedEventArgs e)
        {
            var view = new AdminIssuesView();
            view.ShowDialog();
        }


        private void ViewLogs_Click(object sender, RoutedEventArgs e)
        {
            var view = new AuditLogsView();
            view.ShowDialog();
        }

        private void ViewStatistics_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Statistics module coming soon 👷‍♂️");
        }
        private void CitizenActivity_Click(object sender, RoutedEventArgs e)
        {
            var view = new AdminCitizenIssuesView();
            view.ShowDialog();
        }
        private void AgentAvailability_Click(object sender, RoutedEventArgs e)
        {
            var view = new AdminAgentAvailabilityView();
            view.ShowDialog();
        }


    }
}
