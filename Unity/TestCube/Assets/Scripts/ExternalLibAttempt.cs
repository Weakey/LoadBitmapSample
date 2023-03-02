using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Assets.Scripts
{
    internal static class ExternalLibAttempt
    {
        [DllImport(@"libimagetest", CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Auto)]
        internal extern static int getImage(Byte[] path, Byte[] buffer);
        
        [DllImport(@"libimagetest", CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Auto)]
        internal extern static void getCurrentPath(Byte[] buffer);
    }
}
