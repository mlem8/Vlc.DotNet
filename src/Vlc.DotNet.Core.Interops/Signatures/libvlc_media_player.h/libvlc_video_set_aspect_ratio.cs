using System;
using System.Runtime.InteropServices;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set aspect ratio.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_aspect_ratio")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoAspectRatio(IntPtr mediaPlayerInstance, string value);
}
