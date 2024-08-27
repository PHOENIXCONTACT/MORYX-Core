// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.ComponentModel;
using Moryx.AbstractionLayer.Products;

namespace Moryx.Products.Samples
{
    [DisplayName("Watch Needle")]
    public class NeedleType : ProductType
    {
        [Description("Length of the needle")]
        public int Length { get; set; }

        protected override ProductInstance Instantiate()
        {
            return new NeedleInstance();
        }
    }
}
