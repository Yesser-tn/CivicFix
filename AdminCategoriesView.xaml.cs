using CivicFix.ViewModel.Admin;
using System.Windows;

namespace CivicFix.UI
{
    public partial class AdminCategoriesView : Window
    {
        public AdminCategoriesView()
        {
            InitializeComponent();
            DataContext = new AdminCategoriesViewModel();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ((AdminCategoriesViewModel)DataContext).AddCategory();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ((AdminCategoriesViewModel)DataContext).SaveChanges();
        }
    }
}
