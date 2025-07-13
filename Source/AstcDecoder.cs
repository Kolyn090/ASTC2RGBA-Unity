[DllImport("astc_decoder", CallingConvention = CallingConvention.Cdecl)]
public class AstcDecoder
{
    public static extern bool DecodeASTC(
        byte[] astcData,
        int dataLength,
        int width,
        int height,
        byte[] outRgba);
}
