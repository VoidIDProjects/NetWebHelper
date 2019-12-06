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
            if (!Clipboard.ContainsText()) return;
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
            string acLanguage = null;
            string userAgent = null;

            result.Append("private IDVResponse getResponse()\n{\n");
            result.Append($"IDVRequestData data = new IDVRequestData(\"{uri}\");\n");
            foreach (var item in headers)
            {
                if (item.Contains("Host")) continue;
                if (item.Contains("Connection")) continue;
                if (item.Contains("Accept-Encoding")) continue;
                if (item.Contains("Accept-Language")){ acLanguage = item.Split(' ')[1]; continue; }
                if (item.Contains("User-Agent")) { userAgent = item.Split(' ')[1]; continue; }
                result.Append($"data.Headers.Add(\"{item}\");\n");
            }
            if (!string.IsNullOrEmpty(acLanguage)) result.Append($"_client.AcceptLanguage = \"{acLanguage}\";\n");
            if(!string.IsNullOrEmpty(userAgent)) result.Append($"_client.UserAgent = \"{userAgent}\";\n\n");
            result.Append("try\n{\nreturn _client.SendRequest(data);\n}\ncatch(Exception ex)\n{\nthrow;\n}\n");
            result.Append("}");
            Clipboard.Clear();
            Clipboard.SetText(result.ToString());
        }
    }
}
