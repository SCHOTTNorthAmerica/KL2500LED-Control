using System;
using System.Drawing;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.KL2500LED.Communication;
using SCHOTT.KL2500LED.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.KL2500LED.Control.Forms
{
    public partial class MemorySettings : DockContent
    {
        private DetectEnterExit _pnlMonitor;
        private string _helpMessage = $"Click save, then the memory location you{Environment.NewLine}would like to store the current settings to.";
        private readonly KL2500LEDThreadedComPort _kl2500LedThreadedComPort;
        private readonly Docking _docking;

        public MemorySettings(Docking docking, KL2500LEDThreadedComPort kl2500LedThreadedComPort)
        {
            InitializeComponent();
            
            saveLoad.ToggleDisabledColor = Globals.OffColor;
            saveLoad.ToggleDisabledText = "Save";
            saveLoad.ToggleEnabledColor = Globals.OnColor;
            saveLoad.ToggleEnabledText = "Save";
            saveLoad.ToggleSet(false);

            DisplayControls(false);

            _docking = docking;
            _kl2500LedThreadedComPort = kl2500LedThreadedComPort;
            _kl2500LedThreadedComPort.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls(args.IsConnected));

            HideOnClose = true;
            ShowHint = DockState.Document;
            CloseButton = false;
            CloseButtonVisible = false;

            var saveTip = new ToolTip();
            saveTip.SetToolTip(saveLoad, _helpMessage);
            saveTip.OwnerDraw = true;
            saveTip.Draw += saveTip_Draw;
            saveTip.Popup += saveTip_Popup;

            Load += LoadEvent;
        }

        public void DisplayControls(bool enable)
        {
            if (!enable)
            {
                saveLoad.ToggleSet(false);
                transparentLabel.BringToFront();
            }
            else
            {
                transparentLabel.SendToBack();
            }
        }

        private void saveTip_Popup(object sender, PopupEventArgs e)
        {
            // on popip set the size of tool tip
            e.ToolTipSize = TextRenderer.MeasureText(_helpMessage, saveLoad.Font);
        }

        private void saveTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            _helpMessage = e.ToolTipText;
            e.Graphics.DrawString(e.ToolTipText, saveLoad.Font, Brushes.Black, new PointF(2, 2));
        }

        #region window functions
       
        private void LoadEvent(object sender, EventArgs e)
        {
            _pnlMonitor = new DetectEnterExit(scrollPanel);
            _pnlMonitor.ControlEnter += _pnlMonitor_ControlEnter;
            Application.AddMessageFilter(_pnlMonitor);
        }

        private void _pnlMonitor_ControlEnter(System.Windows.Forms.Control control)
        {
            scrollPanel.Focus();
        }
        
        public string FormTitle
        {
            get => Text;
            set => base.Text = value;
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }

        #endregion
        
        private void saveLoad_Click(object sender, EventArgs e)
        {
            saveLoad.Toggle();
        }

        private void MemoryClick(object sender, EventArgs e)
        {
            var location = (Protocol.SettingsLocations)Enum.Parse(typeof(Protocol.SettingsLocations), ((Button) sender).Name);

            if (saveLoad.ToggleGet())
            {
                _kl2500LedThreadedComPort.ProtocolEcho.SaveSettings(location);
                saveLoad.ToggleSet(false);
            }
            else
            {
                _kl2500LedThreadedComPort.ProtocolEcho.RestoreSettings(location);
            }
        }
    }
}
