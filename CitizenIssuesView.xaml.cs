using CivicFix.ViewModel.Issues;
using System.Windows;

namespace CivicFix.UI
{
    public partial class CitizenIssuesView : Window
    {
        public CitizenIssuesView(int userId)
        {
            InitializeComponent();
            DataContext = new CitizenIssuesViewModel(userId);
        }
    }
}
