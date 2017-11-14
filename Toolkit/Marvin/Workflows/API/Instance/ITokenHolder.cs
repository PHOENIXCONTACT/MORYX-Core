﻿using System.Collections.Generic;

namespace Marvin.Workflows
{
    /// <summary>
    /// Base interface for places and transitions. It declares properties and fields
    /// to to persist and restore the position of tokens.
    /// </summary>
    public interface ITokenHolder
    {
        /// <summary>
        /// Workflow unique id of this holder. Same id can be present in another workflow
        /// </summary>
        long Id { get; }

        /// <summary>
        /// All tokens on this holder
        /// </summary>
        IEnumerable<IToken> Tokens { get; set; }

        /// <summary>
        /// Internal state of the holder. This object should be used to store custom data.
        /// </summary>
        object InternalState { get; set; }
        
        /// <summary>
        /// Pause execution on this holder and stop passing of tokens
        /// </summary>
        void Pause();

        /// <summary>
        /// Resume exeuction on this holder and process placed tokens
        /// </summary>
        void Resume();
    }
}