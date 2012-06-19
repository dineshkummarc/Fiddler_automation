using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Aetheon.FiddlerExtensions.DelayedResponses
{
    public partial class DelayedResponsesUI : UserControl, IDelayedResponsesUI
    {
        private Bitmap okBmp;
        private Bitmap notOkBmp;
        private Form aboutForm = null;


        public DelayedResponsesUI()
        {
            InitializeComponent();

            Stream okBmp = typeof(DelayedResponsesUI).Assembly.GetManifestResourceStream(
                "Aetheon.FiddlerExtensions.DelayedResponses.Resources.ok.bmp");

            Stream notOkBmp = typeof(DelayedResponsesUI).Assembly.GetManifestResourceStream(
                "Aetheon.FiddlerExtensions.DelayedResponses.Resources.not.bmp");

            this.okBmp = new Bitmap(okBmp);
            this.notOkBmp = new Bitmap(notOkBmp);
        }

        DelayedResponsesInformation[] IDelayedResponsesUI.DelayedInformations
        {
            get
            {
                List<DelayedResponsesInformation> l = new List<DelayedResponsesInformation>();
                IEnumerator dEnum = ((BindingSource) drConfigurationsGrid.DataSource).GetEnumerator();
                while (dEnum.MoveNext())
                {
                    l.Add((DelayedResponsesInformation)dEnum.Current);
                }

                return l.ToArray();

            }

            set
            {
                foreach (DelayedResponsesInformation d in value)
                {
                    ((BindingSource)this.drConfigurationsGrid.DataSource).Add(d);
                }

            }
        }

        void IDelayedResponsesUI.SetRuleTester(DelayedResponsesStatus status)
        {
            switch (status)
            {
                case DelayedResponsesStatus.OK:
                    sessionDelayedPic.Image = this.okBmp;
                    break;

                case DelayedResponsesStatus.NOTEXISTS:
                    sessionDelayedPic.Image = this.notOkBmp;
                    break;

                default:
                    sessionDelayedPic.Image = null;
                    break;
            }
        }

        public void ShowAboutForm()
        {
            if (this.aboutForm == null)
            {
                AboutWindow awindow = new AboutWindow();

                this.aboutForm = new Form();
                this.aboutForm.Text = "About";
                this.aboutForm.Size = new System.Drawing.Size(250, 180);
                this.aboutForm.StartPosition = FormStartPosition.CenterScreen;
                this.aboutForm.WindowState = FormWindowState.Normal;
                this.aboutForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.aboutForm.MaximizeBox = false;
                this.aboutForm.MinimizeBox = false;
                this.aboutForm.Controls.Add(awindow);
            }

            this.aboutForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowAboutForm();
        }
    }
}
