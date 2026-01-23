using CivicFix.ViewModel.Admin;
using System.Windows;

namespace CivicFix.UI
{
    public partial class AuditLogsView : Window
    {
        public AuditLogsView()
        {
            InitializeComponent();
            DataContext = new AuditLogsViewModel();
        }
    }
}
