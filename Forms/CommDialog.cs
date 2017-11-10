using System;
using System.Linq;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.KL2500LED.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.KL2500LED.Control.Forms
{
    public partial class CommDialog : DockContent
    {
        private DetectEnterExit _pnlMonitor;
        private readonly KL2500LEDThreadedComPort _kl2500LedThreadedComPort;

        public CommDialog(KL2500LEDThreadedComPort kl2500LedThreadedComPort)
        {
            InitializeComponent();

            _kl2500LedThreadedComPort = kl2500LedThreadedComPort;
            _kl2500LedThreadedComPort.RegisterMessageOutput(MessageBroker.MessageContext.NewThreadToGui, args => MessageBox.WriteLine(args) );

            HideOnClose = true;
            ShowHint = DockState.Document;
            Load += LoadEvent;
        }

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

        private string _lastCommand = "";
        private void send_Click(object sender, EventArgs e)
        {
            if (command.Text.Length > 0)
            {
                _lastCommand = command.Text.Replace("\\r", "\r");
                command.Text = "";
            }
            var commands = _lastCommand.Split(new[] {';', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            commands.ForEach(com =>
            {
                _kl2500LedThreadedComPort.SendCommandSingle(com, echoComTraffic: true);
            });
        }

        private void msgClear_Click(object sender, EventArgs e)
        {
            MessageBox.ClearMessages();
        }

    }
}
