using System;
using System.Text;
using System.Windows.Forms;

namespace WebHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonURI_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) return;
            textBoxURI.Text = Clipboard.GetText();
        }

        private void buttonHeaders_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText()) return;
            textBoxHeaders.Text = Clipboard.GetText();
        }

        private void buttonGetFunction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxURI.Text)) return;
            if (string.IsNullOrEmpty(textBoxHeaders.Text)) return;

            string uri = textBoxURI.Text;
            var headers = textBoxHeaders.Lines;
            var result = new StringBuilder();

            result.Append("private IDVResponse getResponse()\n{\n");
            result.Append("}");
        }
    }
}
