using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetAspectRatio(VlcMediaPlayerInstance mediaPlayerInstance, string aspectRatio)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAspectRatio>().Invoke(mediaPlayerInstance, aspectRatio);
        }
    }
}
