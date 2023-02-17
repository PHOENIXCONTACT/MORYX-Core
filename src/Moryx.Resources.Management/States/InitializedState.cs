// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Moryx.Resources.Management
{
    /// <summary>
    /// State of the <see cref="ResourceWrapper"/> when the wrappd resource was initialized
    /// </summary>
    internal class InitializedState : ResourceStateBase
    {
        /// <summary>
        /// constructor
        /// </summary>
        public InitializedState(ResourceWrapper context, StateMap stateMap) : base(context, stateMap)
        {
        }

        /// <inheritdoc />
        public override void Start()
        {
            Context.HandleStart();
            NextState(StateStarted);
        }
    }
}
