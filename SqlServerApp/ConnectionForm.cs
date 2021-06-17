using System;
using System.Windows.Forms;

namespace SqlServerApp
{
    public partial class ConnectionForm : Form
    {
        public static string RequestConnectionString(string defaultConnectionString)
        {
            var connectionForm = new ConnectionForm(defaultConnectionString);

            connectionForm.ShowDialog();

            return connectionForm.ConnectionString;
        }

        private string ConnectionString => connectionStringTextBox.Text;

        private ConnectionForm(string defaultConnectionString)
        {
            InitializeComponent();
            connectionStringTextBox.Text = defaultConnectionString;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}
