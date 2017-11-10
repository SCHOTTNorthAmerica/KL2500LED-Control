using System;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.KL2500LED.Communication;
using SCHOTT.KL2500LED.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.KL2500LED.Control.Forms
{
    public partial class SystemInfo : DockContent
    {
        private DetectEnterExit _pnlMonitor;
        private readonly Docking _docking;
        private readonly KL2500LEDThreadedComPort _kl2500LedThreadedComPort;
        private readonly Timer _updateTimer = new Timer();

        public SystemInfo(Docking docking, KL2500LEDThreadedComPort kl2500LedThreadedComPort)
        {
            InitializeComponent();

            _updateTimer.Interval = 500;
            _updateTimer.Tick += _updateTimer_Tick;

            DisplayControls(false);

            _docking = docking;
            _kl2500LedThreadedComPort = kl2500LedThreadedComPort;
            _kl2500LedThreadedComPort.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls(args.IsConnected));

            HideOnClose = true;
            ShowHint = DockState.Document;
            CloseButton = false;
            CloseButtonVisible = false;

            Load += LoadEvent;
        }

        private void _updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
            var temp = _kl2500LedThreadedComPort.Protocol.TemperatureCelsius;
            if (!double.IsNaN(temp))
                temperature.Text = temp.ToString("0.0");
        }

        public void DisplayControls(bool enable)
        {
            _updateTimer.Enabled = enable;

            if (!enable)
            {
                transparentLabel.BringToFront();
            }
            else
            {
                transparentLabel.SendToBack();
                id.Text = _kl2500LedThreadedComPort.Protocol.FirmwareVersion;
                protocol.Text = _kl2500LedThreadedComPort.Protocol.ProtocolVersion.Insert(2, ".");

                UpdateControls();
            }
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
            set => Text = value;
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }

        #endregion

    }
}
