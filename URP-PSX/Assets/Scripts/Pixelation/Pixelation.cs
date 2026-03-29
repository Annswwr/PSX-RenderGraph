using System;
using UnityEngine.Rendering;

namespace PSX
{
    [Serializable]
    [VolumeComponentMenu("PSX/Pixelation")]
    public class PixelationVolumeComponent : VolumeComponent, IPostProcessComponent
    {
        public IntParameter WidthPixelation = new IntParameter(640, true);
        public IntParameter HeightPixelation = new IntParameter(360, true);
        public FloatParameter ColorPrecision = new FloatParameter(32.0f, true);

        public bool IsActive() => AnyPropertiesIsOverridden();
    }
}