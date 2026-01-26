using CivicFix.ViewModel.Admin;
using System.Windows;

namespace CivicFix.UI
{
    public partial class AssignAgentView : Window
    {
        private readonly AssignAgentViewModel _vm;

        public AssignAgentView(int issueId)
        {
            InitializeComponent();
            _vm = new AssignAgentViewModel(issueId);
            DataContext = _vm;
        }

        private void Assign_Click(object sender, RoutedEventArgs e)
        {
            _vm.Assign();

            MessageBox.Show("Agent assigned successfully");

            DialogResult = true;
            Close();
        }
    }
}
