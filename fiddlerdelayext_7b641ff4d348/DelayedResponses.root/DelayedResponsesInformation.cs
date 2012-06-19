using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aetheon.FiddlerExtensions.DelayedResponses
{
    public class DelayedResponsesInformation
    {
        
        public bool Enabled
        {
            get;
            set;
        }

        public string UrlRegExFilter
        {
            get;
            set;
        }

        public string HeaderRegExFilter
        {
            get;
            set;
        }

        public string ContentRegExFilter
        {
            get;
            set;
        }

        public int DelaySec
        {
            get;
            set;
        }

        public DelayedResponsesInformation()
        {

        }


    }
}
