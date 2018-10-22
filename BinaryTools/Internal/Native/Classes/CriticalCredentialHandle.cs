using System;
using System.Runtime.InteropServices;
using BinaryTools.Internal.Native.Structs;
using Microsoft.Win32.SafeHandles;

namespace BinaryTools.Internal.Native.Classes
{
    internal sealed class CriticalCredentialHandle : CriticalHandleZeroOrMinusOneIsInvalid
    {
        // Set the handle.
        internal CriticalCredentialHandle(IntPtr preexistingHandle)
        {
            SetHandle(preexistingHandle);
        }

        internal CREDENTIAL GetCredential()
        {
            if (!IsInvalid)
            {
                // Get the Credential from the mem location
                return (CREDENTIAL)Marshal.PtrToStructure(handle, typeof(CREDENTIAL));
            }
            else
            {
                throw new InvalidOperationException("Invalid CriticalHandle!");
            }
        }

        // Perform any specific actions to release the handle in the ReleaseHandle method.
        // Often, you need to use Pinvoke to make a call into the Win32 API to release the 
        // handle. In this case, however, we can use the Marshal class to release the unmanaged memory.

        override protected bool ReleaseHandle()
        {
            // If the handle was set, free it. Return success.
            if (!IsInvalid)
            {
                // NOTE: We should also ZERO out the memory allocated to the handle, before free'ing it
                // so there are no traces of the sensitive data left in memory.
                Advapi32.CredFree(handle);
                // Mark the handle as invalid for future users.
                SetHandleAsInvalid();
                return true;
            }
            // Return false. 
            return false;
        }
    }
}
