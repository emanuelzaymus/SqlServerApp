﻿using System;
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

            databasesListBox.DataSource = _controller.GetDatabaseNames();
            databasesListBox.SelectedValueChanged += SelectedDatabaseChanged;
            databasesListBox.SelectedItem = _controller.CurrentDatabaseName;

            tablesListBox.DataSource = _controller.GetTableNames();
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
                catch (Exception e)
                {
                    MessageBox.Show("Invalid Connection String." + e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

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
                SetMessage(ex.Message);
            }
        }

        private void SelectedTableChanged(object sender, EventArgs e)
        {
            filterTextBox.Text = default;
            ReloadTable();
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
            catch (Exception e)
            {
                SetMessage(e.Message);
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int rowsAffected = _controller.SaveChanges((DataSet)_bindingSource.DataSource);
            SetMessage("Rows affected: " + rowsAffected);
            ReloadTable();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void SetMessage(string msg)
        {
            messageLabel.Text = msg;
        }
    }
}
