﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the Marvin template for generating Repositories and a Unit of Work for Entity Framework.
// If you have any questions or suggestions for improvement regarding this code, contact Thomas Fuchs. I allways need feedback to improve.
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. So even when you think you can do better,
// don't touch it.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Marvin.Model;
using Marvin.TestTools.Test.Model;


namespace Marvin.TestTools.TestMerge.Model
{
    /// <summary>
    /// The public API of the MergedBaseTPT repository.
    /// </summary>
    public partial interface IMergedBaseTPTRepository : IRepository<MergedBaseTPT>
    {
		/// <summary>
        /// Get all MergedBaseTPTs from the database
        /// </summary>
		/// <param name="deleted">Include deleted entities in result</param>
		/// <returns>A collection of entities. The result may be empty but not null.</returns>
        ICollection<MergedBaseTPT> GetAll(bool deleted);
        /// <summary>
        /// Get first MergedBaseTPT that matches the given parameter 
        /// or null if no match was found.
        /// </summary>
        /// <param name="temp">Value the entity has to match</param>
        /// <returns>First matching MergedBaseTPT</returns>
        MergedBaseTPT GetByTemp(double temp);
        /// <summary>
        /// This method returns all matching MergedBaseTPTs for given parameters
        /// </summary>
        /// <param name="combinedBaseTPT">Value for CombinedBaseTPT the MergedBaseTPTs have to match</param>
        IEnumerable<MergedBaseTPT> GetCombinedTPTInheritance(global::System.Nullable<int> combinedBaseTPT);

    }
}
