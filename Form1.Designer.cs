
namespace pagina_web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aVANZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vOLVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserURL = new System.Windows.Forms.WebBrowser();
            this.comboBoxURL = new System.Windows.Forms.ComboBox();
            this.buttonIR = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVANZARToolStripMenuItem,
            this.vOLVERToolStripMenuItem,
            this.iNICIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aVANZARToolStripMenuItem
            // 
            this.aVANZARToolStripMenuItem.Name = "aVANZARToolStripMenuItem";
            this.aVANZARToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.aVANZARToolStripMenuItem.Text = "AVANZAR";
            this.aVANZARToolStripMenuItem.Click += new System.EventHandler(this.aVANZARToolStripMenuItem_Click);
            // 
            // vOLVERToolStripMenuItem
            // 
            this.vOLVERToolStripMenuItem.Name = "vOLVERToolStripMenuItem";
            this.vOLVERToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vOLVERToolStripMenuItem.Text = "VOLVER";
            this.vOLVERToolStripMenuItem.Click += new System.EventHandler(this.vOLVERToolStripMenuItem_Click);
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // webBrowserURL
            // 
            this.webBrowserURL.Location = new System.Drawing.Point(739, 55);
            this.webBrowserURL.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserURL.Name = "webBrowserURL";
            this.webBrowserURL.Size = new System.Drawing.Size(89, 73);
            this.webBrowserURL.TabIndex = 1;
            this.webBrowserURL.Visible = false;
            this.webBrowserURL.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // comboBoxURL
            // 
            this.comboBoxURL.FormattingEnabled = true;
            this.comboBoxURL.Items.AddRange(new object[] {
            "https://virtual.mesoamericana.edu.gt/my/courses.php"});
            this.comboBoxURL.Location = new System.Drawing.Point(12, 28);
            this.comboBoxURL.Name = "comboBoxURL";
            this.comboBoxURL.Size = new System.Drawing.Size(639, 21);
            this.comboBoxURL.TabIndex = 2;
            this.comboBoxURL.SelectedIndexChanged += new System.EventHandler(this.comboBoxURL_SelectedIndexChanged);
            // 
            // buttonIR
            // 
            this.buttonIR.Location = new System.Drawing.Point(658, 28);
            this.buttonIR.Name = "buttonIR";
            this.buttonIR.Size = new System.Drawing.Size(75, 23);
            this.buttonIR.TabIndex = 3;
            this.buttonIR.Text = "IR";
            this.buttonIR.UseVisualStyleBackColor = true;
            this.buttonIR.Click += new System.EventHandler(this.buttonIR_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 55);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(721, 505);
            this.webView21.Source = new System.Uri("https://virtual.mesoamericana.edu.gt/mod/url/view.php?id=305689", System.UriKind.Absolute);
            this.webView21.TabIndex = 4;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(832, 572);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.buttonIR);
            this.Controls.Add(this.comboBoxURL);
            this.Controls.Add(this.webBrowserURL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NAVEGADR WEB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aVANZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vOLVERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowserURL;
        private System.Windows.Forms.ComboBox comboBoxURL;
        private System.Windows.Forms.Button buttonIR;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

