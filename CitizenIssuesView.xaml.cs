using CivicFix.ViewModel.Issues;
using System.Windows;
using System.Windows.Controls;

namespace CivicFix.UI
{
    public partial class CitizenIssuesView : Window
    {
        private readonly int _userId;

        public CitizenIssuesView(int userId)
        {
            InitializeComponent();
            _userId = userId;
            DataContext = new CitizenIssuesViewModel(userId);
        }

        private void Issues_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (((DataGrid)sender).SelectedItem is IssueRow row)
            {
                var details = new IssueDetailsView(row.Id);
                details.ShowDialog();
            }
        }
    }
}
