using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fiddler;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace Aetheon.FiddlerExtensions.DelayedResponses
{
    /// <summary>
    /// Adapts the delayed response interface to Fiddler
    /// </summary>
    public class FiddlerUIAdapter
    {
        /// <summary>
        /// Fiddler UI unique key
        /// </summary>
        private const string TabPageKey = "aetheonDR";

        #region Private Key

        /// <summary>
        /// Persistense UI file path
        /// </summary>
        private string persistenceXmlConfigFilePath = 
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) 
            + "\\aetheon.fidder.delayedResponse.config.xml";
        /// <summary>
        /// Fiddler UI tab
        /// </summary>
        private IDelayedResponsesUI respUI;

        #endregion

        #region Public Properties 

        /// <summary>
        /// Adapter UI
        /// </summary>
        public IDelayedResponsesUI UI
        {
            get { return this.respUI; }
        }

        #endregion

        public FiddlerUIAdapter()
        {
            DelayedResponsesInformation[] data = LoadPersistedData();

            this.respUI = new DelayedResponsesUI();
            this.respUI.DelayedInformations = data;

            this.FiddlerGlue();
        }

        #region Public Methods

        /// <summary>
        /// Get DelayInformation for the given url and msgBody. Regular Expression
        /// rules will be tested. 
        /// </summary>
        /// <param name="url">Session url</param>
        /// <param name="msgBody">Session body</param>
        /// <returns>
        /// The delay information if exists; otherwise null
        /// </returns>
        public DelayedResponsesInformation GetDelayFor(string url, string msgBody)
        {
            foreach(DelayedResponsesInformation data in this.respUI.DelayedInformations)
            {
            
                try
                {
                    Regex urlre = new Regex(data.UrlRegExFilter, RegexOptions.IgnoreCase);
                    if (urlre.IsMatch(url) && data.Enabled)
                    {
                        if (string.IsNullOrEmpty(data.ContentRegExFilter))
                            return data;
                        else
                        {
                            Regex contentRegex = new Regex(data.ContentRegExFilter, RegexOptions.IgnoreCase);
                            if (contentRegex.IsMatch(msgBody))
                            {
                                return data;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }

            return null;
        }

        #endregion

        #region Private Methods


        /// <summary>
        /// Creates UI adapater and register the needed Fiddler events
        /// </summary>
        private void FiddlerGlue()
        {
            FiddlerApplication.UI
                .tabsViews
                .TabPages.Add(TabPageKey, "[Aetheon] Delayed Responses");

            FiddlerApplication.UI
               .tabsViews.TabPages[TabPageKey].Controls.Add((UserControl)this.UI);

            FiddlerApplication.UI
               .tabsViews.TabPages[TabPageKey].Controls[0].Dock = System.Windows.Forms.DockStyle.Fill;

            //
            // Saves the extension configuration to persistence file
            //
            FiddlerApplication.UI.FormClosing += new FormClosingEventHandler(UI_FormClosing);
            //
            // Check if Selected session match any rule
            //
            FiddlerApplication.UI.lvSessions.SelectedIndexChanged += new EventHandler(lvSessions_SelectedIndexChanged);
        }

        private void lvSessions_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session selSession = FiddlerApplication.UI.GetFirstSelectedSession();
            if (
                selSession != null
            )
            {

                if (this.GetDelayFor(selSession.url, selSession.GetResponseBodyAsString()) != null)
                    this.respUI.SetRuleTester(DelayedResponsesStatus.OK);
                else
                    this.respUI.SetRuleTester(DelayedResponsesStatus.NOTEXISTS);

            }
            else
            {
                this.respUI.SetRuleTester(DelayedResponsesStatus.NONE);
            }

        }

        private void UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DelayedResponsesInformation[] datas = this.respUI.DelayedInformations;
                using (FileStream fs = File.Open(persistenceXmlConfigFilePath, FileMode.Create))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(DelayedResponsesInformation[]));
                    TextWriter txtWriter = new StringWriter();
                    xmlSer.Serialize(fs, datas);

                    fs.Close();
                }
            }
            catch (Exception) { }
        }

        private DelayedResponsesInformation[] LoadPersistedData()
        {
            DelayedResponsesInformation[] readedData = new DelayedResponsesInformation[] { };

            try
            {
                using (FileStream fs = File.Open(persistenceXmlConfigFilePath, FileMode.Open))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(DelayedResponsesInformation[]));

                    readedData = (DelayedResponsesInformation[])xmlSer.Deserialize(fs);

                    fs.Close();
                }
            }
            catch (Exception) { }

            return readedData;
        }

        #endregion

    }
}
