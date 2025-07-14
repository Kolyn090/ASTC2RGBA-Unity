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

    public static (int, int) GetBlock(TextureFormat astcFormat)
    {
        return astcFormat switch
        {
            TextureFormat.ASTC_4x4 or TextureFormat.ASTC_HDR_4x4 => (4, 4),
            TextureFormat.ASTC_5x5 or TextureFormat.ASTC_HDR_5x5 => (5, 5),
            TextureFormat.ASTC_6x6 or TextureFormat.ASTC_HDR_6x6 => (6, 6),
            TextureFormat.ASTC_8x8 or TextureFormat.ASTC_HDR_8x8 => (8, 8),
            TextureFormat.ASTC_10x10 or TextureFormat.ASTC_HDR_10x10 => (10, 10),
            TextureFormat.ASTC_12x12 or TextureFormat.ASTC_HDR_12x12 => (12, 12),
            _ => (-1, -1),
        };
    }
}
