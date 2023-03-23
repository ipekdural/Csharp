using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fastAndFuriousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/H%C4%B1zl%C4%B1_ve_%C3%96fkeli");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Mad_Max:_Fury_Road");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void johnWickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/John_Wick");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void paranormalActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Paranormal_Activity_(film_serisi)");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void screamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/%C3%87%C4%B1%C4%9Fl%C4%B1k_(film,_1996)");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void thePianistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Piyanist_(film,_2002)");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void theShawshankRedemptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Esaretin_Bedeli");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void greenMileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Ye%C5%9Fil_Yol_(film)");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void ınceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Ba%C5%9Flang%C4%B1%C3%A7");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void ınterstellarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Y%C4%B1ld%C4%B1zlararas%C4%B1");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void duneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Dune:_%C3%87%C3%B6l_Gezegeni_(film,_2021)");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void riseOfEmpiresOttomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Rise_of_Empires:_Ottoman");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void planetEarthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Yery%C3%BCz%C3%BC_(dizi)");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void ancientApocalypseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.imdb.com/title/tt22807484/");
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.LightGreen;
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void yELLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This site made by us.","information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
