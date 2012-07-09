using System.Windows.Forms;

namespace GeneticColors.Classes
{
    public static class MessageBoxExtensions
    {
        #region methods
        public static void ShowError(this IWin32Window form, string message)
        {
            MessageBox.Show(form, message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(this IWin32Window form, string message)
        {
            MessageBox.Show(form, message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInformation(this IWin32Window form, string message)
        {
            MessageBox.Show(form, message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowQuestion(this IWin32Window form, string message)
        {
            MessageBox.Show(form, message, @"Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        #endregion
    }
}
