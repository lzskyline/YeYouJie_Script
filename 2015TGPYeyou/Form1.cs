using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2015TGPYeyou
{
    public partial class Form1 : Form
    {
        HtmlElement AE;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("登陆后按下Ctrl+鼠标点击兑换按钮即可开始,按下Alt停止","S.K.");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
            if (e.Url.AbsoluteUri == "javascript:;" && Control.ModifierKeys == Keys.Control)
            {
                AE = webBrowser1.Document.ActiveElement;
                timer1.Enabled = true;
                Text = "页游节小助手 - 2015 [运行中]";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt)
            {
                timer1.Enabled = false;
                Text = "页游节小助手 - 2015 [S.K.]";
            }
            AE.InvokeMember("Click");
        }
    }
}
