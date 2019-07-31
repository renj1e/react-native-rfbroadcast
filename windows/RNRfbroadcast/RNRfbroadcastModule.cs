using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Rfbroadcast.RNRfbroadcast
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRfbroadcastModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRfbroadcastModule"/>.
        /// </summary>
        internal RNRfbroadcastModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRfbroadcast";
            }
        }
    }
}
