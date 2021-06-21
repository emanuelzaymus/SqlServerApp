using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SqlServerApp
{
    public partial class FilterColumnsForm : Form
    {
        public static string[] Request(DataGridViewColumnCollection columns)
        {
            var form = new FilterColumnsForm(columns);

            return form.ShowDialog() == DialogResult.OK ? form.CheckedColumns : null;
        }

        private string[] CheckedColumns => columnsCheckedListBox.CheckedItems.Cast<string>().ToArray();

        private FilterColumnsForm(DataGridViewColumnCollection columns)
        {
            InitializeComponent();

            IEnumerable<DataGridViewColumn> viewColumns = columns.Cast<DataGridViewColumn>();

            columnsCheckedListBox.Items.Clear();
            columnsCheckedListBox.Items.AddRange(viewColumns.Select(c => c.Name).ToArray());

            foreach (var col in viewColumns)
            {
                columnsCheckedListBox.SetItemChecked(col.Index, col.Visible);
            }
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
