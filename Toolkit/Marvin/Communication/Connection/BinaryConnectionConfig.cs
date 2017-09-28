﻿using System.Runtime.Serialization;
using Marvin.Configuration;
using Marvin.Modules.ModulePlugins;

namespace Marvin.Communication
{
    /// <summary>
    /// Base config for client and server config modes
    /// </summary>
    public class BinaryConnectionConfig : IPluginConfig
    {
        ///
        public virtual string PluginName
        {
            get { return "CommunicatorConfig"; }
        }
    }
}
