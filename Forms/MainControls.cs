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
    public partial class MainControls : DockContent
    {
        private DetectEnterExit _pnlMonitor;
        private readonly Docking _docking;
        private readonly KL2500LEDThreadedComPort _kl2500LedThreadedComPort;
        private readonly Timer _updateTimer = new Timer();

        public MainControls(Docking docking, KL2500LEDThreadedComPort kl2500LedThreadedComPort)
        {
            InitializeComponent();

            _updateTimer.Interval = 250;
            _updateTimer.Tick += _updateTimer_Tick;

            sliderOutputPower.OnValueChanged += SliderOutputPower_OnValueChanged;
            
            btnShutter.ToggleSet(false);
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
            var outputPower = _kl2500LedThreadedComPort.Protocol.OutputPower;
            if (!double.IsNaN(outputPower))
                sliderOutputPower.Value = (int) (outputPower * 10.0);
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

                if (_kl2500LedThreadedComPort.Protocol.RemoteType == Protocol.RemoteTypes.Toggle)
                {
                    remoteToggle.Checked = true;
                }
                else
                {
                    remoteMomentary.Checked = true;
                }

                if (_kl2500LedThreadedComPort.Protocol.LockEnable)
                {
                    frontLocked.Checked = true;
                }
                else
                {
                    frontUnlocked.Checked = true;
                }

                btnShutter.ToggleSet(_kl2500LedThreadedComPort.Protocol.ShutterEnable);

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

        private void btnShutter_Click(object sender, EventArgs e)
        {
            _kl2500LedThreadedComPort.ProtocolEcho.ShutterEnable = btnShutter.Toggle();
        }

        private void SliderOutputPower_OnValueChanged(WinForms.Controls.Combo_Controls.SliderNumericCombo control, int value)
        {
            _kl2500LedThreadedComPort.ProtocolEcho.OutputPower = value * 0.1;
        }

        private void frontLocked_CheckedChanged(object sender, EventArgs e)
        {
            _kl2500LedThreadedComPort.ProtocolEcho.LockEnable = frontLocked.Checked;
        }

        private void remoteToggle_CheckedChanged(object sender, EventArgs e)
        {
            _kl2500LedThreadedComPort.ProtocolEcho.RemoteType =
                remoteMomentary.Checked ? Protocol.RemoteTypes.Momentary : Protocol.RemoteTypes.Toggle;
        }
    }
}
