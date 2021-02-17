using System.Windows.Forms;

namespace UnboundDataGridViewComboBox
{
    public static class Extensions
    {
        public static bool IsComboBoxCell(this DataGridViewCell sender) => 
            sender.EditType != null && sender.EditType == typeof(DataGridViewComboBoxEditingControl);
    }
}