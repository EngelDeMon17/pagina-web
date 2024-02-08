using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pagina_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            buttonIR.Left = this.ClientSize.Width - buttonIR.Width;
            comboBoxURL.Width = buttonIR.Left - comboBoxURL.Left;
        }

        private void aVANZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void vOLVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // webView21.GoHome();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBoxURL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonIR_Click(object sender, EventArgs e)

        {

          /*  if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(comboBoxURL.Text);
            }*/


            string url = comboBoxURL.Text.ToString();
            
            if (!(url.Contains(".")))
            {
                url = " https://www.google.com/search?q=" + url;

            }


            if (!(url.Contains("http")) || (!(url.Contains("."))))
            {
                url = "http://" + url;

            }
            


            webView21.CoreWebView2.Navigate(url);
            //webView21.Navigate(new Uri(comboBoxURL.SelectedItem.ToString()));
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
    
}
