using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

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

            mainDataGridView.DataSource = _bindingSource;
            bindingNavigator.BindingSource = _bindingSource;
        }

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
                var dbName = databasesListBox.SelectedItem.ToString();
                _controller.ChangeDatabase(dbName);

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
                var dbName = databasesListBox.SelectedItem.ToString();
                _controller.DropDatabase(dbName);
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
            ReloadTable();
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
                var tableName = tablesListBox.SelectedItem.ToString();
                _controller.DropTable(tableName);
                ReloadTableNames();
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void ReloadTable()
        {
            try
            {
                var tableName = tablesListBox.SelectedItem.ToString();
                var dataSet = _controller.GetTable(tableName, filterTextBox.Text);
                _bindingSource.DataSource = dataSet;
                _bindingSource.DataMember = tableName;
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
                ReloadTable();
            }
            catch (Exception ex)
            {
                SetMessage(ex);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            ReloadTable();
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
