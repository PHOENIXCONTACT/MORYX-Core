// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Marvin.Communication.Sockets
{
    internal class ClientRetryConnectState : ClientStateBase
    {
        public ClientRetryConnectState(TcpClientConnection context, StateMap stateMap) : base(context, stateMap, BinaryConnectionState.AttemptingConnection)
        {
        }

        public override void ScheduledConnectTimerElapsed()
        {
            NextState(StateConnecting);
        }

        public override void Disconnect()
        {
            NextState(StateDisconnected);
        }
    }
}
