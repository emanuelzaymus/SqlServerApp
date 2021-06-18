using System.Windows.Forms;

namespace SqlServerApp
{
    public partial class UserInput : Form
    {
        public static string Request(string text, string caption)
        {
            var userInput = new UserInput(text, caption);

            return userInput.ShowDialog() == DialogResult.OK ? userInput.Input : null;
        }

        private string Input => inputTextBox.Text;

        private UserInput(string text, string caption)
        {
            InitializeComponent();

            inputLabel.Text = text;
            Text = caption;
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
