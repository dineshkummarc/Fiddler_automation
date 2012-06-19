using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aetheon.FiddlerExtensions.DelayedResponses
{
    public interface IDelayedResponsesUI
    {

        DelayedResponsesInformation[] DelayedInformations
        {
            get;
            set;
        }

        void SetRuleTester(DelayedResponsesStatus status);

    }
}
