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
    }
}
