﻿namespace Marvin.Communication.Sockets
{
    internal class ClientReconnectingState : ClientStateBase
    {
        public ClientReconnectingState(TcpClientConnection context, StateMap stateMap) : base(context, stateMap, BinaryConnectionState.AttemptingConnection)
        {
        }

        public override void OnEnter()
        {
            Context.Disconnect();
        }

        public override void ScheduledConnectTimerElapsed()
        {
            NextState(StateConnecting);
        }

        public override void ConnectionClosed()
        {
            if (Context.ReconnectDelayMs > 0)
            {
                Context.ScheduleConnectTimer(Context.ReconnectDelayMs);
            }
            else
            {
                NextState(StateConnecting);
            }
        }

        public override void Disconnect()
        {
            NextState(StateDisconnected);
        }
    }
}
