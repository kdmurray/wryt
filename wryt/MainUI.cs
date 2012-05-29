using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wryt
{
    public partial class MainUI : Form
    {
        int lastTabID = 0;

        public MainUI(int initialTabs)
        {
            InitializeComponent();

            for (int i = 0; i < initialTabs; i++)
            {
                CreateNewDocument();
            }
        }

        public MainUI()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
            tabDocs.SelectedTab = tabDocs.TabPages[tabDocs.TabPages.Count - 1];
        }

        private void CreateNewDocument()
        {
            lastTabID++;
            tabDocs.TabPages.Add(new DocPage("Document " + lastTabID.ToString()));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutDialog = new AboutUI();
            aboutDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
