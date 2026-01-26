    using CivicFix.Core.Entities;
    using System.Windows;

    namespace CivicFix.UI
    {
        public partial class CitizenDashboard : Window
        {
            private readonly User _currentUser;

            // 👇 Receive user in constructor
            public CitizenDashboard(User user)
            {
                InitializeComponent();
                _currentUser = user;
            }

        private void ReportIssue_Click(object sender, RoutedEventArgs e)
        {
            var view = new CreateIssueView(_currentUser.Id);
            view.ShowDialog();
        }

        private void MyIssues_Click(object sender, RoutedEventArgs e)
            {
                var view = new CitizenIssuesView(_currentUser.Id);
                view.ShowDialog();
            }

        }
    }
