using CivicFix.ViewModel.Admin;
using System.Windows;

namespace CivicFix.UI
{
    public partial class AdminAgentAvailabilityView : Window
    {
        public AdminAgentAvailabilityView()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            DataContext = new AdminAgentAvailabilityViewModel();
        }
    }
}
