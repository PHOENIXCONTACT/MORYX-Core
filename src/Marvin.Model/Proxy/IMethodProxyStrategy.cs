// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Marvin.Model
{
    internal interface IMethodProxyStrategy
    {
        bool CanImplement(MethodInfo methodInfo);

        void Implement(TypeBuilder typeBuilder, MethodInfo methodInfo, Type baseType, Type targetType);
    }
}
