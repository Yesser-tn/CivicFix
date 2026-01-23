using CivicFix.ViewModel.Issues;
using System.Windows;

namespace CivicFix.UI
{
    public partial class IssueDetailsView : Window
    {
        public IssueDetailsView(int issueId)
        {
            InitializeComponent();
            DataContext = new IssueDetailsViewModel(issueId);
        }
    }
}
