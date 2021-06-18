using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Linq;

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
        }

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

                tablesListBox.DataSource = _controller.GetTableNames();
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
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void ReloadTableData()
        {
            try
            {
                var dataSet = _controller.GetTableData(SelectedTableName, filterTextBox.Text);
                _bindingSource.DataSource = dataSet;
                _bindingSource.DataMember = SelectedTableName;

                // Update Table Structure => table columns list box
                var columnNames = dataSet.Tables[SelectedTableName].Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
                columnsListBox.DataSource = columnNames;
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = _controller.SaveChanges((DataSet)_bindingSource.DataSource);
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
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void SelectedColumnChanged(object sender, EventArgs e)
        {
            columnNameTextBox.Text = SelectedColumnName;
        }

        private void AlterColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newColumnName = columnNameTextBox.Text;
                _controller.AlterColumn(SelectedTableName, SelectedColumnName, newColumnName);
                ReloadTableData();
            }
            catch (Exception ex)
            {
                SetMessage(ex);
                throw;
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
