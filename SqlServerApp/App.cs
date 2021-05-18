﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlServerApp
{
    public partial class App : Form
    {
        private readonly MainController _controller = new MainController();

        private readonly BindingSource _bindingSource = new BindingSource(new Container());

        public App()
        {
            InitializeComponent();

            tablesListBox.DataSource = _controller.GetTableNames();
            tablesListBox.SelectedValueChanged += SelectedTableChanged;

            mainDataGridView.DataSource = _bindingSource;

            bindingNavigator.BindingSource = _bindingSource;
        }

        private void SelectedTableChanged(object sender, EventArgs e) => ReloadTable();

        private void ReloadTable()
        {
            var tableName = (string)tablesListBox.SelectedItem;
            _bindingSource.DataSource = _controller.GetTable(tableName);
            _bindingSource.DataMember = tableName;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int rowsAffected = _controller.SaveChanges((DataSet)_bindingSource.DataSource);
            SetMessage("Rows affected: " + rowsAffected);
            ReloadTable();
        }

        private void SetMessage(string msg) => messageLabel.Text = msg;

    }
}
