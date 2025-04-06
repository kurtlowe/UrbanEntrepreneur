using System.Runtime.InteropServices;

namespace UrbanEntrepreneur;

internal static class Extern
{
    [DllImport("user32.dll")]
    public static extern short GetAsyncKeyState(int vKey);

    public const int VK_W = 0x57;
    public const int VK_S = 0x53;
    public const int VK_A = 0x41;
    public const int VK_D = 0x44;
    public const int VK_ESCAPE = 0x1B;
}