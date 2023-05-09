using System;
using System.Windows.Forms;
using System.Timers;

namespace Math_Solver
{
    public partial class Form1 : Form
    {
        private bool _firstLoad;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != string.Empty)
            {
                webBrowser1.Url = new Uri(txtUrl.Text);
            }
            else
            {
                MessageBox.Show(@"Please enter a valid URL.");
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            txtset.Text = null;

            if (webBrowser1.Document == null ||
                !int.TryParse(webBrowser1.Document.GetElementById("task_x")?.InnerText, out var num1) ||
                !int.TryParse(webBrowser1.Document.GetElementById("task_y")?.InnerText, out var num2) ||
                !int.TryParse(webBrowser1.Document.GetElementById("task_res")?.InnerText, out var res)) return;
            var op = webBrowser1.Document.GetElementById("task_op")?.InnerText;

            int remain;
            switch (op)
            {
                case "+":
                    remain = num1 + num2;
                    break;
                case "–":
                    remain = num1 - num2;
                    break;
                case "/":
                    remain = num1 / num2;
                    break;
                case "×":
                    remain = num1 * num2;
                    break;
                default:
                    MessageBox.Show(@"Unknown operator: " + op);
                    return;
            }

            txtset.Text = $@"{num1} {op} {num2} = {res}";

            if (remain == res)
            {
                txtresult.Text = @"Yes!";
                webBrowser1.Document.GetElementById("button_correct")?.InvokeMember("click");
            }
            else
            {
                txtresult.Text = @"No!";
                webBrowser1.Document.GetElementById("button_wrong")?.InvokeMember("click");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            switch (_firstLoad)
            {
                case false:
                {
                    if (webBrowser1.Document != null)
                        webBrowser1.Document.GetElementById("button_correct")?.InvokeMember("click");
                    timer1.Enabled = true;
                    _firstLoad = true;
                    break;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}