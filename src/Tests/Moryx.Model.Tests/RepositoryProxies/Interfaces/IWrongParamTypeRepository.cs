// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.Model.Repositories;

namespace Moryx.Model.Tests
{
    public interface IWrongParamTypeRepository : IRepository<SomeEntity>
    {
        SomeEntity Create(int value, string name, long value2);
    }
}
