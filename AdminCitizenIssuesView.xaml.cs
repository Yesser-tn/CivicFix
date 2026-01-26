using CivicFix.ViewModel.Admin;
using System.Windows;

namespace CivicFix.UI
{
    public partial class AdminCitizenIssuesView : Window
    {
        public AdminCitizenIssuesView()
        {
            InitializeComponent();
            DataContext = new AdminCitizenIssuesViewModel();

        }
    }
}
