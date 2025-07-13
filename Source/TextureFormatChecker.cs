using UnityEngine;

public class TextureFormatChecker
{
    public static bool IsAstcFormat(TextureFormat unityFormat)
    {
        return unityFormat == TextureFormat.ASTC_4x4 ||
                unityFormat == TextureFormat.ASTC_5x5 ||
                unityFormat == TextureFormat.ASTC_6x6 ||
                unityFormat == TextureFormat.ASTC_8x8 ||
                unityFormat == TextureFormat.ASTC_10x10 ||
                unityFormat == TextureFormat.ASTC_12x12 ||
                unityFormat == TextureFormat.ASTC_HDR_4x4 ||
                unityFormat == TextureFormat.ASTC_HDR_5x5 ||
                unityFormat == TextureFormat.ASTC_HDR_6x6 ||
                unityFormat == TextureFormat.ASTC_HDR_8x8 ||
                unityFormat == TextureFormat.ASTC_10x10 ||
                unityFormat == TextureFormat.ASTC_12x12;
    }
}
