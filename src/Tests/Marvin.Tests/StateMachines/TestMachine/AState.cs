// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Marvin.Tests
{
    internal sealed class AState : MyStateBase
    {
        public AState(MyContext context, StateMap stateMap) : base(context, stateMap)
        {
        }

        public override void OnEnter()
        {
            Context.AEntered = true;
        }

        public override void Initial()
        {
            
        }

        public override void AtoB()
        {
            NextState(StateB);
            Context.HandleAtoB();
        }
    }
}
