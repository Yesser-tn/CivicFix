using CivicFix.Core.Entities;
using CivicFix.Data.Context;
using System;
using System.Linq;
using System.Windows;

namespace CivicFix.UI
{
    public partial class ValidateIssueView : Window
    {
        private readonly int _issueId;
        private readonly int _adminId;

        public ValidateIssueView(int issueId, int adminId)
        {
            InitializeComponent();
            _issueId = issueId;
            _adminId = adminId;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            var action = ((System.Windows.Controls.ComboBoxItem)ActionBox.SelectedItem)?.Content.ToString();
            if (string.IsNullOrEmpty(action)) return;

            using (var context = new CivicFixDbContext())
            {
                var issue = context.Issues.First(i => i.Id == _issueId);
                issue.Status = action;

                context.AuditLogs.Add(new AuditLog
                {
                    Action = action,
                    CreatedAt = DateTime.Now
                });

                context.SaveChanges();
            }

            Close();
        }
    }
}
