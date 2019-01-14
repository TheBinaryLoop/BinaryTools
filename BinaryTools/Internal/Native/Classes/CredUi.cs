using System;
using System.Runtime.InteropServices;
using System.Text;
using BinaryTools.Internal.Native.Enums;
using BinaryTools.Internal.Native.Structs;

#if !NETSTANDARD

namespace BinaryTools.Internal.Native.Classes
{


    internal class CredUi
    {
        [DllImport("credui.dll")]
        internal static extern CredUIReturnCodes CredUIPromptForCredentials(ref CREDUI_INFO creditUR, string targetName, IntPtr reserved1, int iError, StringBuilder userName, int maxUserName, StringBuilder password, int maxPassword, [MarshalAs(UnmanagedType.Bool)] ref bool pfSave, int flags);

        [DllImport("credui.dll", CharSet = CharSet.Unicode)]
        internal static extern CredUIReturnCodes CredUIPromptForWindowsCredentials(ref CREDUI_INFO notUsedHere, int authError, ref uint authPackage, IntPtr InAuthBuffer, uint InAuthBufferSize, out IntPtr refOutAuthBuffer, out uint refOutAuthBufferSize, ref bool fSave, int flags);

        [DllImport("credui.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool CredPackAuthenticationBuffer(int dwFlags, StringBuilder pszUserName, StringBuilder pszPassword, IntPtr pPackedCredentials, ref int pcbPackedCredentials);

        [DllImport("credui.dll", CharSet = CharSet.Auto)]
        internal static extern bool CredUnPackAuthenticationBuffer(int dwFlags, IntPtr pAuthBuffer, uint cbAuthBuffer, StringBuilder pszUserName, ref int pcchMaxUserName, StringBuilder pszDomainName, ref int pcchMaxDomainame, StringBuilder pszPassword, ref int pcchMaxPassword);
    }

}

#endif
