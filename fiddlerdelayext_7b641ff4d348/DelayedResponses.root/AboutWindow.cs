using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aetheon.FiddlerExtensions.DelayedResponses
{
    public partial class AboutWindow : UserControl
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
        }
    }
}
