using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace SqlServerApp
{
    public partial class App : Form
    {
        private readonly MainController _controller;

        private readonly BindingSource _bindingSource = new BindingSource(new Container());

        public App()
        {
            InitializeComponent();

            _controller = CreateMainController();
            ReloadDatabaseNames();
            databasesListBox.SelectedValueChanged += SelectedDatabaseChanged;
            databasesListBox.SelectedItem = _controller.CurrentDatabaseName;
            ReloadTableNames();
            tablesListBox.SelectedValueChanged += SelectedTableChanged;

            columnsListBox.SelectedValueChanged += SelectedColumnChanged;

            mainDataGridView.DataSource = _bindingSource;
            bindingNavigator.BindingSource = _bindingSource;

            columnTypeComboBox.Items.AddRange(DataTypes.GetValues());
        }

        private DataSet DataSet
        {
            get => (DataSet)_bindingSource.DataSource;
            set
            {
                _bindingSource.DataSource = value;
                _bindingSource.DataMember = SelectedTableName;
            }
        }

        private DataTable DataTable => DataSet.Tables[SelectedTableName];

        private List<ColumnInfo> _columnInfos;

        private string SelectedDatabaseName => databasesListBox.SelectedItem.ToString();

        private string SelectedTableName => tablesListBox.SelectedItem.ToString();

        private string SelectedColumnName => columnsListBox.SelectedItem.ToString();

        private MainController CreateMainController()
        {
            while (true)
            {
                try
                {
                    var connectionString = ConnectionStringProvider.Provide();
                    return new MainController(connectionString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Connection String." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ReloadDatabaseNames() => databasesListBox.DataSource = _controller.GetDatabaseNames();

        private void ReloadTableNames() => tablesListBox.DataSource = _controller.GetTableNames();

        private void SelectedDatabaseChanged(object sender, EventArgs e)
        {
            try
            {
                _controller.ChangeDatabase(SelectedDatabaseName);

                ReloadTableNames();
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void CreateDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dbName = UserInput.Request("New database name", "New Database");
                _controller.CreateDatabase(dbName);

                ReloadDatabaseNames();

                SetMessage("New database created successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void DropDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DropDatabase(SelectedDatabaseName);
                ReloadDatabaseNames();

                SetMessage("Database dropped successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void SelectedTableChanged(object sender, EventArgs e)
        {
            filterTextBox.Text = default;
            ReloadTableData();

            tableNameTextBox.Text = SelectedTableName;
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.CreateTable();
                ReloadTableNames();

                SetMessage("New table created successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void DropTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DropTable(SelectedTableName);
                ReloadTableNames();

                SetMessage("Table dropped successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        /// <summary>
        /// Reload all.
        /// </summary>
        private void ReloadTableData()
        {
            try
            {
                DataSet = _controller.GetTableData(SelectedTableName, filterTextBox.Text);

                ReloadColumnNames();
                ReloadColumnInfos();
            }
            catch (Exception ex)
            {
                SetMessage(ex);
                throw;
            }
        }

        private void FilterColumnsButton_Click(object sender, EventArgs e)
        {
            string[] selectedColumns = FilterColumnsForm.Request(mainDataGridView.Columns);

            if (selectedColumns != null)
            {
                foreach (DataGridViewColumn col in mainDataGridView.Columns)
                {
                    col.Visible = selectedColumns.Contains(col.Name);
                }
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = _controller.SaveChanges(DataSet);
                SetMessage("Rows affected: " + rowsAffected);
                ReloadTableData();
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            ReloadTableData();
        }

        private void RenameTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newTableName = tableNameTextBox.Text;
                _controller.RenameTable(SelectedTableName, newTableName);

                ReloadTableNames();

                SetMessage("Table renamed successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void ReloadColumnNames()
        {
            columnsListBox.DataSource = DataTable.GetColumnNames();
        }

        private void ReloadColumnInfos()
        {
            _columnInfos = _controller.GetColumnInfos(SelectedTableName);
        }

        private void SelectedColumnChanged(object sender, EventArgs e)
        {
            columnNameTextBox.Text = SelectedColumnName;

            ColumnInfo columnInfo = _columnInfos?.FirstOrDefault(c => c.ColumnName == SelectedColumnName);

            columnTypeComboBox.SelectedItem = columnInfo?.DataType;
            nullableCheckBox.Checked = columnInfo?.IsNullable ?? false;
            autoIncrementCheckBox.Checked = columnInfo?.AutoIncrement ?? false;
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                var columnName = columnNameTextBox.Text;
                var dataType = (string)columnTypeComboBox.SelectedItem;
                var isNullable = nullableCheckBox.Checked;
                _controller.AddColumn(SelectedTableName, columnName, dataType, isNullable);

                ReloadTableData();

                SetMessage("New column created successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void AlterColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                AlterColumn();

                RenameColumn();

                ReloadTableData();

                SetMessage("Column altered successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void AlterColumn()
        {
            var newDataType = (string)columnTypeComboBox.SelectedItem;
            var newIsNullable = nullableCheckBox.Checked;
            _controller.AlterColumn(SelectedTableName, SelectedColumnName, newDataType, newIsNullable);
        }

        private void RenameColumn()
        {
            var newColumnName = columnNameTextBox.Text;
            _controller.RenameColumn(SelectedTableName, SelectedColumnName, newColumnName);
        }

        private void DropColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DropColumn(SelectedTableName, SelectedColumnName);

                ReloadTableData();

                SetMessage("Column dropped successfully.");
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void SetMessage(string msg)
        {
            messageLabel.Text = msg;
        }

        private void SetMessage(Exception ex)
        {
            messageLabel.Text = ex.Message.Replace("\r\n", " ");
        }

        protected override void OnClosed(EventArgs e)
        {
            _controller.Dispose();
        }

    }
}
