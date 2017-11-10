using System.Drawing;
using System.Reflection;

namespace SCHOTT.KL2500LED.Control
{
    public static class Version
    {
        public static int Major => Assembly.GetExecutingAssembly().GetName().Version.Major;
        public static int Minor => Assembly.GetExecutingAssembly().GetName().Version.Minor;
        public static string String => $"{Major}.{Minor}";
    }

    public static class Globals
    {
        public static Color OnColor = Color.LimeGreen;
        public static Color OffColor = Color.Gray;
    }
}
