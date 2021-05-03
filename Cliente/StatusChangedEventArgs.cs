using System;

namespace Cliente
{
    public class StatusChangedEventArgs : EventArgs
    {
        public string MensagemServidor { get; private set; }

        public StatusChangedEventArgs(string mensagemServidor)
        {
            MensagemServidor = mensagemServidor;
        }
    }
}
