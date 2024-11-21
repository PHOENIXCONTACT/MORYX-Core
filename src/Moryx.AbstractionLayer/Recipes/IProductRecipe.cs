// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.AbstractionLayer.Products;

namespace Moryx.AbstractionLayer.Recipes
{
    /// <summary>
    /// Recipe which is related to a product
    /// </summary>
    public interface IProductRecipe : IRecipe
    {
        /// <summary>
        /// The product that defines this recipe and is the final
        /// product.
        /// </summary>
        IProductType Product { get; set; }

        /// <summary>
        /// The target product that should be produced with this recipe.
        /// In most cases this equals <see cref="Product"/>, but it does
        /// not have to.
        /// </summary>
        IProductType Target { get; }
    }
}
