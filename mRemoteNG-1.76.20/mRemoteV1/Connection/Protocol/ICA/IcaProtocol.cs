using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using mRemoteNG.App;
using mRemoteNG.Connection.Protocol.RDP;
using mRemoteNG.Messages;
using mRemoteNG.Security.SymmetricEncryption;
using mRemoteNG.Tools;
using mRemoteNG.UI.Forms;

namespace mRemoteNG.Connection.Protocol.ICA
{
    public class IcaProtocol : ProtocolBase
    {
        private ConnectionInfo _info;
        private readonly FrmMain _frmMain = FrmMain.Default;

        public IcaProtocol()
        {
            tmrReconnect = new System.Timers.Timer();
        }
        
        public enum EncryptionStrength
        {
            EncrBasic,
            RC128,
            RC40,
            RC56,
            Encr128BitLogonOnly,
            Encr40Bit,
            RC128Logon
        }

        public static class Defaults
        {
            public const int Port = 1494;
        }

        public System.Timers.Timer tmrReconnect;
        public void tmrReconnect_Elapsed(object sender, System.Timers.ElapsedEventArgs e) { }
        
        public new bool Start() { return false; }
        public new void Stop() { }
        public new Form InterfaceControl { get; set; }
        public new ConnectionInfo Info { get; set; }
    }
}

