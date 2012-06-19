using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fiddler;
using System.Windows.Forms;
using System.Threading;

namespace Aetheon.FiddlerExtensions.DelayedResponses
{
    public class DelayedResponsesExtension : IFiddlerExtension, IAutoTamper
    {
        private FiddlerUIAdapter fiddlerHook;

        public void OnBeforeUnload()
        {

        }

        public void OnLoad()
        {
            fiddlerHook =
                new FiddlerUIAdapter();
        }

        #region Http Packages

        public void AutoTamperRequestAfter(Session oSession)
        {

        }

        public void AutoTamperRequestBefore(Session oSession)
        {

        }

        public void AutoTamperResponseAfter(Session oSession)
        {

        }

        public void AutoTamperResponseBefore(Session oSession)
        {
            DelayedResponsesInformation delayData = null;

            //
            // when fiddler initialized 
            // sometimes an exception is thrown
            //
            try
            {
                delayData = fiddlerHook.GetDelayFor(
                    oSession.url,
                    oSession.GetResponseBodyAsString()
                    );
            }
            catch (Exception) { }

            if (delayData != null)
            {
                try
                {
                    Thread.Sleep(delayData.DelaySec * 1000);
                }
                catch (Exception) { }
            }
        }

        public void OnBeforeReturningError(Session oSession)
        {

        }

        #endregion


    }
}
