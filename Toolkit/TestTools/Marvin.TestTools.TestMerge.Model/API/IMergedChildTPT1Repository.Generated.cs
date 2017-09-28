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
    /// The public API of the MergedChildTPT1 repository.
    /// </summary>
    public partial interface IMergedChildTPT1Repository : IRepository<MergedChildTPT1>
    {
        
        /// <summary>
        /// Load the MergedChildTPT1 entity associated with this TopParent
        /// </summary>
        MergedChildTPT1 LoadByTopParent(TopParent parent);
        
        /// <summary>
        /// Load the TopParent entity associated with this MergedChildTPT1
        /// to provide access to inherited properties.
        /// </summary>
        MergedChildTPT1 LoadTopParentProperties(MergedChildTPT1 child);
		/// <summary>
        /// Get all MergedChildTPT1s from the database
        /// </summary>
		/// <param name="deleted">Include deleted entities in result</param>
		/// <returns>A collection of entities. The result may be empty but not null.</returns>
        ICollection<MergedChildTPT1> GetAll(bool deleted);
        /// <summary>
        /// Get first MergedChildTPT1 that matches the given parameter 
        /// or null if no match was found.
        /// </summary>
        /// <param name="temp">Value the entity has to match</param>
        /// <returns>First matching MergedChildTPT1</returns>
        MergedChildTPT1 GetByTemp(double temp);
        /// <summary>
        /// This method returns all matching MergedChildTPT1s for given parameters
        /// </summary>
        /// <param name="combinedBaseTPT">Value for CombinedBaseTPT the MergedChildTPT1s have to match</param>
        /// <param name="combinedChildTPT">Value for CombinedChildTPT the MergedChildTPT1s have to match</param>
        IEnumerable<MergedChildTPT1> GetCombinedTPTInheritance(global::System.Nullable<int> combinedBaseTPT, global::System.Nullable<int> combinedChildTPT);

    }
}
