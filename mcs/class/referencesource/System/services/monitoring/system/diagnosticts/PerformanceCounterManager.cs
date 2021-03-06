//------------------------------------------------------------------------------
// <copyright file="PerformanceCounterManager.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace System.Diagnostics {
    using System.Runtime.InteropServices;    
    using System;    
    using System.Security.Permissions;    
    using System.Security;
    using Microsoft.Win32;

    // All of this code was ported to native and this implementation is no longer used.  It is not meant to be accessed directly.  
    // This code was no longer maintained, and it accessed the same shared memory that the new code accessed.  To be certain there 
    // are no security holes and no serious bugs, we have removed all of the real code. 
    
    
    /// <internalonly/>
    [
    ComVisible(true), GuidAttribute("82840BE1-D273-11D2-B94A-00600893B17A"),
    // Disabling partial trust scenarios
    PermissionSet(SecurityAction.LinkDemand, Name="FullTrust"),
    Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")
    ]
    public sealed class PerformanceCounterManager : ICollectData
    {
        [
            Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")
        ]
        public PerformanceCounterManager() {              
        }
        
        /// <internalonly/>
        [
            Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")
        ]
        void ICollectData.CollectData(int callIdx, IntPtr valueNamePtr, IntPtr dataPtr, int totalBytes, out IntPtr res) {
            res = (IntPtr)(-1);
        }

        /// <internalonly/>
        [
            Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")
        ]
        void ICollectData.CloseData() {            
        }
    }
}
