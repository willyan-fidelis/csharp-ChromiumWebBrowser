using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

//https://ourcodeworld.com/articles/read/173/how-to-use-cefsharp-chromium-embedded-framework-csharp-in-a-winforms-application


namespace CefTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }
        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            try
            {
                Cef.Initialize(new CefSettings());
                browser = new ChromiumWebBrowser("http://localhost:3000");
                //browser = new ChromiumWebBrowser("C:/Projetos/rocketseat/Pure%20-HTML-ES6/curso-es6-master/public/index.html");
                this.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;
            }
            catch
            {

            }
        }
    }
}
