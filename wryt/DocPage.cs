using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wryt
{
    public partial class DocPage : TabPage
    {
        public DocPage(string text)
        {
            InitializeComponent();
            this.Text = text;
        }

        public DocPage()
        {
            InitializeComponent();
        }

        private void DocPage_Enter(object sender, EventArgs e)
        {
            this.Document.Select();
        }
    }
}
