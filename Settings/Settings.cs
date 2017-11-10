using System.Windows.Forms;
using SCHOTT.WinForms;

namespace SCHOTT.KL2500LED.Control
{
    public class Settings
    {
        public int FontSize { get; set; } = 12;
        public WindowInformation FormSettings { get; set; } = new WindowInformation(
            FormWindowState.Normal, 850, 350, new System.Drawing.Point(0, 0));
    }
}
